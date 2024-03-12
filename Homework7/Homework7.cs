using System;
using System.Data.Common;
using System.Dynamic;
using System.Net.Mail;
using System.Reflection.Metadata.Ecma335;

public class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer(110, "Alice", 28);
        Customer customer2 = new Customer(111, "Bob", 30);

        customer1.PrintCusInfo();
        customer2.PrintCusInfo();

        customer1.ChangeID(210);
        customer2.ChangeID(211);

        customer1.PrintCusInfo();
        customer2.PrintCusInfo();

        customer1.CompareAge(customer2);
    }
    class Customer
    {
    private int cus_id;
    public string cus_name;
    public int cus_age;

    public Customer(int cus_id, string cus_name, int cus_age)
    {
        this.cus_id = cus_id;
        this.cus_name = cus_name;
        this.cus_age = cus_age;
//      I used ChatGPT to help me. I still didn't quite understand how constructors worked
//      so I plugged in the constructor framework you provided for us. From what I understand
//      the (this.) preface is the constructor using this instance of itself to apply the value 
//      or string to the parameter. Basically, it is used to state (thing = thing) instead of having
//      to change the name to something else (thing = new_thing). I hope I understand that correctly! 
    }

    public void ChangeID(int new_id)
    {
        cus_id = new_id;
    }

    public void PrintCusInfo()
    {
        Console.WriteLine($"ID: {cus_id}, Name: {cus_name}, Age: {cus_age}");
    }

    public void CompareAge(Customer objCustomer)
    {
        if(this.cus_age > objCustomer.cus_age)
        {
            Console.WriteLine($"{this.cus_name} is older than {objCustomer.cus_name}");
        }
        else if (objCustomer.cus_age > this.cus_age)
        {
            Console.WriteLine($"{objCustomer.cus_name} is older than {this.cus_name}");
        }
        else
        {
            Console.WriteLine($"{this.cus_name} and {objCustomer.cus_name} are the same age.");
        }
    }
    }
}