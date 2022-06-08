using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER YOUR AGE: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 4 && age < 18)
            {
                Console.WriteLine("yoo can ride a bike");

            }
            else if (age >= 30 && age < 80)
            {
                Console.WriteLine("you can drive a lorry");

            }
            else
            {
                Console.WriteLine("just enjoy your life");

            } 
        }
    }
}
