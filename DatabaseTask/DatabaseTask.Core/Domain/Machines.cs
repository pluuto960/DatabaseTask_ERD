using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Machines
    {
        [Key]
        public int MachineID { get; set; }
        public string MachineType { get; set; }
        public string MachineBrand { get; set; }
        public int MachineRegNr { get; set; }
        public string MachineMaintenanceInterval { get; set; }

        [ForeignKey(nameof(Project))]
        public string ProjectLocation { get; set; }
    }
}
