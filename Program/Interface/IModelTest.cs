public class ModelTest : Imodel , Itest
{
    public int Id { get; set; }
    public int MyID { get; set; }
    public string? Name {get; set;}

    public void Start()
    {
        Console.WriteLine("INITIALIZE");
    }

    public void Start2()
    {
        Console.WriteLine("This is a test string !!");
    }
}