using System;

namespace Array_Sort_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] z = { 78, 55, 45, 98, 13 };
            int Zwischenspeicher;
            for (int j = 0; j <= z.Length - 2; j++)
            {
                for (int i = 0; i <= z.Length - 2; i++)
                {
                    if (z[i] > z[i + 1])
                    {
                        Zwischenspeicher = z[i + 1];
                        z[i + 1] = z[i];
                        z[i] = Zwischenspeicher;
                    }
                }
            }
            Console.WriteLine("Sortiert: ");
            foreach (int i in z)
                Console.Write(i);
            Console.Read();
        }
    }
}
