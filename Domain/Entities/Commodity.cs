using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Commodity : BaseEntity
    {
        /// <summary>
        /// The name of the Commodity.
        /// </summary>
        [Required]
        public string CommodityName { get; set; }

        /// <summary>
        /// The foreign key to the Commodity's category.
        /// </summary>
        [Required]
        public Guid CategoryId { get; set; }
        /// <summary>
        /// The product's category.
        /// </summary>
        [ForeignKey(nameof(CategoryId))]
        public virtual Category Category { get; set; }

        /// <summary>
        /// The foreign key to the Commodity's made in country.
        /// </summary>
        [Required]
        public Guid MadeInCountryCountryId { get; set; }
        /// <summary>
        /// The country where the Commodity is made.
        /// </summary>
        [ForeignKey(nameof(MadeInCountryCountryId))]
        public virtual MadeInCountry MadeInCountry { get; set; }

        /// <summary>
        /// The foreign key to the Commodity's unit measure.
        /// </summary>
        [Required]
        public Guid UnitMeasureId { get; set; }
        /// <summary>
        /// The Commodity's unit of measurement.
        /// </summary>
        [ForeignKey(nameof(UnitMeasureId))]
        public virtual UnitMeasure UnitMeasure { get; set; }

        /// <summary>
        /// The consumers who purchase this commodity.
        /// </summary>
        public virtual ICollection<Consumer> Consumers { get; set; }

        /// <summary>
        /// The suppliers who provide this commodity.
        /// </summary>
        public virtual ICollection<Supplier> Suppliers { get; set; }
    }
}
