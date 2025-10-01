using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace TallinnaRakenduslikKolledž.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public Department? Department { get; set; }
        public int? DepartmentID { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
        public ICollection<CourseAssignment> CourseAssignments { get; set; }
    }
}
