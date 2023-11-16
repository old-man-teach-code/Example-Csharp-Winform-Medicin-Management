using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicinManagement
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int Amount { get; set; }
        public string ExpiredDate { get; set; }

        public bool Prioritize { get; set; }

        public ProductType Type { get; set; }

        public Product() {
            
        }

        public Product(int Id, string ProductName, int Price, int Amount, string ExpiredDate, ProductType type)
        {
            this.Id = Id;
            this.ProductName = ProductName;
            this.Price = Price;
            this.Amount = Amount;
            this.ExpiredDate = ExpiredDate;
            this.Prioritize = false;
            this.Type = type;

        }
    }
}
