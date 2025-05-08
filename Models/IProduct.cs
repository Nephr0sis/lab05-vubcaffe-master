namespace VubCaffe.Models
{
    public interface IProduct
    {
        string Name { get; }
        double Price { get; }
        string GetBillEntry();
    }
}