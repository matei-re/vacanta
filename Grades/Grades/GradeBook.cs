using System;
using System.Collections.Generic;
using System.IO;

namespace Grades
{
    public class GradeBook
    {
       // public NameChangeDelegat NameDelegate ;
        private string _name;
        protected List<float> grades;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Trebuiesa introduceti un nume");
                 /*   if(_name!=value)
                    {
                        NameDelegate(_name, value);
                    }*/
                    _name = value;
            }
        }
        public GradeBook()
        {
            grades = new List<float>();
        }

        public GradeStatistic ComputeStatistic()
        {
            Console.WriteLine("GradeBook Compute");
            GradeStatistic stats = new GradeStatistic();
            float sum = 0;

            foreach (float grade in grades)
            {
                sum += grade;
                stats.HighGrade = Math.Max(stats.HighGrade, grade);
                stats.LowGrade = Math.Min(stats.LowGrade, grade);
            }
            stats.AverageGrade = sum / grades.Count;

            return stats;
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public void WriteGrades(TextWriter destination)
        {
            for(int i=0;i<grades.Count;i++)
            {
                destination.WriteLine(grades[i]);
            }
        }
    }
}
