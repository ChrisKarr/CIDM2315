using System;

public class Program
{
    static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());

        for(int row = 0; row<num; row++){
    for(int col = 0; col<num ; col++)
    {
        Console.Write('*');
    }
    Console.WriteLine("");
}
    }
}