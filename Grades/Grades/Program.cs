using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new GradeBook();
            book.Name = "Hello Mara";
            book.AddGrade(40);
            book.AddGrade(80.1f);
            book.AddGrade(76);
            SpeechSynthesizer spune = new SpeechSynthesizer();
            spune.Speak("Hello Mara! I love you!");
            GradeStatistic stats = book.ComputeStatistic();
            Console.WriteLine(book.Name);
            Console.WriteLine("media "+stats.AverageGrade);
            Console.WriteLine(stats.HighGrade);
            Console.WriteLine(stats.LowGrade);
            Console.ReadKey();


            
        }
    }
}
