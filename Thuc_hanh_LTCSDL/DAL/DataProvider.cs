using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class DataProvider
    {
        private SqlConnection cn;

        public DataProvider()
        {
            string strcn = "Data Source=.;Initial Catalog=CoffeeShop;Integrated Security=True";
            cn = new SqlConnection(strcn);
        }

        public void connect()
        {
            try
            {
                if (cn.State == ConnectionState.Closed && cn!=null)
                {
                    cn.Open();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void disconnect()
        {
            try
            {
               
                if (cn.State == ConnectionState.Open && cn != null)
                {
                    cn.Close();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
           
        }

        public Object MyExecuteScalar(string sql,CommandType type)
        {
            
            try
            {
                connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = type;
                
                return cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                disconnect();
            }
        }
        public SqlDataReader myExecuteReader(string sql,CommandType type)
        {
            try
            {
             
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = type;

                return cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            
        }
    }
}
