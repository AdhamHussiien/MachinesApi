using System.ComponentModel.DataAnnotations;

namespace IScore.Model
{
    public class MachinesCreation
    {
        [Key]
        public int Id { get; set; }
        public Guid MachineId { get; set; }

        public DateTime LicenseDate { get; set; }
        public byte LicenseType { get; set; }

    }
}
