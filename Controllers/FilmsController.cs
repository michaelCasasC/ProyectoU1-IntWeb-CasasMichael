using Microsoft.AspNetCore.Mvc;
using SakilaApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace SakilaApp.Controllers
{
    public class FilmsController : Controller
    {
        // Datos de prueba (en producción serían de la BD)
        private static List<Film> peliculas = new List<Film>
        {
            new Film { FilmId = 1, Title = "ACADEMY DINOSAUR", ReleaseYear = 2006 },
            new Film { FilmId = 2, Title = "ACE GOLDFINGER", ReleaseYear = 2006 },
            new Film { FilmId = 3, Title = "ADAPTATION HOLES", ReleaseYear = 2006 }
        };

        // Acción: Listar
        public IActionResult Index()
        {
            return View(peliculas);
        }

        // Acción: Detalles
        public IActionResult Details(int id)
        {
            var film = peliculas.FirstOrDefault(f => f.FilmId == id);
            return film == null ? NotFound() : View(film);
        }

        // Acción: Mostrar formulario crear
        public IActionResult Create()
        {
            return View();
        }

        // Acción: Guardar película
        [HttpPost]
        public IActionResult Create(Film film)
        {
            film.FilmId = peliculas.Max(f => f.FilmId) + 1;
            peliculas.Add(film);
            return RedirectToAction("Index");
        }
    }
}