namespace apbd_tut3.Users;

public abstract class User
{
    private static int nextId = 1;
    
    public int Id {get; set;}
    public string Name {get; set;}
    public string LastName {get; set;}

    public User(string name, string lastName)
    {
        Id = nextId++;
        Name = name;
        LastName = lastName;
    }
}