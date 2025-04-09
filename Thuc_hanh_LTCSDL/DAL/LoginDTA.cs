using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using System.Data;

namespace DAL
{
    public class LoginDTA:DataProvider
    {
        public bool login(Account acc)
        {
            string strcmd = "SELECT COUNT(UserName) FROM USERS WHERE UserName= '" + acc.username + "' AND Password='" + acc.password + "'";
            try
            {
                
                return (int)(MyExecuteScalar(strcmd, CommandType.Text)) > 0;
            }
            catch(SqlException ex)
            {
                throw ex;
            }
         
            
        }
    }
}
