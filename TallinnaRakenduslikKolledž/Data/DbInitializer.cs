using System.Linq.Expressions;
using TallinnaRakenduslikKolledž.Models;

namespace TallinnaRakenduslikKolledž.Data
{
    public class DbInitializer
    {
        public static void Initalizer(SchoolContext context)
        {
            context.Database.EnsureCreated();
            if (context.Students.Any())
            {
                return;
            }

            var students = new Student[]
            {
                new Student
                { FirstName = "George", LastName = "Teemus",       EnrollmentDate = DateTime.Now,
                },
                                new Student
                { FirstName = "Muhammed", LastName = "Explosive",       EnrollmentDate = DateTime.Now,
                },
                                                new Student
                { FirstName = "Amogus", LastName = "Potion",       EnrollmentDate = DateTime.Now,
                },
                                                                new Student
                { FirstName = "Panzerkampfwagen", LastName = "IV",       EnrollmentDate = DateTime.Now,
                },
                                                                                new Student
                { FirstName = "Landkreuzer", LastName = "Ratte",       EnrollmentDate = DateTime.Now,
                },
                                                                                                new Student
                { FirstName = "Smegver", LastName = "Ligma",       EnrollmentDate = DateTime.Now,
                },
                                                                                                                new Student
                { FirstName = "Mustafa", LastName = "Teemus",       EnrollmentDate = DateTime.Now,
                },
                                                                                                                                new Student
                { FirstName = "Ahto", LastName = "Parmesaan",       EnrollmentDate = DateTime.Now,
                }

            };
            context.Students.AddRange(students);
            context.SaveChanges();
            if (context.Courses.Any()) { return; }
            var courses = new Course[]
            {
                new Course {CourseID=1001,  Title="Programmeerimise Alused", Credits=3},
                new Course {CourseID=2002,  Title="Programmeerimise 1", Credits=6},
                new Course {CourseID=3003,  Title="Programmeerimise 2", Credits=9},
                new Course {CourseID=2003,  Title="Tarkvara Arendusprotsess", Credits=3},
                new Course {CourseID=1002,  Title="Multimeedia", Credits=3},
                new Course {CourseID=3001,  Title="Hajusrakenduste Alused", Credits=3}

            };
            context.Courses.AddRange(courses);
            context.SaveChanges();
            if (context.Enrollments.Any()) { return; }
            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentID=1,CourseID=3003,CurrentGrade=Grade.X},
                new Enrollment{StudentID=1,CourseID=3001,CurrentGrade=Grade.B},
                new Enrollment{StudentID=2,CourseID=1001,CurrentGrade=Grade.A},
                new Enrollment{StudentID=2,CourseID=1002,CurrentGrade=Grade.MA},
                new Enrollment{StudentID=3,CourseID=1001,CurrentGrade=Grade.C},
                new Enrollment{StudentID=3,CourseID=2003,CurrentGrade=Grade.C},
                new Enrollment{StudentID=4,CourseID=3003,CurrentGrade=Grade.X},
                new Enrollment{StudentID=4,CourseID=3001,CurrentGrade=Grade.B},
                new Enrollment{StudentID=5,CourseID=1001,CurrentGrade=Grade.A},
                new Enrollment{StudentID=5,CourseID=1002,CurrentGrade=Grade.MA},
                new Enrollment{StudentID=6,CourseID=1001,CurrentGrade=Grade.C},
                new Enrollment{StudentID=6,CourseID=2003,CurrentGrade=Grade.C},
                new Enrollment{StudentID=7,CourseID=1001,CurrentGrade=Grade.C},
                new Enrollment{StudentID=7,CourseID=2003,CurrentGrade=Grade.C},
                new Enrollment{StudentID=8,CourseID=1001,CurrentGrade=Grade.C},
                new Enrollment{StudentID=8,CourseID=2003,CurrentGrade=Grade.C}
            };
            context.Enrollments.AddRange(enrollments);
            context.SaveChanges();
            if (context.Instructors.Any())
            {
                return;
            }
            var instructors = new Instructor[]
            {
                new Instructor{ FirstName="DONKEH", LastName="Dragon", HireDate=DateTime.Now, Age=21},
                new Instructor{ FirstName="Sigma", LastName="Boy", HireDate=DateTime.Now, Age=69},
                new Instructor{ FirstName="Alfa", LastName="Isane", HireDate=DateTime.Now, Age=29},
            };
            context.Instructors.AddRange(instructors);
            context.SaveChanges();
        }
    }
}
