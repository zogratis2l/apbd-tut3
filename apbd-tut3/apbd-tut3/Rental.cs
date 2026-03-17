using apbd_tut3.Users;

namespace apbd_tut3;

public class Rental
{
    private static int nextId = 1;
    
    public User user { get; set; }
    
    public Equipment equipment { get; set; }
    
    public int Id { get; set; }
    
    DateTime RantalDate { get; set; }
    
    DateTime RentalTime { get; set; }
    
    DateTime ReturnDate { get; set; }


    public Rental(User who, Equipment what)
    {
        Id = nextId++;
        user = who;
        equipment = what;
        RantalDate = DateTime.Now;
        
    }
    
    
}