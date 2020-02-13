using System.ComponentModel.DataAnnotations;

namespace University.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        [Display(Name = "Регистрация")]
        public int EnrollmentID { get; set; }

        [Display(Name = "Курс")]
        public int CourseID { get; set; }

        [Display(Name = "Студент")]
        public int StudentID { get; set; }

        [Display(Name = "Класс")]
        [DisplayFormat(NullDisplayText = "Нет класса")]
        public Grade? Grade { get; set; }


        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
