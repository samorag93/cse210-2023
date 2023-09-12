using System;

class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        List<int> numbers = new List<int>();
        Console.Write("Enter a list of numbers, type 0 when finished.");
        int usernumber = -1;
        while(usernumber != 0)
        {
            
            usernumber = int.Parse(Console.ReadLine());
            
            if(usernumber!=0)
            {
                numbers.Add(usernumber);
            }
            sum += usernumber;
        }
        Console.WriteLine($"The sum is: {sum}");
        float promedio = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {promedio}");

        int largest = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }

        Console.WriteLine($"The max is: {largest}");
    }
}