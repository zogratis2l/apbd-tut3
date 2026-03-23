using apbd_tut3.Users;

namespace apbd_tut3;

public class Program
{
    public static void Main()
    {
        RentalService service = new RentalService();
        
        service.AddEquipment(new Laptop("Dell", true, "Dell", "XPS", "RTX", "i7"));
        service.AddEquipment(new Projector("Epson", true, "Epson", "X1", 3000, "1080p"));
        service.AddEquipment(new Camera("Canon", true, "Canon", "C100", 24, "Wide"));
        
        service.AddUser(new Student("Alice", "Smith"));
        service.AddUser(new Employee("Bob", "Brown"));
        
        service.RentEquipment(1, 1, 2);  //correct rental
        
        service.RentEquipment(2, 1, 2);  //incorrect rental
        
        service.ReturnEquipment(1);   //return on time
        
        // late return
        service.RentEquipment(1, 2, 1);
        var rentalToLate = service.GetUserRentalsForTest(1).Find(r => r.equipment.Id == 2);
        rentalToLate.RentalTime = DateTime.Now.AddDays(-2);
        service.ReturnEquipment(2);
        
        service.Summary(); //summary
        
        
    }
}