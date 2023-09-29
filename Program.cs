using System;
using System.Runtime.ConstrainedExecution;
using System.Text;

class Homework
{
    static void Main(string[] args)
    {


        Console.WriteLine("Write amount of numbers to calculate ");
        int numbers = int.Parse(Console.ReadLine());

        int[] fibonachi = new int[numbers];


        fibonachi[0] = 0;
        fibonachi[1] = 1;

        for (int i = 2; i < numbers; i++)
        {
            int nextFibonachi = fibonachi[i - 1] + fibonachi[i - 2];

            fibonachi[i] = nextFibonachi;


        }
        var stringBiulder = new StringBuilder();
        foreach (var fibonachiNumber in fibonachi)
        {
            stringBiulder.Append(fibonachiNumber);
            stringBiulder.Append(", ");
        }
        Console.WriteLine($"result: {stringBiulder.ToString()}");
        Console.WriteLine( "hi");
    }
}

