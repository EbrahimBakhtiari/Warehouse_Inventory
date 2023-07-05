using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class BuyRequest : BaseEntity
    {
        /// <summary>
        /// The list of requested items.
        /// </summary>
        public virtual ICollection<BuyRequestItemList> RequestedItmes { get; set; }

        /// <summary>
        /// The foreign key to the inventory request.
        /// </summary>
        [Required]
        public Guid InventoryId { get; set; }
        /// <summary>
        /// The warehouse for the inventory request.
        /// </summary>
        [ForeignKey(nameof(InventoryId))]
        public virtual Inventory Inventory { get; set; }

        /// <summary>
        /// The total quantity of the inventory request.
        /// </summary>
        public int TotalQuantity { get; set; }

        /// <summary>
        /// The date of the inventory request.
        /// </summary>
        public DateTime RequestDate { get; set; }

        public string Description { get; set; }

    }
}
