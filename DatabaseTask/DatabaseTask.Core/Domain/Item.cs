using System.ComponentModel.DataAnnotations;


namespace DatabaseTask.Core.Domain
{
    public class Item
    {
        [Key]
        public int ItemID { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int Stock { get; set; }

        public int ItemGroupID { get; set; }
        public ItemGroup ItemGroup { get; set; }

        public int SupplierID { get; set; }
        public Supplier Supplier { get; set; }

        public ICollection<ShipnoteLine> ShipnoteLines { get; set; }
    }
}