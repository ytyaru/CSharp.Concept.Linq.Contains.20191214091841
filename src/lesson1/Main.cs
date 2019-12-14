using System;
using System.Collections.Generic;
using System.Linq;

namespace Concept.Linq.Lesson1 {
    class DynamicPredicates : Student
    {
        public void Main(string[] args=null)
        {
            string[] ids = { "111", "114", "112" };
            QueryByYear("1");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        private void QueryByYear(string level)
        {
            GradeLevel year = (GradeLevel)Convert.ToInt32(level);
            IEnumerable<Student> studentQuery = null;
            switch (year)
            {
                case GradeLevel.FirstYear:
                    studentQuery = from student in students
                                   where student.Year == GradeLevel.FirstYear
                                   select student;
                    break;
                case GradeLevel.SecondYear:
                    studentQuery = from student in students
                                   where student.Year == GradeLevel.SecondYear
                                   select student;
                    break;
                case GradeLevel.ThirdYear:
                    studentQuery = from student in students
                                   where student.Year == GradeLevel.ThirdYear
                                   select student;
                    break;
                case GradeLevel.FourthYear:
                    studentQuery = from student in students
                                   where student.Year == GradeLevel.FourthYear
                                   select student;
                    break;

                default:
                    break;
            }
            Console.WriteLine($"The following students are at level {year}");
            foreach (Student name in studentQuery)
            {
                Console.WriteLine($"{name.LastName}: {name.Id}");
            }
        }
    }
    class Main
    {
        public void Run()
        {
            new DynamicPredicates().Main();
        }
    }
}
