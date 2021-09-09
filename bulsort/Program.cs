using System;

namespace bulsort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in hur många tal du vill jämföra");
            int tal =  System.Convert.ToInt32(Console.ReadLine());

            int[] sif = new int[tal];
            int temp;
            for(int i =0; i<tal; i++)
            {
                Console.WriteLine("Skriv ett tal");
                 sif[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            for (int j = 0; j <= sif.Length - 2; j++)
            {
                for (int i = 0; i <= sif.Length - 2; i++)
                {
                    if (sif[i] > sif[i + 1])
                    {
                        temp = sif[i + 1];
                        sif[i + 1] = sif[i];
                        sif[i] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted:");
            foreach (int p in sif)
                Console.Write(p + " ");
            Console.Read();
        }









    }


    
    
}
