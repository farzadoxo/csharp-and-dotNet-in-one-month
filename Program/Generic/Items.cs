public class Item : IProduct
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Type { get; set; }
    public byte Count { get; set; }

}