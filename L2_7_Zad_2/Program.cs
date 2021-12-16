using System;

namespace L2_7_Zad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This app will check that entered number is even or odd.");
            Console.Write("Enter an integer number: ");
            Int32.TryParse(Console.ReadLine(), out int numberInt);
            if(numberInt % 2 == 0)
            {
                Console.WriteLine($"Entered number {numberInt} is even.");
            }
            else
            {
                Console.WriteLine($"Entered number {numberInt} is odd.");
            }
        }
    }
}
