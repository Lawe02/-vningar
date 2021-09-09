using System;

namespace sort2
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Skriv in hur många tal du vill jämföra");
			int tal = System.Convert.ToInt32(Console.ReadLine());

			int[] sif = new int[tal];
			int temp;
			bool needsSorting = true;
			//Gör en loop för varje tal som skall sorteras, avbryt om talen är sorterade
			for (int i = 0; i < sif.Length - 1 && needsSorting; i++)
			{
				//Signalera att vi börjar om en ny vända med sortering
				needsSorting = false;
				//Gå igenom alla tal fram till och med de tal som ev. 
				//redan är sorterade (variabeln i)
				for (int j = 0; j < sif.Length - 1 - i; j++)
				{
					//Flytta större tal fram i vektorn
					if (sif[j] > sif[j + 1])
					{
						//Signalera att vi kommer att behöva fortsätta sortera
						needsSorting = true;
						//Byt plats på tal
						int tmp = sif[j + 1];
						sif[j + 1] = sif[j];
						sif[j] = tmp;
					}
				}
				//Har vi nu inte behövt sortera några tal så är 
				//needsSorting == false och loop'en kommer att avbrytas
			}
			Console.WriteLine("Sorted:");
			foreach (int p in sif)
				Console.Write(p + " ");
			Console.Read();

		}
    }
}
