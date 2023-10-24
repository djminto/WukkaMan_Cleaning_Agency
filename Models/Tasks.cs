using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WukkaMan_CleaningApi.Models
{
    public class Tasks
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string? TaskName { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string? Description { get; set; }
    }
}
