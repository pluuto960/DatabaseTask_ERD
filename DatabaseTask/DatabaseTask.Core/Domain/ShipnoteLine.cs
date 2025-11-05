using System.ComponentModel.DataAnnotations;


namespace DatabaseTask.Core.Domain
{
    public class ShipnoteLine
    {
        [Key]
        public Guid LineID { get; set; }
        public Guid ShipNoteNr { get; set; }
        public Guid ItemID { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }
    }
}
