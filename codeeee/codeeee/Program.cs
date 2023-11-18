using System;

public class Program
{
    public static void Main()
    {
        User user = new User("John", 24, "john.doe@example.com");

        Console.WriteLine("Name: " + user.Name);
        Console.WriteLine("Age: " + user.Age);
        Console.WriteLine("Email: " + user.Email);
    }
}

public class User
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }

    public User(string name, int age, string email)
    {
        Name = name;
        Age = age;
        Email = email;
    }
}