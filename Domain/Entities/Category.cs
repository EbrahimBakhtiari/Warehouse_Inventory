using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Category : BaseEntity
    {
        /// <summary>
        /// The name of the category.
        /// </summary>
        [Required]
        public string CategoryName { get; set; }

        /// <summary>
        /// The Commodities in this category.
        /// </summary>
        public virtual ICollection<Commodity> Commodities { get; set; }
    }
}
