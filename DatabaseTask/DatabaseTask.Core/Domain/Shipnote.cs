using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTask.Core.Domain
{
    public class Shipnote
    {
        [Key]
        public int ShipnoteNr { get; set; }
        public DateOnly ShipnoteDate { get; set; }
        public string ShipnoteType { get; set; }

        public int StaffID { get; set; }
        public Staff Staff { get; set; }

        public int SupplierID { get; set; }
        public Supplier Supplier { get; set; }


        [InverseProperty(nameof(ShipnoteLine.Shipnote))]
        public ICollection<ShipnoteLine> ShipnoteLines { get; set; }
    }
}

