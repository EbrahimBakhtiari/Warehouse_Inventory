using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class InventoryRequisition : BaseEntity
    {
        /// <summary>
        /// The list of items in the Requisition.
        /// </summary>
        public virtual ICollection<RequisitionItemList> RequisitionItems { get; set; }

        /// <summary>
        /// The foreign key to the inventory requisition's warehouse.
        /// </summary>
        [Required]
        public Guid InventoryId { get; set; }
        /// <summary>
        /// The warehouse for the inventory requisition.
        /// </summary>
        [ForeignKey(nameof(InventoryId))]
        public virtual Inventory Inventory { get; set; }

        /// <summary>
        /// The total quantity of the inventory requisition.
        /// </summary>
        [Required]
        public int TotalQuantity { get; set; }

        /// <summary>
        /// The date of the inventory requisition.
        /// </summary>
        [Required]
        public DateTime RequisitionDate { get; set; }

        /// <summary>
        /// List of consumers
        /// </summary>
        public virtual List<Consumer> Consumers { get; set; }
    }
}
