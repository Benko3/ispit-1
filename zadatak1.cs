using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main()
        {
           
       
    }
        int x, y, z;

        Console.WriteLine("Unesite vrijednost stranice x:");
            x = int.Parse(Console.ReadLine());

        Console.WriteLine("Unesite vrijednost stranice y:");
            y = int.Parse(Console.ReadLine());

        Console.WriteLine("Unesite vrijednost stranice z:");
            z = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0 && z > 0)
            {
                if (x + y > z && x + z > y && y + z > x)
                {
                    Console.WriteLine("DA.");
                }
                else
                {
                    Console.WriteLine("NE.");
                }
            }
            else
{
    Console.WriteLine("Unesene vrijednosti moraju biti veće od 0.");
}
