using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Please input the first number: ");
        string input1 = Console.ReadLine(); 

        Console.WriteLine("Please input the second number: ");
        string input2 = Console.ReadLine();

        Console.WriteLine("Please input the third number: ");
        string input3 = Console.ReadLine();

        int number1 = int.Parse(input1);
        int number2 = int.Parse(input2);
        int number3 = int.Parse(input3);

        if (number1 < number2 && number1 < number3)
        {
            Console.WriteLine($"The lowest number is: {input1}");
        }
        else if (number2 < number1 && number2 < number3)
        {
            Console.WriteLine($"The lowest number is: {input2}");
        }
        else if (number3 < number1 && number3 < number2)
        {
            Console.WriteLine($"The lowest number is: {input3}");
        }
        else if (number1 == number2 && number1 == number3 && number2 == number3)
        {
            Console.WriteLine("Sorry, all of the values input are the same");
        }

    }
}