using System;
using System.Collections.Generic;

namespace Treehouse
{
    class Program
    {
        static void Main()
        {
            HashSet<Student> students = new HashSet<Student>
            {
                new Student() { Name = "Sally", GradeLevel = 3 },
                new Student() { Name = "Bob", GradeLevel = 3 },
                new Student() { Name = "Sally", GradeLevel = 2 }
            };
#region Video 1
/*     
            SchoolRoll schoolRoll = new SchoolRoll();
            schoolRoll.AddStudents(students);
            
            schoolRoll.AddStudents(students);
            //even having this command in twice, HashSet has ignored them. That is our desired outcome.
*/
#endregion

#region Video 2

            Student joe = new Student(){Name = "Joe", GradeLevel = 2};
            students.Add(joe);
            //joe is added 

            Student duplicateJoe = new Student(){Name = "Joe", GradeLevel = 2};
            students.Add(duplicateJoe);
            //joe is added? yes, they are different objects.

            /*
            Console.WriteLine(joe.GetHashCode());
            Console.WriteLine(duplicateJoe.GetHashCode());
            //produces two different hashcodes.
            */

#endregion

#region Video 3



#endregion

            foreach(Student student in students)
            {
                Console.WriteLine(/*$*/"{student.Name} is in grade {student.GradeLevel}");
            }
        }
    }
}