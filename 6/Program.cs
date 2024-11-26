using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt, td;
            Console.WriteLine($"Parse: {DateTime.Parse(Console.ReadLine())}\n" +
                $"ParseExact: {DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy", null)}\n" +
                $"TryParse: {DateTime.TryParse(Console.ReadLine(), out dt)}\n" +
                $"ParseExact: {DateTime.TryParseExact(Console.ReadLine(), "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out td)}\n");
        }
    }
}
