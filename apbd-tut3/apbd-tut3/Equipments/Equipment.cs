namespace apbd_tut3;

public abstract class Equipment
{
   private static int nextId = 1;
    
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsAvailable {get; set;}
    public string Manufacturer { get; set; }
    public string Model { get; set; }

    public Equipment(string name,bool isAvailable, string manufacturer, string model)
    {
        Id = nextId++;
        Name =  name;
        IsAvailable = isAvailable;
        Manufacturer = manufacturer;
        Model = model;
    }
    
}