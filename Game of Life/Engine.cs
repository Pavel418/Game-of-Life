using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_of_Life
{
    static class Engine
    {
        public static UniverseType type = UniverseType.Toroidal;

        public static int Rows;
        public static int Columns;

        public static readonly Point startPosition = new(15, 50);
        public const int DefaultRows = 10;
        public const int DefaultColumns = 10;
        public const int DefaultInterval = 500;
        // List of Cells
        public static List<List<Cell>> Cells = new();

        // Cells that must be changed after Update 
        public static List<int> CellsToUpdateX = new();
        public static List<int> CellsToUpdateY = new();
        public static List<CellState> CellsToUpdateState = new();

        public static Timer timer = new();

        public static int Seed;
        public static int Generation = 0;

        public static bool GridOn = true;
        public static Color CellColor = Color.Blue;
        public static Color BackGroundColor = Color.White;
        public static Color GridColor = Color.Red;
        public static Color GridX10Color;

        public static bool DisplayNeighbours = true;

        public delegate void DisplayUpdate();
        public static DisplayUpdate update;

        public delegate void UpdateUniverseSize(string text);
        public static UpdateUniverseSize size;

        public static void Start()
        {
            // Update method is called when timer interval has elapsed
            timer.Tick += new EventHandler(Update);
            timer.Start();
        }

        // Pause method Stops or Starts the timer
        static public void Pause()
        {
            if (timer.Enabled)
                timer.Stop();
            else
                timer.Start();
        }

        //Update Cells to the next generation
        public static void Update(object sender, EventArgs e)
        {
            Generation++;

            // Loop through all the Cells
            for (int i = 0; i < Cells.Count; i++)
            {
                for (int index = 0; index < Cells[i].Count; index++)
                {
                    // Get current Cell
                    Cell cell = Cells[i][index];

                    // livingCells stores number of live cells around current Cell
                    int livingCells = AliveCellsAround(i, index);

                    if (cell.State == CellState.Alive)
                    {
                        // If current cell is alive - use rule for living cells
                        if (livingCells < 2 || livingCells > 3)
                        {
                            // If there are not enough or too many cells around - Cell is updated to empty 
                            CellsToUpdateX.Add(i);
                            CellsToUpdateY.Add(index);
                            CellsToUpdateState.Add(CellState.Empty);
                        }
                    }
                    else
                    {
                        // If current cell is empty - use rule for empty cells
                        if (livingCells == 3)
                        {
                            // If there are enough cells around to create a new cell - Cell is updated to living
                            CellsToUpdateX.Add(i);
                            CellsToUpdateY.Add(index);
                            CellsToUpdateState.Add(CellState.Alive);
                        }
                    }
                }
            }
            // Update chosen Cells
            UpdateCells();
            update.Invoke();
        }

        // Update Cells from "CellsToUpdate" list
        private static void UpdateCells()
        {
            for (int i = 0; i < CellsToUpdateX.Count; i++)
            {
                // Use its values to update the Cell
                ChangeState(CellsToUpdateX[i], CellsToUpdateY[i], CellsToUpdateState[i]);
            }

            // Clear the list after all Cells are updated
            CellsToUpdateX.Clear();
            CellsToUpdateY.Clear();
            CellsToUpdateState.Clear();

            UpdateDisplaying();
        }

        // Change universe size
        public static void ChangeSize(int height, int width)
        {
            string text = "";
            for (int i = 0; i < height; i++)
            {
                for (int index = 0; index < width; index++)
                {
                    text += '.';
                }
                text += '\n';
            }
            // Invoke layout constructor
            size.Invoke(text);
        }

        // Empty all the Cells
        public static void Empty()
        {
            // Loop iterates through all the Cells
            for (int i = 0; i < Cells.Count; i++)
            {
                for (int index = 0; index < Cells[i].Count; index++)
                {
                    // Change Cell's state to empty
                    ChangeState(i, index, CellState.Empty);
                }
            }
            update.Invoke();
        }

        // Change chosen Cell's state
        public static void ChangeState(int row, int collumn, CellState state)
        {
            // Get needed state from the list
            Cell cell = Cells[row][collumn];

            // Change its state
            cell.ChangeState(state);

            // Assign new Cell to the list
            Cells[row][collumn] = cell;
        }

        public static void Randomize(int seed)
        {
            Seed = seed;

            Random random = new(seed);

            for (int i = 0; i < Cells.Count; i++)
                for (int ind = 0; ind < Cells[i].Count; ind++)
                    ChangeState(i, ind, (CellState)random.Next(0, 2));

            Generation = 0;
            UpdateDisplaying();
            update.Invoke();
        }

        // Get All live cells' count
        public static int AllAliveCells()
        {
            int count = 0;
            foreach (var list in Cells)
                foreach (var cell in list)
                    if (cell.State == CellState.Alive)
                        count++;
            return count;
        }

        public static int AliveCellsAround(int i, int index)
        {
            // livingCells stores number of live cells around current Cell
            int livingCells = 0;

            if (type == UniverseType.Finite)
            {
                // Loop check of neighbour cells
                for (int a = -1; a < 2; a++)
                {
                    for (int b = -1; b < 2; b++)
                    {
                        // Continue if values are out of list's range
                        if (i + a < 0 || index + b < 0 || i + a >= Cells.Count || index + b >= Cells[i].Count)
                            continue;

                        // Continue if neighbour cell is currently chosen cell
                        if (a == 0 && b == 0)
                            continue;

                        // If neighbour cell is alive - add 1 to livingCells
                        if (Cells[i + a][index + b].State == CellState.Alive)
                            livingCells++;
                    }
                }
            }
            else if (type == UniverseType.Toroidal)
            {
                // Loop check of neighbour cells
                for (int a = -1; a < 2; a++)
                {
                    for (int b = -1; b < 2; b++)
                    {
                        int row, column;

                        // Continue if neighbour cell is currently chosen cell
                        if (a == 0 && b == 0)
                            continue;

                        if (a + i < 0)
                            row = Cells.Count - 1;
                        else if (a + i >= Cells.Count)
                            row = 0;
                        else
                            row = a + i;

                        if (b + index < 0)
                            column = Cells[row].Count - 1;
                        else if (b + index >= Cells[row].Count)
                            column = 0;
                        else
                            column = b + index;

                        // If neighbour cell is alive - add 1 to livingCells
                        if (Cells[row][column].State == CellState.Alive)
                            livingCells++;
                    }
                }
            }

            return livingCells;
        }

        // Update neighbour count
        public static void UpdateDisplaying()
        {
            for (int i = 0; i < Cells.Count; i++)
                for (int ind = 0; ind < Cells[i].Count; ind++)
                {
                    var cell = Cells[i][ind];
                    if (DisplayNeighbours)
                        cell.Text = AliveCellsAround(i, ind).ToString();
                    else
                        cell.Text = "";
                    Cells[i][ind] = cell;
                }
        }

        public static void ChangeType(UniverseType Type)
        {
            type = Type;
            UpdateDisplaying();
            update.Invoke();
        }

        public static string GetPlainText()
        {
            string text = "";

            // Iterates through text and writes all cells into string
            for (int i = 0; i < Cells.Count; i++)
            {
                for (int ind = 0; ind < Cells[i].Count; ind++)
                {
                    if (Cells[i][ind].State == CellState.Alive)
                        text += 'O';
                    else
                        text += '.';
                }
                text += '\n';
            }
            return text;
        }
        // Default settings from constants 
        public static void ResetSettings()
        {
            Rows = DefaultRows;
            Columns = DefaultColumns;
            timer.Interval = DefaultInterval;
        }

        public struct Cell
        {
            public CellState State;
            public string Text;
            public Rectangle rectangle;

            public Cell(CellState state) : this()
            {
                State = state;
            }

            public Cell(CellState state, string text, Rectangle rectangle)
            {
                State = state;
                Text = text;
                this.rectangle = rectangle;
            }

            // Change Cell's state and color
            public void ChangeState(CellState state)
            {
                // If Cell is already in needed state - return
                if (State == state)
                    return;

                State = state;
            }
        }
    }

    enum CellState
    {
        Empty,
        Alive
    }

    enum UniverseType
    {
        Finite,
        Toroidal
    }
}
