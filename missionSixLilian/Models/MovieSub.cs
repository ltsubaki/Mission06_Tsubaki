using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace missionSixLilian.Models
{
    public class MovieSub
    {
        [Key]
        public int MovieId { get; set; }
        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        [Required(ErrorMessage = "Sorry, you must input the movie title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Sorry, you must input the year")]
        public int Year { get; set; }
        public  string? Director { get; set; }
        public  string? Rating { get; set; }
        [Required(ErrorMessage = "Sorry, you must answer if it has been edited")]
        public bool Edited { get; set; }
        public string? LentTo { get; set; }
        [Range(0, 25)]
        public string? Notes { get; set; }
        [Required(ErrorMessage = "Sorry, you must answer if it is copied to Plex")]
        public bool CopiedToPlex { get; set; }

    }
}
