using System.ComponentModel.DataAnnotations;

namespace TallinnaRakenduslikKolledž.Models
{

    public class Delinquents
    {
        [Key]
        public int DelinquentsID { get; set; }
       public string FirstName { get; set; }
        public string LastName { get; set; }
        public enum Violation
        {
            UrinalShitting,Smoking,Vandalizing,Gooning,Murder
        }
        public bool Instructor { get; set; }
        public string Details { get; set; }
    }
}
//