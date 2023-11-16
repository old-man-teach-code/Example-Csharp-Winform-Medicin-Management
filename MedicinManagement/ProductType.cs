using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicinManagement
{
    public class ProductType
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public ProductType(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }
    }
}
