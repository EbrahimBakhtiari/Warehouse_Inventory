using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class MadeInCountry : BaseEntity
    {
        /// <summary>
        /// The name of the country where the product is made.
        /// </summary>
        [Required]
        public string MadeInCountryName { get; set; }

        /// <summary>
        /// The products made in this country.
        /// </summary>
        public virtual ICollection<Commodity> Commodities { get; set; }
    }
}
