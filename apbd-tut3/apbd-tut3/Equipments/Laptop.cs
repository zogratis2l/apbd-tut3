namespace apbd_tut3;

public class Laptop : Equipment
{
    public string GPU { get; set; }
    public string CPU { get; set; }


    public Laptop(string name, bool isAvailable, string manufacturer, string model, string gpu, string cpu) :
        base(name, manufacturer, model)
    {
        GPU = gpu;
        CPU = cpu;
    }
    
}