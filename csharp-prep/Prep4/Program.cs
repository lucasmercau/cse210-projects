using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = 1;
        List<int> numbers = new List<int>(); 
        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);  
            }
              
            
        } 
        int sum = 0;
        int largest = 0;
        int smallest = 99999999;
        foreach (int num in numbers)
        {
            sum = sum + num;
            if (largest < num)
            {
                largest = num;
            }
            if (num > 0 && smallest > num)
            {
                smallest = num;
            
            }
        }
        Console.WriteLine($"The sum is: {sum}");
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");

        Console.WriteLine("The sorted list is: ");
        numbers.Sort();
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

    }
}