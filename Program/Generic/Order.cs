public class Order 
{
    public Order(int id , string owner ,IEnumerable<Item> item)
    {
        Id = id;
        Owner = owner;
        OrderItems = item;
    }
    public int Id { get; set; }
    public string? Owner { get; set; }
    public IEnumerable<Item> OrderItems { get; set;}

    public void ShowOrderInfo()
    {
        Console.WriteLine($"This order owned by {Owner} and have this items : {OrderItems} ID >>> {Id}");
    }
}