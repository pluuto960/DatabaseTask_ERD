using System.ComponentModel.DataAnnotations;


namespace DatabaseTask.Core.Domain
{
    public class Shipnote
    {
        [Key]
        public Guid ShipnoteNR { get; set; }
        public DateOnly ShipnoteDate { get; set; }
        public string ShipnoteType { get; set; }
        public Guid StaffID { get; set; }
        public Guid SupplierID { get; set; }
    }
}

