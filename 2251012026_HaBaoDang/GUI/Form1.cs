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
        private SqlDataAdapter adapter;
        private SqlConnection conn;
        private DataTable table;
        public Form1()
        {
            InitializeComponent();
            string strcnn = "Data Source=.;Initial Catalog=CoffeeShop;Integrated Security=True";
            conn = new SqlConnection(strcnn);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string strcmd = "SELECT * FROM Supplier";
                adapter = new SqlDataAdapter(strcmd, conn);

                table = new DataTable();
                adapter.Fill(table);

                dataDGV.DataSource = table;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string strcmd = "DELETE FROM Supplier WHERE id = @id";
            
            SqlCommand cmd = new SqlCommand(strcmd, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@id", SqlDbType.VarChar,20,"id");
            adapter.DeleteCommand = cmd;


            string i_strcmd = "INSERT INTO Supplier VALUES(@id,@ten,@diachi)";

            SqlCommand i_cmd = new SqlCommand(i_strcmd, conn);
            i_cmd.CommandType = CommandType.Text;

            i_cmd.Parameters.Add("@id", SqlDbType.VarChar, 20, "id");
            i_cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 100, "name");
            i_cmd.Parameters.Add("@diachi", SqlDbType.NVarChar, 200, "address");
            adapter.InsertCommand = i_cmd;


            adapter.Update(table);
        }

        private void dataDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
