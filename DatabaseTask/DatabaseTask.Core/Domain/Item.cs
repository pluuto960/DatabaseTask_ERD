using System.ComponentModel.DataAnnotations;


namespace DatabaseTask.Core.Domain
{
    public class Item
    {
        [Key]
        public Guid ItemID { get; set; }
        public string Name { get; set; }
        public int UnitPrice { get; set; }
        public int Stock { get; set; }
        public Guid ItemGroupID { get; set; }
        public int SupplierID { get; set; }
    }
}