using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectia01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cum te cheama ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello" + name);
            Console.WriteLine("Cat ai dormit");
            string hourtringsssss = Console.ReadLine();
            int hour = int.Parse(hourtringsssss);
            if(hour>8)
                Console.WriteLine("Te-ai odihnit");
            else
                Console.WriteLine("Mai dormi");

            Console.ReadKey();


           
        }
    }
}
