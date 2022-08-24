using IScore.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IScore.Controllers
{
    [Route("api/Machines")]
    [ApiController]
    public class GetMachines : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<RegisteredMachines>> AllMachines()
        {
            return Ok(MachinesDataStore.Current.Machines);
        }
        [HttpGet("{id}")]
        public ActionResult<RegisteredMachines> MachinesById(int id)
        {
            var machine = MachinesDataStore.Current.Machines.FirstOrDefault(c => c.Id == id);
            if (machine == null)
            {
                   return NotFound();
            }
            return Ok(machine);
        }
        [HttpPost]

        public ActionResult<RegisteredMachines> CreateMachine(
            MachinesCreation MachineCreate)
        {
            var FinalMachine = new RegisteredMachines()
            {
                Id = MachineCreate.Id,
                MachineId = MachineCreate.MachineId,
                LicenseDate = MachineCreate.LicenseDate,
                LicenseType = MachineCreate.LicenseType,
            };
            MachinesDataStore.Current.Machines.Add(FinalMachine);
            return Ok(FinalMachine);

            

        }
        [HttpPut("{MachineId}")]

        public ActionResult UpdateMachine(int MachineId, MachinesUpdate updateMachine)
        {
            var machine= MachinesDataStore.Current.Machines.FirstOrDefault(c => c.Id == MachineId);
            if(machine == null)
            {
                return NotFound();
            }

            machine.Id = updateMachine.iD;
            machine.LicenseDate = updateMachine.LicenseDate;
            machine.LicenseType = updateMachine.LicenseType;

            return NoContent();
            
        }
                    

        


    }
}
