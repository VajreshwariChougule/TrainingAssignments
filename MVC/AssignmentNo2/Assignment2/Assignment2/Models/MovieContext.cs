using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;



namespace Assignment2.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext() : base("name=Movie")
        {



        }
        public DbSet<Movie> Movies { get; set; }
    }
}