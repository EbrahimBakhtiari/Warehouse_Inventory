using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Supplier : BaseEntity
    {
        /// <summary>
        /// The name of the supplier.
        /// </summary>
        [Required]
        public string SupplierName { get; set; }
        /// <summary>
        /// The email of the supplier.
        /// </summary>
        [Required]
        public string SupplierEmail { get; set; }
        /// <summary>
        /// The number of the supplier.
        /// </summary>
        [Required]
        public string SupplierPhone { get; set; }
        /// <summary>
        /// The Commodities supplied by this supplier.
        /// </summary>
        public virtual ICollection<Commodity> Commodities { get; set; }
    }

}
