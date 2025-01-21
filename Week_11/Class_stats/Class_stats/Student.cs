using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_stats
{
    public class Student
    {
        public string Name { get; set; } = string.Empty;
        public List<string> Grades { get; set; } = new List<string>();

        public double AverageGrade
        {
            get
            {
                var gradeValues = Grades.Select(grade => Program.GradeMapping[grade]);
                return gradeValues.Any() ? gradeValues.Average() : 0;
            }
        }

        public bool Passed => AverageGrade >= 50; // Example passing threshold
    }

}
