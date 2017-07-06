using System;
using System.Collections.Generic;
using System.IO;
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
            var book = new ThrowAwayGradeBook();
            GetBookName(book);
            AddGrades(book);
            //   SpeechSynthesizer spune = new SpeechSynthesizer();
            //  spune.Speak("Hello Mara! I love you!");
            SaveGrades(book);
            WriteGrades(book);

            Console.ReadKey();



        }

        private static void WriteGrades(GradeBook book)
        {
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
        }

        private static void SaveGrades(GradeBook book)
        {
            StreamWriter outputFile = File.CreateText("Grades");
            book.WriteGrades(outputFile);
            outputFile.Close();
        }

        private static void AddGrades(GradeBook book)
        {
            book.AddGrade(40);
            book.AddGrade(80.1f);
            book.AddGrade(76);
            book.AddGrade(100);
        }

        private static void GetBookName(GradeBook book)
        {
            try
            {
                Console.WriteLine("Ïntrodu un nume");
                book.Name = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);

            }
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
