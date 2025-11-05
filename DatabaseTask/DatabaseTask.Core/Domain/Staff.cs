using System.ComponentModel.DataAnnotations;


namespace DatabaseTask.Core.Domain
{
    public class Staff
    {
        [Key]
        public Guid StaffID { get; set; }
        public string StaffName { get; set; }
        public string StaffPosition { get; set; }
        public int StaffPhone { get; set; }
        

    }
}
