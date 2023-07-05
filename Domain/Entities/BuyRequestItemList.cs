using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class BuyRequestItemList : BaseEntity
    {
        /// <summary>
        /// The foreign key to the BuyRequest.
        /// </summary>
        [Required]
        public Guid BuyRequestId { get; set; }
        /// <summary>
        /// The BuyRequest associated.
        /// </summary>
        [ForeignKey(nameof(BuyRequestId))]
        public virtual BuyRequest BuyRequest { get; set; }

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
        /// The quantity of the commodity in the receipt/requisition.
        /// </summary>
        [Required]
        public int Quantity { get; set; }
    }
}
