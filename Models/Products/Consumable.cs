namespace VubCaffe.Models.Products
{
    public abstract class Consumable : IProduct
    {
        public abstract string Name { get; }
        public abstract double Price { get; }

        public virtual string GetBillEntry()
        {
            return $"{Name} - {Price:F2} EUR";
        }
    }
}