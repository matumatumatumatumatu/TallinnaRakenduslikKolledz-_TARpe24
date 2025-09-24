using System.ComponentModel.DataAnnotations;

namespace TallinnaRakenduslikKolledž.Models
{
    public class Department
    {
        [Key]
        public int DepartmentID {  get; set; }
        public string Name { get; set; }
        public decimal Budget {  get; set; }
        public DateTime StartDate { get; set; }
        public int? InstructorIDˇ {  get; set; }
        public Instructor? Administrator { get; set; }
        public ICollection<Course>? Courses { get; set; }
        public byte? RowVersion { get; set; }

        /* 3 isiklikku unikaalset andmevälja kursusele juurde */
        public DateTime EndDate { get; set; }
        public int? SocialCreditScore { get; set; }
        public bool SigmaStatus { get; set; }
    }
}
