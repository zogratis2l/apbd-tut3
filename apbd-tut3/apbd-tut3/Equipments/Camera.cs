namespace apbd_tut3;

public class Camera : Equipment
{
    public int MegaPixels { get; set; }
    public string LensType  { get; set; }

    public Camera(string name, bool isAvailable, string manufacturer, string model, int megaPixels, string lensType) :
        base(name, manufacturer, model)
    {
        LensType = lensType;
        MegaPixels = megaPixels;
    }
    
}