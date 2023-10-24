using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WukkaMan_CleaningApi.Models
{
    public class TimeSheet
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("EmployeeId")]
        [Required]
        public int EmployeeId { get; set; }
        public DateTime ClockIn { get; set; }
        public DateTime ClockOut { get; set; }
       
    }
}
