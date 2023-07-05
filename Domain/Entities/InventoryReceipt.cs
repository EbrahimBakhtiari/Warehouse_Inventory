using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class InventoryReceipt : BaseEntity
    {
        /// <summary>
        /// The list of items in the Receipt.
        /// </summary>
        public virtual ICollection<ReceiptItemList> ReceiptItems { get; set; }

        /// <summary>
        /// The foreign key to the inventory receipt's warehouse.
        /// </summary>
        [Required]
        public Guid InventoryId { get; set; }
        /// <summary>
        /// The warehouse for the inventory receipt.
        /// </summary>
        [ForeignKey(nameof(InventoryId))]
        public virtual Inventory Inventory { get; set; }

        /// <summary>
        /// The total quantity of the inventory receipt.
        /// </summary>
        public int TotalQuantity { get; set; }

        /// <summary>
        /// The total price of the inventory receipt.
        /// </summary>
        public decimal TotalPrice { get; set; }

        /// <summary>
        /// The date of the inventory receipt.
        /// </summary>
        public DateTime ReceiptDate { get; set; }

        /// <summary>
        /// List of consumers
        /// </summary>
        public virtual List<Supplier> Suppliers { get; set; }
    }
}
