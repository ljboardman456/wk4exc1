using System;

class Program
{
    static void Main()
    {
        //prompt user for the size of the array
        Console.Write("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());

        //create an array of integers with size n
        int[] array = new int[n];

        //prompt user to input values for the array
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Element {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        //print all elements of the array
        Console.WriteLine("\nArray elements:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();  //new line

        //calculate and print the sum of all elements
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += array[i];
        }
        Console.WriteLine($"Sum of elements: {sum}");

        Console.ReadLine(); //wait for user input

        //find and print the maximum and minimum values
        int max = array[0];
        int min = array[0];
        for (int i = 1; i < n; i++)
        {
            if (array[i] > max)
                max = array[i];
            if (array[i] < min)
                min = array[i];
        }
        Console.WriteLine($"Maximum value: {max}");
        Console.WriteLine($"Minimum value: {min}");

        //reverse the array and print the reversed array
        Console.WriteLine("Reversed array:");
        for (int i = n - 1; i >= 0; i--)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();  //new line

        Console.ReadLine(); //wait for user input
    }
}
