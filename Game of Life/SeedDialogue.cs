using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_of_Life
{
    public partial class SeedDialogue : Form
    {
        private int Seed;

        public SeedDialogue()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Engine.Randomize(Seed);
            this.Hide();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            Random random = new();
            Seed = random.Next();
            if (random.Next(0, 2) == 0)
                Seed *= -1;
            numericUpDown1.Value = Seed;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Seed = (int)numericUpDown1.Value;
        }
    }
}
