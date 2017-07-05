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
            book.AddGrade(100);
            //   SpeechSynthesizer spune = new SpeechSynthesizer();
            //  spune.Speak("Hello Mara! I love you!");
            GradeStatistic stats = book.ComputeStatistic();
            Console.WriteLine(book.Name);
            book.WriteGrades(Console.Out);
            // Console.WriteLine("media "+stats.AverageGrade);
            // Console.WriteLine(stats.HighGrade);
            // Console.WriteLine(stats.LowGrade);
            WriteResult("Äverage", stats.AverageGrade);
            WriteResult("High Score", stats.HighGrade);
            WriteResult("Low Score", stats.LowGrade);
            WriteResult(stats.Description, stats.LetterGrade);

            Console.ReadKey();


            
        }
        static void WriteResult(string descriere, string rezultat)
        {
            Console.WriteLine($"{descriere}:{rezultat}", descriere, rezultat);
        }
        static void WriteResult(string descriere, float rezultat)
        {
            Console.WriteLine($"{descriere}:{rezultat:F2}", descriere, rezultat);
        }
    }
}
