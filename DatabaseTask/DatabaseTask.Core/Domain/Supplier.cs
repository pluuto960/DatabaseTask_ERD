using System.ComponentModel.DataAnnotations;


namespace DatabaseTask.Core.Domain
{
    public class Supplier
    {
        [Key]
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string SupplierAddress { get; set; }
        public int SupplierPhone {  get; set; }

   
    }
}