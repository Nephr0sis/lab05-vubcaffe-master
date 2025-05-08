using System;
using System.Collections.Generic;
namespace VubCaffe.Models
{
    public class Bill
    {
        private List<IProduct> items;

        public Bill()
        {
            items = new List<IProduct>();
        }

        public void AddItem(IProduct product)
        {
            items.Add(product);
        }

        public double GetTotalPrice()
        {
            return items.Sum(item => item.Price);
        }

        public List<string> GetBillEntries()
        {
            return items.Select(item => item.GetBillEntry()).ToList();
        }

        public void ClearBill()
        {
            items.Clear();
        }

        public bool IsEmpty()
        {
            return items.Count == 0;
        }
    }
}