using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class BaseEntity : Object
    {
        [Key]
        public Guid Id { get; set; }
        #region Constructors
        public BaseEntity() : base()
        {
            Id = Guid.NewGuid();
            InsertDateTime = DateTime.Now;
        }

        #endregion /Constructors

        #region Properties
        public DateTime InsertDateTime { get; set; }

        public DateTime? UpdateDateTime { get; set; }

        public DateTime? DeleteDateTime { get; set; }

        /// <summary>
        /// حذف شده
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// وضعیت
        /// </summary>
        public bool IsActive { get; set; }

        public string UsernameId { get; set; }

        #endregion /Properties
    }
}
