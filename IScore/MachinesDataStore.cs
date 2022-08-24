using IScore.Model;

namespace IScore
{
    public class MachinesDataStore
    {
        public static Guid NewGuid()
        {
            return new Guid();
        }
        Guid g = Guid.NewGuid();
        Guid g1 = Guid.NewGuid();
        Guid g2 = Guid.NewGuid();


        public List<RegisteredMachines> Machines { get; set; }

        public static MachinesDataStore Current { get; set; } = new MachinesDataStore();

        public MachinesDataStore()
        {
            Machines = new List<RegisteredMachines>()
            {
                new RegisteredMachines()
                {
                    Id=1,
                    MachineId= g,
                    LicenseDate= DateTime.Today,
                    LicenseType=1,


                },
                new RegisteredMachines()
                {
                    Id=2,
                    MachineId= g1,
                    LicenseDate= DateTime.Today,
                    LicenseType=2,


                },
                new RegisteredMachines()
                {
                    Id=3,
                    MachineId= g2,
                    LicenseDate= DateTime.Today,
                    LicenseType=3,

                }

            };
        }
    }
}
