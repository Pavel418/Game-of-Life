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
    public partial class To_Dialogue : Form
    {
        public To_Dialogue()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < numericUpDown1.Value; i++)
                Engine.Update(sender, e);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
