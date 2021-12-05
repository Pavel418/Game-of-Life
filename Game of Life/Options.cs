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
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Engine.timer.Interval = (int)numericUpDown1.Value;
            Engine.Rows = (int)numericUpDown2.Value;
            Engine.Columns = (int)numericUpDown3.Value;
            Engine.ChangeSize(Engine.Rows, Engine.Columns);
            this.Hide();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Options_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = Engine.timer.Interval;
            numericUpDown2.Value = Engine.Rows;
            numericUpDown3.Value = Engine.Columns;
        }
    }
}
