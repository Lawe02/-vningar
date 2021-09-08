using System;

namespace öv2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string s = Console.ReadLine();

            string[] subs = s.Split(' ');
            Array.Sort(subs, (s1, s2) => s1.Length.CompareTo(s2.Length));
            foreach (var sub in subs)
            {
                Console.WriteLine(sub);
            }
            Array.Sort(subs, (s2, s1) => s1.Length.CompareTo(s2.Length));
            foreach (var sub in subs)
            {
                Console.WriteLine(sub);
            }



        }
    }
}
