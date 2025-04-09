using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class supplier
    {
        private string id { get; set; }
        private string name { get; set; }

        private string address { get; set; }

        public supplier(string id, string name, string address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }
    }
}
