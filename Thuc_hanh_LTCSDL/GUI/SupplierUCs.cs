using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BLL;
using DTO;
namespace GUI
{
    public partial class SupplierUCs : UserControl
    {
        suplierBLL supbll;
        public SupplierUCs()
        {
            InitializeComponent();
             supbll = new suplierBLL();
        }

        private void supDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SupplierUCs_Load(object sender, EventArgs e)
        {
            try
            {

                List<supplier> temp = supbll.supplier();
                dataGridView1.DataSource = temp;
                //supDGV.DataSource = supbll.supplier();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("loi " + ex.Message);
            }
        }
    }
}
