using System.ComponentModel.DataAnnotations;
namespace UniversityApiBackend_Execercise.Models.DataModels
{
    public class BaseEntity
    {
        [Required]
        [Key]
        public string Id { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set;} = DateTime.Now;
        public string UpdatedBy { get; set; } = string.Empty;
        public DateTime? UpdatedDate { get; set; } = DateTime.Now;
        public string DeletedBy { get; set; } = string.Empty;
        public DateTime? DeletedDate { get; set; } = DateTime.Now;
        public bool IsDeletedBy { get; set;} = false;


    }
}
