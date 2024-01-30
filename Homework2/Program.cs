using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input Grade Letter: ");
        
        string inputA = "4";
        string inputB = "3";
        string inputC = "2";
        string inputD = "1";
        string inputF = "0";

        string outputA = "A";
        string outputB = "B";
        string outputC = "C";
        string outputD = "D";
        string outputF = "F";

        int numberA = Convert.ToInt16(inputA);
        int numberB = Convert.ToInt16(inputB);
        int numberC = Convert.ToInt16(inputC);
        int numberD = Convert.ToInt16(inputD);
        int numberF = Convert.ToInt16(inputF);

        string input = Console.ReadLine();

        if (input == outputA)
        {
            Console.WriteLine($"Your GPA is: {inputA}");
        }
        else if (input == outputB)
        {
            Console.WriteLine($"Your GPA is: {inputB}");
        }
        else if (input == outputC)
        {
            Console.WriteLine($"Your GPA is: {inputC}");
        }
        else if (input == outputD)
        {
            Console.WriteLine($"Your GPA is: {inputD}");
        }
        else if (input == outputF)
        {
            Console.WriteLine($"Your GPA is: {inputF}");
        }
        else
        {
            Console.WriteLine("That letter grade is incorrect! \nPlease use a correct input.");
        } 

    }
}
   