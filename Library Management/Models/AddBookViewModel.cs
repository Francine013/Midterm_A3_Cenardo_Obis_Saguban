namespace Library_Management.Models
{
    public class AddBookViewModel
    {
        public string? Title { get; set; }
        public string? ISBN { get; set; }
        public string? Description { get; set; }
        public string? Genre { get; set; }
        public DateTime? PublishedDate { get; set; }

        // BookItem-specific fields
        public string? CoverImageUrl { get; set; }
        public string? Condition { get; set; }
        public string? Source { get; set; }

        // Author-specific fields
        public string? Author { get; set; }
        public string? AuthorProfileImageUrl { get; set; }
    }
}
