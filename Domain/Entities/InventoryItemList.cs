using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class InventoryItemList : BaseEntity
    {
        /// <summary>
        /// The foreign key to the inventory.
        /// </summary>
        [Required]
        public Guid InventoryId { get; set; }
        /// <summary>
        /// The inventory associated with the item list.
        /// </summary>
        [ForeignKey(nameof(InventoryId))]
        public virtual Inventory Inventory { get; set; }

        /// <summary>
        /// The foreign key to the commodity.
        /// </summary>
        [Required]
        public Guid CommodityId { get; set; }
        /// <summary>
        /// The commodity associated with the item list.
        /// </summary>
        [ForeignKey(nameof(CommodityId))]
        public virtual Commodity Commodity { get; set; }

        /// <summary>
        /// The quantity of the commodity in the inventory.
        /// </summary>
        [Required]
        public int Quantity { get; set; }

        /// <summary>
        /// The price per unit of the commodity.
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// The total price of the commodity in the inventory.
        /// </summary>
        public decimal TotalPrice { get { return Quantity * UnitPrice; } }
    }
}
