using System;
using System.Collections.Generic;

namespace Grades
{
    public class GradeBook
    {
        public NameChangeDelegat NameDelegate ;
        private string _name;
        List<float> grades;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    if(_name!=value)
                    {
                        NameDelegate(_name, value);
                    }
                    _name = value;
            }
        }
        public GradeBook()
        {
            grades = new List<float>();
        }

        public GradeStatistic ComputeStatistic()
        {
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
    }
}
