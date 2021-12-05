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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Load settings from file or default settings
            LoadSettings(sender, e);
            updateStatusTripInfo();

            //Assign events
            Application.ApplicationExit += SaveSettings;
            Engine.size += LoadFromText;
            Engine.update += updateStatusTripInfo;
            Engine.update += graphicsPanel1.Refresh;

            Engine.ChangeSize(Engine.Rows, Engine.Columns);

            label1.BringToFront();
            label2.BringToFront();
            label3.BringToFront();
            label4.BringToFront();
        }

        private void startStripMenu_ItemClicked(object sender, System.EventArgs e)
        {
            Engine.Start();
            startStripMenuItem.Enabled = false;
            toolStripStartButton.Enabled = false;
            pauseStripMenuItem.Enabled = true;
            toolStripPauseButton.Enabled = true;
            nextStripMenuItem.Enabled = false;
        }

        private void pauseStripMenu_ItemClicked(object sender, System.EventArgs e)
        {
            Engine.Pause();
            startStripMenuItem.Enabled = true;
            toolStripStartButton.Enabled = true;
            pauseStripMenuItem.Enabled = false;
            toolStripPauseButton.Enabled = false;
            nextStripMenuItem.Enabled = true;
        }

        private void nextStripMenu_ItemClicked(object sender, System.EventArgs e)
        {
            if (!Engine.timer.Enabled)
                Engine.Update(sender, e);
        }

        private void seedStripMenu_ItemClicked(object sender, System.EventArgs e)
        {
            SeedDialogue dialogue = new();
            dialogue.Show();
        }

        private void currentSeedStripMenu_ItemClicked(object sender, System.EventArgs e)
        {
            Engine.Randomize(Engine.Seed);
        }

        private void timeStripMenu_ItemClicked(object sender, System.EventArgs e)
        {
            DateTime time = DateTime.Now;
            Engine.Randomize((int)time.Ticks);
        }

        private void toStripMenu_ItemClicked(object sender, System.EventArgs e)
        {
            To_Dialogue dialogue = new();
            dialogue.Show();
        }

        private void exitToolStripMenu_ItemClicked(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void backColorDialogue(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Engine.BackGroundColor = colorDialog1.Color;
                graphicsPanel1.Refresh();
            }
        } 

        private void cellColorDialogue(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Engine.CellColor = colorDialog1.Color;
                graphicsPanel1.Refresh();
            }
        }

        private void gridColorDialogue(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Engine.GridColor = colorDialog1.Color;
                graphicsPanel1.Refresh();
            }
        }

        private void gridX10ColorDialogue(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Engine.GridX10Color = colorDialog1.Color;
                graphicsPanel1.Refresh();
            }
        }

        private void optionsDialogue(object sender, EventArgs e)
        {
            Options options = new();
            options.Show();
        }

        private void updateStatusTripInfo()
        {
            label1.Text = $"Generations: {Engine.Generation}";
            label2.Text = $"Alive: { Engine.AllAliveCells()}";
            label3.Text = $"Boundary Type: { Engine.type}";
            label4.Text = $"Universe Size: {Engine.Rows}x{Engine.Columns}";
            toolStripStatusLabel1.Text = $"Generations: {Engine.Generation} Interval: {Engine.timer.Interval} Alive: {Engine.AllAliveCells()} Seed: {Engine.Seed}";
        }

        private void toroidalClick(object sender, EventArgs e)
        {
            if (toroidalStripMenuItem.Checked)
                return;
            toroidalStripMenuItem.Checked = true;
            finiteStripMenuItem.Checked = false;
            Engine.ChangeType(UniverseType.Toroidal);
        }

        private void finiteClick(object sender, EventArgs e)
        {
            if (finiteStripMenuItem.Checked)
                return;
            toroidalStripMenuItem.Checked = false;
            finiteStripMenuItem.Checked = true;
            Engine.ChangeType(UniverseType.Finite);
        }

        private void Empty(object sender, EventArgs e)
        {
            Engine.Empty();
            Engine.Generation = 0;
        }

        private void saveFileDialog1_FileOk(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            // set a default file name
            savefile.FileName = "unknown.txt";
            // set filters - this can be done in properties as well
            savefile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                //write text into chosen file
                StreamWriter sw = new(savefile.FileName);
                sw.WriteLine(Engine.GetPlainText());
                sw.Close();
            }
        }

        private void openFileDialog1_FileOk(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new();
            // Filter
            openFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

;            if (openFile.ShowDialog() == DialogResult.OK)
            {
                //Read from the file
                StreamReader sr = new(openFile.FileName);
                LoadFromText(sr.ReadToEnd());
                sr.Close();
            }
            graphicsPanel1.Refresh();
        }

        private void importFileDialog1_FileOk(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new();

            openFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            ; if (openFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new(openFile.FileName);
                Import(sr.ReadToEnd());
                sr.Close();
            }
        }

        private void ResetClick(object sender, EventArgs e)
        {
            Engine.ResetSettings();
        }

        public void LoadFromText(string text)
        {
            var Cells = Engine.Cells;

            // Clear old Cells
            Cells.Clear();

            //Split text into columns
            string[] strings = text.Split('\n');

            for (int i = 0; i < strings.Length; i++)
            {
                var row = strings[i];

                if (row.Length < 5 || row[0] == '!')
                    continue;

                List <Engine.Cell> cellRow = new();
                for (int index = 0; index < row.Length; index++)
                {
                    var character = row[index];

                    // Add button and state to the list
                    if (character == '.')
                        cellRow.Add(new Engine.Cell(CellState.Empty));
                    else if (character == 'O')
                        cellRow.Add(new Engine.Cell(CellState.Alive));
                    else
                        continue;
                }
                Cells.Add(cellRow);
            }

            Engine.Generation = 0;
            // Update display
            Engine.Cells = Cells;
            Engine.UpdateDisplaying();
            Engine.update.Invoke();
            graphicsPanel1.Refresh();
        }

        private void Import(string text)
        {
            string[] strings = text.Split('\n');

            for (int i = 0; i < Math.Min(strings.Length, Engine.Rows); i++)
            {
                if (strings[i][0] == '!')
                    continue;
                for (int ind = 0; ind < Math.Min(strings[i].Length, Engine.Columns); ind++)
                {
                    if (strings[i][ind] == '.')
                        Engine.ChangeState(i, ind, CellState.Empty);
                    else if (strings[i][ind] == 'O')
                        Engine.ChangeState(i, ind, CellState.Alive);
                }
            }
            graphicsPanel1.Refresh();
        }

        private void ShowDisplayCount(object sender, EventArgs e)
        {
            Engine.DisplayNeighbours = countStripMenuItem.Checked;
            Engine.UpdateDisplaying();
            graphicsPanel1.Refresh();
        }

        private void ToggleGrid(object sender, EventArgs e)
        {
            Engine.GridOn = gridStripMenuItem.Checked;
            graphicsPanel1.Refresh();
        }

        private void SaveSettings(object sender, EventArgs e)
        {
            StreamWriter stream = new("settings.txt", false);
            stream.WriteLine(Engine.Rows + " " + Engine.Columns + " " + Engine.timer.Interval);
            stream.Close();
        }

        private void LoadSettings(object sender, EventArgs e)
        {
            try
            {
                // Load settings from the file
                StreamReader reader = new("settings.txt");
                string text = reader.ReadLine();
                string[] settings = text.Split();
                Engine.Rows = int.Parse(settings[0]);
                Engine.Columns = int.Parse(settings[1]);
                Engine.timer.Interval = int.Parse(settings[2]);
                reader.Close();
            }
            catch 
            {
                // Default settings if file doesn't exist
                Engine.ResetSettings();
            };
        }

        private void ToggleHUD(object sender, EventArgs e)
        {
            if (hudStripMenuItem.Checked)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
            }
            else 
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void graphicsPanel1_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            
            int buttonSizeX = (graphicsPanel1.Width - graphicsPanel1.Location.X - graphicsPanel1.Margin.Size.Width) / Engine.Columns;
            int buttonSizeY = (graphicsPanel1.Height - graphicsPanel1.Location.Y - graphicsPanel1.Margin.Size.Height) / Engine.Rows;
            int iterationX = 0;
            int iterationY = 0;

            SolidBrush brush;
            for (int i = 0; i < Engine.Cells.Count; i++)
            {
                for (int index = 0; index < Engine.Cells[i].Count; index++)
                {
                    Rectangle rectangle = new(graphicsPanel1.Location.X + graphicsPanel1.Margin.Size.Width + iterationX * buttonSizeX, graphicsPanel1.Location.Y + graphicsPanel1.Margin.Size.Height + iterationY * buttonSizeY, buttonSizeX, buttonSizeY);
                    Pen pen;

                    if (Engine.GridOn)
                        pen = new(Engine.GridColor, 5);
                    else
                        pen = new(BackColor);

                    if (Engine.Cells[i][index].State == CellState.Alive)
                        brush = new(Engine.CellColor);
                    else
                        brush = new(Engine.BackGroundColor);

                    e.Graphics.DrawRectangle(pen, rectangle);
                    e.Graphics.FillRectangle(brush, rectangle);
                    iterationX++;
                    var cell = Engine.Cells[i][index];
                    cell.rectangle = rectangle;
                    Engine.Cells[i][index] = cell;

                    if (Engine.DisplayNeighbours)
                    {
                        StringFormat format = new();
                        format.LineAlignment = StringAlignment.Center;
                        format.Alignment = StringAlignment.Center;
                        e.Graphics.DrawString(Engine.AliveCellsAround(i, index).ToString(), new Font(FontFamily.GenericSansSerif, 12), new SolidBrush(Engine.GridColor), new PointF(rectangle.X + rectangle.Width / 2, rectangle.Y + rectangle.Height / 2), format);
                    }
                }
                iterationY++;
                iterationX = 0;
            }
        }

        private void graphicsPanel1_Click(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < Engine.Cells.Count; i++)
            {
                for (int index = 0; index < Engine.Cells[i].Count; index++)
                {
                    Engine.Cell cell = Engine.Cells[i][index];
                    if (cell.rectangle.Contains(e.Location))
                    {
                        if (cell.State == CellState.Alive)
                            Engine.ChangeState(i, index, CellState.Empty);
                        else
                            Engine.ChangeState(i, index, CellState.Alive);
                        Engine.update.Invoke();
                    }
                }
            }
            graphicsPanel1.Refresh();
        }

        private void cellColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Engine.CellColor = colorDialog1.Color;
                graphicsPanel1.Refresh();
            }
        }

        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Engine.BackGroundColor = colorDialog1.Color;
                graphicsPanel1.Refresh();
            }
        }
    }
}
