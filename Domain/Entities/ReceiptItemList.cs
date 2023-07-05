using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class ReceiptItemList : MovementItemList
    {
        /// <summary>
        /// The foreign key to the InventoryReceipt.
        /// </summary>
        [Required]
        public Guid InventoryReceiptId { get; set; }
        /// <summary>
        /// The InventoryReceipt associated.
        /// </summary>
        [ForeignKey(nameof(InventoryReceiptId))]
        public virtual InventoryReceipt InventoryReceipt { get; set; }
    }
}
