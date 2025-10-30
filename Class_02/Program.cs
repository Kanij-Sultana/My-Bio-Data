using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_02
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //variables
            string Name = "kanij";
         

            string city = "Dhaka";
            string favouritFood = "Alu vorta";
            int birthYear = 1998;
            int currentYear = 2025;
            int age = currentYear - birthYear;

            Console.WriteLine("And my age current is" +   );
            Console.WriteLine("My Name is" + Name);
            Console.WriteLine("i live in : +city");
            Console.WriteLine("my favourite food is :" + favouritFood);
            Console.WriteLine("My Age is:");

            Console.ReadKey();
            
        }
    }
}
