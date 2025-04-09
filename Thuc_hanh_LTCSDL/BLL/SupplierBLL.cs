using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BLL
{
    public class suplierBLL
    {
        private supplierDTA supplierDta;
        public suplierBLL()
        {
            supplierDta = new supplierDTA();
        }
        public List<supplier> supplier()
        {
            try
            {
                return supplierDta.GetSuppliers();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
