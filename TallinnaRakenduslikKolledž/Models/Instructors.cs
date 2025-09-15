using System.ComponentModel.DataAnnotations;

namespace TallinnaRakenduslikKolledž.Models
{
    public class Instructor
    {
        [Key]
        public int ID {  get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Perekonnanimi")]
        public string LastName { get; set; }
        /**/
        [Required]
        [StringLength(50)]
        [Display(Name = "Eesnimi")]
        public string FirstName { get; set; }
        /**/
        [Display(Name = "Õpetaja nimi")]
        public string FullName
        {
            get { return LastName + ", " + FirstName; }
        }
        /**/
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "Tööleasumisküüpäev")]
        public DateTime HireDate { get; set; }

        public ICollection<CourseAssignment>? CourseAssignments { get; set; }
        public OfficeAssignment? OfficeAssignment { get; set; }
        /**/
        [Display(Name = "Palk")]
        public int? Salary { get; set; }
        [Display(Name = "Vanus")]
        public int? Age  { get; set; }
        [StringLength(50)]
        [Display(Name = "Osakond")]
        public string? Department { get; set; }
    }
}
