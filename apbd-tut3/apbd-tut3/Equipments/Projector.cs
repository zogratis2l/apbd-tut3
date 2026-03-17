namespace apbd_tut3;

public class Projector : Equipment
{
    public int Lumens { get; set;}
    public string Resolution { get; set; }

    public Projector(string name, bool isAvailable, string manufacturer, string model, int lumens,
        string resolution) : base(name, isAvailable, manufacturer, model) {
        Lumens = lumens;
        Resolution = resolution;
    }
    
    
}