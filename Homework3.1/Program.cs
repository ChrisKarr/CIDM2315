using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input a number:");
        int num = Convert.ToInt32(Console.ReadLine());

        if(num <= 1)
        {
            Console.WriteLine("Not a Prime Number");
        }
        else
        {
            int factor;
            for(factor = 2; factor < num; factor++)
            {
                if(num % factor == 0)
                {
                    Console.WriteLine("Not a Prime Number");
                    break;
                }
            }

            if(factor == num)
            {
                Console.WriteLine("This is a Prime Number");
            }
        }
    }
        
}
// This was my original code. I could not get it to work no matter how much
// I looked back through the book and SoloLearn. I pasted this into ChatGPT 4.0 and
// asked it "I need to input a number and have the program output whether or not the number is prime"
// and this is the corrected code the AI gave me. I wanted to cite this so that I do not get in trouble. 
// I know the class syllabus says we are allowed to use AI for assistance as long as we cite it.
// If I did not cite this correctly, or plagiarized somehow please let me know so I can avoid it in the future!

// using System;
// public class Program
// {
//     static void Main(string[] args)
//     {
        // Console.WriteLine("Please input a number:");

        // int num = Convert.ToInt32(Console.ReadLine());

        // int counter = 0;

        // for(int factor = 1; factor<= num; factor++){
        //     if(num%factor==0){
        //         counter++;
        //     }
        // }

        // // check if counter ==2
        // if(counter==2){
        //     Console.WriteLine("N is a Prime");
        // }
        // else{
        //     Console.WriteLine("N is not a Prime");
        // }


        // Console.WriteLine("Please input a number");

        // int number = Convert.ToInt32(Console.ReadLine());

        // for(int row = 0; row < number; row++)
        // {
        //     for(int col = 0; col < number; col++)
        //     {
        //         Console.Write("#");
        //     }
        //     Console.WriteLine("");
        // }