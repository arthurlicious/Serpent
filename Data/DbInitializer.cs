using SerpantWebApp.Models;
using System.Linq;

namespace SerpantWebApp.Data
{
    public class DbInitializer
    {
        public static void Initialize(SerpantWebAppContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Attendance.Any())
            {
                return;   // DB has been seeded
            }

           /* var students = new Student[]
            {
                new Student{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2019-09-01")},
                new Student{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2018-09-01")},
                new Student{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2016-09-01")},
                new Student{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2018-09-01")},
                new Student{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2019-09-01")}
            };

            
            context.Students.AddRange(students);
            context.SaveChanges();

            */
           /* var courses = new Course[]
            {
                new Course{CourseID=1050,Title="Chemistry",Credits=3},
                new Course{CourseID=4022,Title="Microeconomics",Credits=3},
                new Course{CourseID=4041,Title="Macroeconomics",Credits=3},
                new Course{CourseID=1045,Title="Calculus",Credits=4},
                new Course{CourseID=3141,Title="Trigonometry",Credits=4},
                new Course{CourseID=2021,Title="Composition",Credits=3},
                new Course{CourseID=2042,Title="Literature",Credits=4}
            };

            context.Courses.AddRange(courses);
            context.SaveChanges();

            var attendance = new Attendance[]
            {
                new Attendance{CourseID=4022,StudentID=10573435, Presence=false},
                new Attendance{CourseID=4022,StudentID=10545335, Presence=false},
                new Attendance{CourseID=4022,StudentID=10325435, Presence=false},
                new Attendance{CourseID=4022,StudentID=10554335, Presence=false},
                new Attendance{CourseID=4021,StudentID=10232235, Presence=false},
                new Attendance{CourseID=4021,StudentID=10754535, Presence=false},
                new Attendance{CourseID=4021,StudentID=10354435, Presence=false},
                new Attendance{CourseID=4021,StudentID=10554635, Presence=false},
            };

            context.Attendance.AddRange(attendance);
            context.SaveChanges();*/
        }

    }
}
