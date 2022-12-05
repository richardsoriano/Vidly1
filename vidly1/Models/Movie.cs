namespace vidly1.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public GenreType GenreType { get; set; }
        public byte GenreTypeId { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        public byte NumberInStock { get; set; }
    }
}
