using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeStatistic
    {
        public float AverageGrade;
        public float HighGrade;
        public float LowGrade;
        public GradeStatistic()
        {
            HighGrade = 0;
            LowGrade = 100;
        }
    }
}
