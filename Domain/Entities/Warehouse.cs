using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Warehouse : BaseEntity
    {
        /// <summary>
        /// The name of the warehouse.
        /// </summary>
        [Required]
        public string WarehouseName { get; set; }

        /// <summary>
        /// The Location of the warehouse.
        /// </summary>
        [Required]
        public string WarehouseLocation { get; set; }

        /// <summary>
        /// The inventory items stored in this warehouse.
        /// </summary>
        public virtual ICollection<Inventory> Inventories { get; set; }
    }
}
