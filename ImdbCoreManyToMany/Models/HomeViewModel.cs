using System.Collections.Generic;

namespace ImdbCoreManyToMany.Models
{
    public class HomeViewModel
    {
        public List<Movie> Movies { get; set; }
        public List<GenreWithMovieCountViewModel> Genres { get; set; }
        public int? GenreId { get; set; }

    }
}
