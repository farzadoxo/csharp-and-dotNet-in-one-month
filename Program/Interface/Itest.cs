public interface Itest
{
    public int MyID { get; set; }
    public void Start()
    {
        Console.WriteLine("installed");
    }
    public abstract void Start2();

    public virtual void Start3()
    {
        Console.WriteLine("installed");
    }
}

