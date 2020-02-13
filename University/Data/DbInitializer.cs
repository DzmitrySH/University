using System;
using System.Linq;
using University.Models;

namespace University.Data
{
    public static class DbInitializer
    {
        public static void Initialize(UniversityContext context)
        {
            context.Database.EnsureCreated();

            if (context.Students.Any())
            {
                return;
            }

            var students = new Student[]
            {
            new Student{LastName="Сергей",FirstMidName="Александров",EnrollmentDate=DateTime.Parse("05-09-2015")},
            new Student{LastName="Виктор",FirstMidName="Еловой",EnrollmentDate=DateTime.Parse("01-10-2014")},
            new Student{LastName="Артем",FirstMidName="Петров",EnrollmentDate=DateTime.Parse("08-05-2015")},
            new Student{LastName="Андрей",FirstMidName="Голубев",EnrollmentDate=DateTime.Parse("07-04-2017")},
            new Student{LastName="Светлана",FirstMidName="Максимова",EnrollmentDate=DateTime.Parse("05-09-2015")},
            new Student{LastName="Максим",FirstMidName="Федоров",EnrollmentDate=DateTime.Parse("01-10-2014")},
            new Student{LastName="Артур",FirstMidName="Панов",EnrollmentDate=DateTime.Parse("08-05-2015")},
            new Student{LastName="Андрей",FirstMidName="Змеев",EnrollmentDate=DateTime.Parse("07-04-2017")},
            new Student{LastName="Ян",FirstMidName="Левин",EnrollmentDate=DateTime.Parse("05-09-2017")},
            new Student{LastName="Иван",FirstMidName="Абрамов",EnrollmentDate=DateTime.Parse("01-09-2017")},
            new Student{LastName="Елена",FirstMidName="Никонова",EnrollmentDate=DateTime.Parse("06-12-2014")},
            new Student{LastName="Нино",FirstMidName="Кавхадзе",EnrollmentDate=DateTime.Parse("14-07-2015")}
            };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            if (context.Courses.Any())
            {
                return;
            }

            var courses = new Course[]
            {
            new Course{Title="Химия",Credits=3},
            new Course{Title="Микроэкономика",Credits=3},
            new Course{Title="Макроэкономика",Credits=3},
            new Course{Title="Физика",Credits=4},
            new Course{Title="Тригонометрия",Credits=4},
            new Course{Title="Исскуство",Credits=3},
            new Course{Title="Литература",Credits=4}
            };
            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            if (context.Enrollments.Any())
            {
                return;
            }

            var enrollments = new Enrollment[]
            {
            new Enrollment{StudentID=1,CourseID=1,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=2,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=3,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=4,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=5,Grade=Grade.F},
            new Enrollment{StudentID=2,CourseID=6,Grade=Grade.F},
            new Enrollment{StudentID=3,CourseID=6},
            new Enrollment{StudentID=3,CourseID=7,Grade=Grade.A},
            new Enrollment{StudentID=4,CourseID=7},
            new Enrollment{StudentID=4,CourseID=6,Grade=Grade.F},
            new Enrollment{StudentID=5,CourseID=2,Grade=Grade.C},
            new Enrollment{StudentID=6,CourseID=4},
            new Enrollment{StudentID=7,CourseID=1,Grade=Grade.A},
            new Enrollment{StudentID=8,CourseID=1,Grade=Grade.A},
            new Enrollment{StudentID=8,CourseID=2,Grade=Grade.C},
            new Enrollment{StudentID=9,CourseID=3,Grade=Grade.B},
            new Enrollment{StudentID=10,CourseID=4,Grade=Grade.B},
            new Enrollment{StudentID=10,CourseID=5,Grade=Grade.F},
            new Enrollment{StudentID=11,CourseID=6},
            new Enrollment{StudentID=11,CourseID=7},
            new Enrollment{StudentID=12,CourseID=6,Grade=Grade.F},
            new Enrollment{StudentID=12,CourseID=3,Grade=Grade.C}
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}
