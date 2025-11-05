using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class ShipnoteLine
    {
        [Key]
        public int LineID { get; set; }

        [ForeignKey(nameof(Shipnote))]
        public int ShipnoteNr { get; set; }

        [InverseProperty(nameof(Shipnote.ShipnoteLines))]
        public Shipnote Shipnote { get; set; }

        public int ItemID { get; set; }
        public Item Item { get; set; }

        public int Amount { get; set; }
        public int Price { get; set; }
    }
}
