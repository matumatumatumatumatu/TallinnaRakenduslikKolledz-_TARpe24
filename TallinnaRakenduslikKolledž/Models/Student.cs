using System.ComponentModel.DataAnnotations;

namespace TallinnaRakenduslikKolledž.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }

        /*lisa kolm omadust õpilasele, ise mõtled välja*/
        public int Course {  get; set; }
        public string Gender {  get; set; }
        public int? Phone {  get; set; }
    }
}
