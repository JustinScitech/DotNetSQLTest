using System.ComponentModel.DataAnnotations;

namespace dotnet_app.Models
{
    public class Post
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string? Title { get; set; }

        public int Modbus { get; set; }
        public string? Category { get; set; }
        public string? Description { get; set; }

        public DateTime CreatedDateTime {get; set;} = DateTime.Now;
    }
}