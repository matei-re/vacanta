using System;
using System.Collections.Generic;

namespace Grades
{
    class GradeBook
    {
        List<float> grades;

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
