using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment2.Models;





namespace Assignment2.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        MovieContext cc = new MovieContext();



        public ActionResult Index()
        {





            return View(cc.Movies.ToList());
        }





        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Movie m)
        {
            cc.Movies.Add(m);
            cc.SaveChanges();
            return RedirectToAction("Index");
        }
     
public ActionResult Details(int id)
        {
            Movie m = cc.Movies.Find(id);
            return View(m);
        } //Edit by id
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Movie m = cc.Movies.Find(id);
            return View(m);
        }
        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            Movie m = cc.Movies.Find(movie.MovieId);
            m.MovieId = movie.MovieId;
            m.MovieName = movie.MovieName;
            m.DateOfRelease = movie.DateOfRelease;
            cc.SaveChanges();
            return RedirectToAction("Index");
        } //Delete by id
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Movie m = cc.Movies.Find(id);
            return View(m);
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConform(int id)
        {
            Movie m = cc.Movies.Find(id);
            cc.Movies.Remove(m);
            cc.SaveChanges();
            return RedirectToAction("Index");
        }

       


        public ActionResult MovieByYear(string year)
        {
            IEnumerable<Movie> movies = (from var in cc.Movies
                                         where var.DateOfRelease.ToString().Contains(year)
                                         select var).ToList();
            return View(movies.ToList());
        }
    }
}