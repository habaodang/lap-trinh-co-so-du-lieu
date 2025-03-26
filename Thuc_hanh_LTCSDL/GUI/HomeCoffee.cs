using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class HomeCoffee : Form
    {
        public HomeCoffee()
        {
            InitializeComponent();
        }

        private void HomeCoffee_Load(object sender, EventArgs e)
        {
            this.Show();
            this.Enabled = false;

            Login login = new Login();
            DialogResult result = login.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.Enabled = true;
                label1.Text = " Welcome Back USER";
            }
            else
            {
                Application.Exit();
            }

        }
    }
}
