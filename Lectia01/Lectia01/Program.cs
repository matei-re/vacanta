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
            string Hour = Console.ReadLine();
            int hour = int.Parse(Hour);
            if(hour>8)
                Console.WriteLine("Te-ai odihnit");
            else
                Console.WriteLine("Mai dormi");




            /*
            if (args[0] == "Mara")
                Console.WriteLine("Crocodil si Barza si Strut si Iguana");
            else
                Console.WriteLine("Crocodil si Barza");*/
        }
    }
}
