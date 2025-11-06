using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class SupplierDocuments
    {
        [Key]
        public int SupplyNr {  get; set; }
        public string SupplyDate { get; set; }
        public string SupplyMaterial { get; set; }
        public int SupplyQuantity { get; set; }
        public decimal SupplyPrice { get; set; }


        [ForeignKey(nameof(Supplier))]
        public int SupplierID { get; set; }
        [ForeignKey(nameof(Project))]
        public int ProjectID { get; set; }
    }
}
