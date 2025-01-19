public class Phone
{

    // Phone has battry (AGGRIGATION)
    public void Phone(Battrey battrey)
    {
        battery = battrey
    }
    public int Id { get; set; }
    public string? Model { get; set; }
    public string? Company { get; set; }
    public Battery battery { get; set; }   
}