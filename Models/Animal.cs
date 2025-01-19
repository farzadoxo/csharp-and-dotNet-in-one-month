public abstract class Animal
{
    public string? Name { get; set; }
    public string? Type { get; set; }
    public string? Category { get; set; }
    public int Age { get; set; }
    public bool Gender { get; set; }


    public abstract void Moving();

    public abstract void Sleep();

    public virtual void Eating();
}
