namespace MovieSystem.Models
{
    public class Director
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
