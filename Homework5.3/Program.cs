using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a username:");
        string username = Console.ReadLine();

        Console.WriteLine("Enter a password:");
        string password = Console.ReadLine();

        Console.WriteLine("Please confirm password:");
        string password2 = Console.ReadLine();

        Console.WriteLine("Enter your birth year:");
        bool agecheck = false;
        while(!agecheck)
        {
            int birthyear = Convert.ToInt32(Console.ReadLine());
            agecheck = AgeVerification(birthyear);

            if(!agecheck)
            {
                Console.WriteLine("You cannot create account. Must be 18 or older.");
            }
        }

        AccountCreation(password, password2);
        if(password == password2 && agecheck)
        {
            Console.WriteLine($"Username: {username}\nPassword: {password}\nThank you for creating an account!");
        }
    }

    static bool AgeVerification(int birthyear)
    {
        int currentyear = 2024;
        int age = currentyear - birthyear;
        return age >= 18;
        
    }

    static void AccountCreation(string pass1, string pass2)
    {
        if(pass1 != pass2)
        {
          Console.WriteLine("Wrong password.");  
        }
        else
        {
            Console.WriteLine("Account created successfully!");
        }

    }
}