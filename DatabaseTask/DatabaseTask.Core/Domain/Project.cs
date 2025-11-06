using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTask.Core.Domain
{
    public class Project
    {
        [Key]
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public string ProjectLocation { get; set; }
        public string ProjectStart {  get; set; }
        public string ProjectEnd {  get; set; }

        [ForeignKey(nameof(StaffPosition))]
        public int ProjectLeaderID {  get; set; }
        public int ProjectStaffID { get; set; }
    }
}