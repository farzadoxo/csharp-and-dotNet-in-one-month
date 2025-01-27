public class Phone
{
    public Phone(Battery battery)
    {
        PhoneBattery = battery;
    }
    public int Id { get; set; }
    public string? Company { get; set; }
    public string? Model { get; set; }
    public Battery PhoneBattery { get; set; }
}