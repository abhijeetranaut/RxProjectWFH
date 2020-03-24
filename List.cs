using System;
using System.Collections.Generic;



    class Program
    {
    static void Main(string[] args)
    {
        List<User> listOfUsers = new List<User>()
        {
        new User() { Name = "Abhijeet", Age = 21 },
        new User() { Name = "Rutvik", Age = 20 },
        new User() { Name = "Mukesh", Age = 63 },
        };
        listOfUsers.Sort(CompareUsers);
        foreach (User user in listOfUsers)
        Console.WriteLine(user.Name + ": " + user.Age + " years old");
    }

    public static int CompareUsers(User user1, User user2)
    {
        return user1.Age.CompareTo(user2.Age);
    }
    }

    public class User
    {
    public string Name { get; set; }
    public int Age { get; set; }
    }
