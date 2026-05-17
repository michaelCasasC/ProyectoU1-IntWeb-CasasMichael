using System;
using System.Collections.Generic;
namespace SakilaApp.Models { 
    public class Film { 
        public int FilmId { get; set; } 
        public string Title { get; set; } 
        public string Description { get; set; } 
        public int ReleaseYear { get; set; } 
        public int RentalDuration { get; set; } 
        public decimal RentalRate { get; set; } 
        public int? Length { get; set; } 
        public decimal ReplacementCost { get; set; } 
        public string Rating { get; set; } 
        public DateTime LastUpdate { get; set; } 
        public virtual ICollection<FilmActor> FilmActors { get; set; } 
    } 
}