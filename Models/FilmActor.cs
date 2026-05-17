using System;

namespace SakilaApp.Models
{
    public class FilmActor
    {
        public int ActorId { get; set; }
        public int FilmId { get; set; }
        public DateTime LastUpdate { get; set; }
        public virtual Actor Actor { get; set; }
        public virtual Film Film { get; set; }
    }
}