using System.ComponentModel.DataAnnotations;

namespace IDP.Domain.Entities
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            InsertDate = DateTime.UtcNow;
        }

        [Key]
        public int Id { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
