using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public suplierBLL supbll;
       
        public Form1()
        {
            InitializeComponent();
            supbll = new suplierBLL();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                List<supplier> temp = supbll.supplier();
                dataGridView1.DataSource = supbll.supplier();
                //supDGV.DataSource = supbll.supplier();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("loi " + ex.Message);
            }
        }
    }
}
