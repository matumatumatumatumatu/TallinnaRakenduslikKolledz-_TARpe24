using System.ComponentModel.DataAnnotations;

namespace TallinnaRakenduslikKolledž.Models
{

    public class Delinquents
    {
        [Key]
        public int DelinquentsID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public enum ViolationType
        {
            UrinalShitting, Smoking, Vandalizing, Gooning, Murder
        }
        public ViolationType Violation { get; set; }
        public bool Instructor { get; set; }
        public string Details { get; set; }
    }
}