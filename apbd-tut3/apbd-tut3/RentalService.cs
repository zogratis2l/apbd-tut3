using apbd_tut3.Users;

namespace apbd_tut3;

public class RentalService
{
    private List<User> users = new List<User>();
    private List<Equipment> equipments = new List<Equipment>();
    private List<Rental> rentals = new List<Rental>();

    private const decimal LateFeePerDay = 15;


    public void AddUser(User user)
    {
        users.Add(user);
    }

    public void AddEquipment(Equipment equipment)
    {
        equipments.Add(equipment);
    }

    public void ShowAllEquipments()
    {
        foreach (Equipment e in equipments)
        {
            Console.WriteLine(e.Id +  ", " + e.Name +  ", " + (e.IsAvailable? "Available" : "Not Available"));
        }
    }

    public void ShowAvailableEquipments()
    {
        foreach (Equipment e in equipments)
        {
            if (e.IsAvailable)
            {
                Console.WriteLine(e.Id + ", " + e.Name);
            }
        }
    }


    public void RentEquipment(int userId, int equipmentId, int days)
    {
        User user = users.Find(u => u.Id == userId);
        Equipment equipment = equipments.Find(e => e.Id == equipmentId);

        if (user == null || equipment == null)
        {
            Console.WriteLine("No user or equipment found");
        }

        if (!equipment.IsAvailable)
        {
            Console.WriteLine("Not available");
        }

        if (user.RentalRemains <= 0)
        {
            Console.WriteLine("User reached the limit of rentals");
        }
        
        rentals.Add(new Rental(user, equipment, days));
        equipment.IsAvailable = false;
        user.RentalRemains--;

        Console.WriteLine("Rental created");

    }

    public void ReturnEquipment(int equipmentId)
    {
        Rental rental = rentals.Find(r => r.equipment.Id == equipmentId && r.ReturnDate != null);

        if (rental == null)
        {
            Console.WriteLine("No rental found");
        }
        
        rental.ReturnDate = DateTime.Now;
        rental.equipment.IsAvailable = true;
        rental.user.RentalRemains++;

        if (rental.ReturnDate > rental.RentalTime)
        {
            int dayLate = (rental.ReturnDate.Value - rental.RentalTime).Days;
            rental.Penalty = dayLate * LateFeePerDay;
            Console.WriteLine("Late" + "Your penalty is " + rental.Penalty);
        }
        else
        {
            Console.WriteLine("Returned " + rental.ReturnDate.Value.ToString("dd/MM/yyyy"));
        }

    }

    public void MarkEquipmentUnavailable(int equipmentId)
    {
        Equipment equipment = equipments.Find(e => e.Id == equipmentId);

        if (equipment == null)
        {
            Console.WriteLine("No equipment found");
        }
        
        equipment.IsAvailable = false;
        
        Console.WriteLine("Marked equipment unavailable");
        
    }

    public void ShowUserRentals(int userId)
    {
        foreach (Rental r in rentals)
        {
            if (r.user.Id == userId && r.ReturnDate == null)
            {
                Console.WriteLine(r.equipment.Name + "due " + r.RentalTime);
            }
        }
    }

    public void ShowOverdue()
    {
        foreach (Rental r in rentals)
        {
            if (r.isOverdue())
            {
                Console.WriteLine(r.user.Name + "overdue " + r.equipment.Name + "due " + r.RentalTime);
            }
        }
    }

    public void Summary()
    {
        Console.WriteLine("Users: " +  users.Count);
        Console.WriteLine("Equipments: " +  equipments.Count);
        Console.WriteLine("Rentals: " +  rentals.Count);
        Console.WriteLine("Active rentals: " +  rentals.Count(r => r.ReturnDate == null));
    }
    
    
}