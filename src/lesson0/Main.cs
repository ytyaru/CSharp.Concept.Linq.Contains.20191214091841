using System;
using System.Collections.Generic;
using System.Linq;

namespace Concept.Linq.Lesson0 {
    class DynamicPredicates : Student
    {
        public void Main(string[] args=null)
        {
            string[] ids = { "111", "114", "112" };
            QueryById(ids);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        private void QueryById(string[] ids)
        {
            var queryNames =
                from student in students
                let i = student.Id.ToString()
                where ids.Contains(i)
                select new { student.LastName, student.Id };

            foreach (var name in queryNames)
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
