using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    class DataProvider
    {
        private SqlConnection cn;

        public DataProvider()
        {
            string strcn = "Data Source=.;Initial Catalog=CoffeeShop;Integrated Security=True";
            cn = new SqlConnection(strcn);
        }

        private void connect()
        {
            try
            {
                string= "";
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
