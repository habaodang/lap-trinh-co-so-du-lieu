using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool checkLogin(Account account)
        {
            return true;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string user,pass;
            user = usernameTxt.Text;
            pass = passwordLbl.Text;

            Account account = new Account(user, pass);

            if (checkLogin(account))
            {
                    this.DialogResult = DialogResult.OK;

            }

            else
            {
                DialogResult result= MessageBox.Show("Tai khoan mat khau khong chinh xac!!! ", "thong bao", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                if(result == DialogResult.Retry)
                {
                    passwordTxt.Clear();
                    usernameTxt.Focus();
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                }

            }
        }
    }
}
