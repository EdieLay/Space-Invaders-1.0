using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Invaders
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void buttonPlay0_Click(object sender, EventArgs e)
        {
            NameForm nameform = new NameForm();
            nameform.Show(); 
            this.Hide();
        }

        private void buttomResults_Click(object sender, EventArgs e)
        {
            ResultsForm resultsform = new ResultsForm(); 
            resultsform.Show();
            this.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
