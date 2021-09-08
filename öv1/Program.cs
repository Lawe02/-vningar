using System;

namespace öv1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string enter = Console.ReadLine();

            string[] subs = enter.Split(' ');




            Console.WriteLine(subs.Length);



            foreach (var sub in subs)
            {
                Console.WriteLine(sub + " " + (sub.Length));

            }






        }
    }
}
