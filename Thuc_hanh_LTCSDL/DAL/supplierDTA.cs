using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class supplierDTA:DataProvider
    {
        
        public List<supplier> GetSuppliers()
        {
            List<supplier> suppliers = new List<supplier>();
            string id, name, address;
            string strcmd = "SELECT * FROM Supplier";
            try
            {
                connect();
                SqlDataReader reader= myExecuteReader(strcmd, System.Data.CommandType.Text);

                while (reader.Read())
                {
                    id = reader["id"].ToString();
                    name = reader["name"].ToString();
                    address = reader["address"].ToString();

                    supplier sup = new supplier(id, name, address);

                    suppliers.Add(sup);
                }
                reader.Close();
                
                    return suppliers;
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                disconnect();
            }
        }
    }
}
