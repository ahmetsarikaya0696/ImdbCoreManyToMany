using ImdbCoreManyToMany.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ImdbCoreManyToMany.Areas.Admin.Models
{
    public class EditViewModel
    {
        public int Id { get; set; }
        [Required, MaxLength(20)]
        public string ImdbId { get; set; }

        [Required, MaxLength(400)]
        public string Name { get; set; }

        [Required]
        public int? Year { get; set; }

        [Required]
        public decimal? Rating { get; set; }

        [MaxLength(255)]
        public string ImageUrl { get; set; }

        public int[] SelectedGenres { get; set; } = Array.Empty<int>();

        // Navigation property
        public List<Genre> Genres { get; set; }
    }
}
