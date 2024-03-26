using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] int_array = {11,23,31,42,53};
        ArraySum(int_array);

        int[,] array_2d =
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        PrintAllOddNumber(array_2d);
        Console.WriteLine($"Sum of 2d array: {ElementSum(array_2d)}");
        int[,] Q2_3 = DoubleArray(array_2d);
        Console.WriteLine("The new 2d array:");
        foreach(int num in Q2_3)
        {
            Console.Write(num +" ");
        }
    }
    private static void ArraySum(int[] int_array)
    {
        int sum = 0;
    foreach (int num in int_array) 
    {
        sum += num;
    }
    Console.WriteLine($"Sum of array: {sum}");
    }

    private static void PrintAllOddNumber(int[,] array_2d)
    {
        Console.WriteLine("Odd numbers:");
    for (int x = 0; x < array_2d.GetLength(0); x++) 
    {
        for (int y = 0; y < array_2d.GetLength(1); y++) 
        {
            if (array_2d[x, y] % 2 != 0) 
            {
                Console.Write(array_2d[x, y] + " ");
            }
        }
    }
    Console.WriteLine();
    }

    private static int ElementSum(int[,] array_2d)
    {
        int sum = 0;
    for (int x = 0; x < array_2d.GetLength(0); x++) 
    {
        for (int y = 0; y < array_2d.GetLength(1); y++) 
        {
            sum += array_2d[x, y];
        }
    }
    return sum;
    }

    private static int[,] DoubleArray(int[,] array_2d)
    {
        int[,] doubledArray = new int[array_2d.GetLength(0), array_2d.GetLength(1)];
    for (int x = 0; x < array_2d.GetLength(0); x++) 
    {
        for (int y = 0; y < array_2d.GetLength(1); y++) 
        {
            doubledArray[x, y] = array_2d[x, y] * 2;
        }
    }
    return doubledArray;
    }
}
