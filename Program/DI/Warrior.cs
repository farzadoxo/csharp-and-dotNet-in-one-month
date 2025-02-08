public class Warrior
{
    private readonly Iweapon _WarriorWeapon;
    public Warrior(Iweapon weapon)
    {
        this._WarriorWeapon = weapon;
    }

    public void Attack()
    {
        this._WarriorWeapon.Hit();
        Console.WriteLine("Warrior Attacked !");
    }
}