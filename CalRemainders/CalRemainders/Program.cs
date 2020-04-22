using System;

namespace CalRemainders
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number:");
            int b = int.Parse(Console.ReadLine());
            int rem = a % b;
            Console.WriteLine("your remainder is:" + rem);
            Console.ReadLine();
        }
    }
}
