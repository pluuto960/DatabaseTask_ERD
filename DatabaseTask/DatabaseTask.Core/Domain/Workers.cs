using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTask.Core.Domain
{
    public class Workers
    {
        [Key]
        public int StaffID {  get; set; }
        public string StaffName {  get; set; }
        public string StaffTitle { get; set; }
        public int StaffSalary {  get; set; }
        public int StaffPhone { get; set; }
    }
}

