namespace apbd_tut3;

public abstract class Equipment
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsAvailable {get; set;}
    public string Manufacturer { get; set; }
    public string Model { get; set; }
}