using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission6_Dawson.Models

{
    public class Movie
    {
        [Key][Required] public int MovieId { get; set; }

        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string? Director { get; set; }
        public string? Rating { get; set; }
        public int Edited { get; set; }
        public string? LentTo { get; set; }
        public int CopiedToPlex { get; set; }
        public string? Notes { get; set; }
    }
}
