using System.ComponentModel.DataAnnotations;

namespace dockertraining_compose_francisco_sosa_v1.Models
{
    public class Movie
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
    }
}
