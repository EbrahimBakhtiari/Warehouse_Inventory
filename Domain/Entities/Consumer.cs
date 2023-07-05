using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Consumer : BaseEntity
    {
        /// <summary>
        /// The name of the Consumer.
        /// </summary>
        [Required]
        public string ConsumerName { get; set; }
        /// <summary>
        /// The email of the Consumer.
        /// </summary>
        [Required]
        public string ConsumerEmail { get; set; }
        /// <summary>
        /// The number of the Consumer.
        /// </summary>
        [Required]
        public string ConsumerPhone { get; set; }
        /// <summary>
        /// The Commodities consumed by this Consumer.
        /// </summary>
        public virtual ICollection<Commodity> Commodities { get; set; }
    }
}
