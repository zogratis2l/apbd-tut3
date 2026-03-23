namespace apbd_tut3.Users;

public class Employee : User 
{


    public Employee(string name, string lastName) : base(name, lastName)
    {
        RentalRemains = 5;
    }
}