using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sd = { 2, 1, 3, 4};
            int[] ds = { 9, 10 };

            void sdU(int[] dsa) => Array.Sort(dsa);
            void sdL(int[] dsa) { sdU(dsa); Array.Reverse(dsa); };
            int[] sdC(int[] dsa, int[] dsa2) => dsa.Concat(dsa2).ToArray();
            double n(double dsa) => dsa < 123 ? Math.Abs(dsa-123): 3 * Math.Abs(dsa-123);

            Console.WriteLine($"Разность {n(Convert.ToDouble(Console.ReadLine()))}\n");
            
            sdU(sd);
            foreach (int i in sd) 
                Console.WriteLine(i);

            Console.WriteLine("\n");

            sdL(sd);
            foreach(int i in sd)
                Console.WriteLine(i);

            Console.WriteLine("\n");

            foreach (int i in sdC(sd, ds))
                Console.WriteLine(i);
        }
    }
}
