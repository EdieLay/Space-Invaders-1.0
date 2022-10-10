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
    public partial class NameForm : Form
    {
        public NameForm()
        {
            InitializeComponent();
        }

        private void buttonPlay1_Click(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                UI.NameError(sender, e);
                return;
            }
            Data.PlayerName = userNameField.Text;
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
