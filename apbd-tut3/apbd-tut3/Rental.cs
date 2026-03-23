using System.Runtime.InteropServices.JavaScript;
using apbd_tut3.Users;

namespace apbd_tut3;

public class Rental
{
    private static int nextId = 1;
    
    public User user { get; set; }
    
    public Equipment equipment { get; set; }
    
    public int Id { get; set; }
    
    public DateTime RentalDate { get; set; }
    
    public DateTime RentalTime { get; set; }
    
    public DateTime? ReturnDate { get; set; }
    
    public decimal Penalty { get; set; }


    public Rental(User who, Equipment what, int days)
    {
        Id = nextId++;
        user = who;
        equipment = what;
        RentalDate = DateTime.Now;
        RentalTime = RentalDate.AddDays(days);

    }

    public bool isOverdue()
    {
        return ReturnDate >  RentalTime;
    }
    
}