using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class UnitMeasure : BaseEntity
    {
        /// <summary>
        /// The name of the unit of measurement.
        /// </summary>
        [Required]
        public string UnitMeasureName { get; set; }

        /// <summary>
        /// The Commodities using this unit of measurement.
        /// </summary>
        public virtual ICollection<Commodity> Commodities { get; set; }
    }
}
