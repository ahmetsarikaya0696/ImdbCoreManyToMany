using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ImdbCoreManyToMany.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required, MaxLength(20)]
        public string ImdbId { get; set; }

        [Required, MaxLength(400)]
        public string Name { get; set; }

        public int Year { get; set; }

        // 10.0 gibi oldu
        //[Column(TypeName ="decimal(3,1)")]
        public decimal Rating { get; set; }

        [MaxLength(255)]
        public string ImageUrl { get; set; }

        // Navigation property
        public List<Genre> Genres { get; set; }
    }
}
