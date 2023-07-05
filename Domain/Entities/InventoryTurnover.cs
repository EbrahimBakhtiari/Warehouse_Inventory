using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class InventoryTurnover : BaseEntity
    {
        /// <summary>
        /// The foreign key to the inventory turnover's inventory.
        /// </summary>
        [Required]
        public Guid InventoryId { get; set; }
        /// <summary>
        /// The inventory for the inventory turnover.
        /// </summary>
        [ForeignKey(nameof(InventoryId))]
        public virtual Inventory Inventory { get; set; }

        /// <summary>
        /// The inventory turnover's total quantity sold.
        /// </summary>
        public int TotalQuantitySold { get; set; }

        /// <summary>
        /// The inventory turnover's total quantity purchased.
        /// </summary>
        public int TotalQuantityPurchased { get; set; }

        /// <summary>
        /// The inventory turnover's start date.
        /// </summary>
        public DateTime PeriodStart { get; set; }

        /// <summary>
        /// The inventory turnover's end date.
        /// </summary>
        public DateTime PeriodEnd { get; set; }

        public decimal TurnoverRate { get; set; }
        public int ReorderLevel { get; set; }

    }
}
