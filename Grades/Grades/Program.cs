using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new GradeBook();
            book.AddGrade(40);
            book.AddGrade(80.1f);
            book.AddGrade(76);

            GradeStatistic stats = book.ComputeStatistic();
            Console.WriteLine("media "+stats.AverageGrade);
            Console.WriteLine(stats.HighGrade);
            Console.WriteLine(stats.LowGrade);
            Console.ReadKey();


            
        }
    }
}
