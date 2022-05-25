using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [Required,MinLength(250),MaxLength(2500)]
        public string Story { get; set; }
        public DateTime DateTime { get; set; }
        public string? Image { get; set; }
    }
}
