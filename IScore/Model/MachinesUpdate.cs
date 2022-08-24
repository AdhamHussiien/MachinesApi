using System.ComponentModel.DataAnnotations;

namespace IScore.Model
{
    public class MachinesUpdate
    {
        [Key]
        
        public int iD { get; set; }
        public DateTime LicenseDate { get; set; }

        public byte LicenseType { get; set; }
    }
}
