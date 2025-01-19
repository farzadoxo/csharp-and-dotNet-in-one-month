public class Cat : Animal
{
    public override void Moving()
    {
        Console.WriteLine("Cat is moving !");
    }

    public override void Sleep()
    {
        Console.WriteLine("Cat asleep !");
    }

    public override void Eating()
    {
        base.Eating();
    }
}