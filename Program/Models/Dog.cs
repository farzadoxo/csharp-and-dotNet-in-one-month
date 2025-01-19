public class Dog : Animal
{
    public override void Moving()
    {
        Console.WriteLine("Dog is moving !");
    }

    public override void Sleep()
    {
        Console.WriteLine("Dog Asleep !");
    }

    public override void Eating()
    {
        Console.WriteLine("Dog Eating !");
    }
}