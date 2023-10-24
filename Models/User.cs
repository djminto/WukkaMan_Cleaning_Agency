using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WukkaMan_CleaningApi.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string? Username { get; set; }
        [Required]
        public string? Password { get; set; }
        public int EmployeeId { get; set; }
        public int TimeSheetId { get; set; }
        public int TaskId { get; set; }
        [ForeignKey("EmployeeId")]
        [Required]
        public string? Employee { get; set; }
        [ForeignKey("TimeSheetId")]
        [Required]
        public DateTime? TimeSheet { get; set; }
        [ForeignKey("TaskId")]
        [Required]
        public string? Tasks { get; set; }
    }
}
