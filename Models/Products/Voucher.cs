using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VubCaffe.Models.Products
{
    public class Voucher : IProduct
    {
        public string Name { get; }
        public double Price { get; }

        public Voucher(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string GetBillEntry()
        {
            return $"{Name} - {Price:F2} EUR";
        }
    }
}
