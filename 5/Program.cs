using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace task_567
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine(), str2 = Console.ReadLine();

            Console.WriteLine($"Compare: {String.Compare(str, str2)}\n" +
                $"Equals: {str.Equals(str2)}\n" +
                $"CompareOrdinal: {String.CompareOrdinal(str, str2)}\n" +
                $"IndexOf(\"a\"): {str.IndexOf("a")}\n" +
                $"Contains({str2}): {str.Contains(str2)}\n");

            if (str == str2) Console.WriteLine("Похожи");
            else Console.WriteLine("Не похожи");

        }
    }
}
