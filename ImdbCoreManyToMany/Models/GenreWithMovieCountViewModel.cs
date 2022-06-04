namespace ImdbCoreManyToMany.Models
{
    public class GenreWithMovieCountViewModel
    {
        //GenreId
        public int Id { get; set; }
        //GenreName
        public string Name { get; set; }
        public int MovieCount { get; set; }
    }
}
