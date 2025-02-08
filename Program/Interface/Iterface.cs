public interface Iterface
{
    public int Id { get; set; }
    public void Hello()
    {
        Console.WriteLine("Hey.");
    }

    public virtual void Hey()
    {
        Console.WriteLine("sfd");
    }
}