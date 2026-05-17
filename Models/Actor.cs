using System;
using System.Collections.Generic;
namespace SakilaApp.Models {
    public class Actor { 
        public int ActorId { get; set; } 
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public DateTime LastUpdate { get; set; } 
        public virtual ICollection<FilmActor> FilmActors { get; set; } 
    }
}