using System;

namespace survey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your name?");
            var name = Console.ReadLine();

            Console.WriteLine("what is your age?");
            var age = Console.ReadLine();

            Console.WriteLine("what month you born in?");
            var month = Console.ReadLine();

            Console.WriteLine("your name is : {0}", name);
            Console.WriteLine("your age is : {0}", age);
            Console.WriteLine("your birth month is : {0}", month);


            if (month == "november")

            {
                Console.WriteLine("you are Leo.");

            }

        }
    }
}
