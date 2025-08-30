namespace Library_Management.Models
{
    public class CopyBookViewModel
    {
        public Guid BookId { get; set; }
        public string CoverImageUrl { get; set; }
        public string Condition { get; set; }
        public string Source { get; set; }
    }
}
