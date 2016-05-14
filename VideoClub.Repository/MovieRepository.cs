namespace VideoClub.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using VideoClub.Models;
    using VideoClub.Data;

    public class MovieRepository
    {
        public List<string> SelectMovieByName(string movieName)
        {
            using(var db = new VideoClubDbContext())
            {
                List<string> movieList = new List<string>();

                var movies = db.Movies
                    .Where(m => m.Name == movieName)
                    .Select(m => new
                    {
                        ID = m.Id,
                        MovieName = m.Name,
                        Genre = m.Genre.Name,
                        Quantity = m.Quantity,
                        Price = m.Price,
                        Adult = m.Adult,
                    })
                    .ToList();
                foreach (var movie in movies)
                {
                    movieList.Add(movie.ID.ToString());
                    movieList.Add(movie.MovieName.ToString());
                    movieList.Add(movie.Genre.ToString());
                    movieList.Add(movie.Quantity.ToString()); 
                    movieList.Add(movie.Price.ToString());
                    movieList.Add(movie.Adult.ToString());                   
                }
                return movieList;
            }
        }

        public List<string> SelectAllMovies()
        {
            List<string> movieList = new List<string>();
            using(var db = new VideoClubDbContext())
            {
                var movies = db.Movies
                    .Select(m => new
                    {
                        ID = m.Id,
                        MovieName = m.Name,
                        Genre = m.Genre.Name,
                        Quantity = m.Quantity,
                        Price = m.Price,
                        Adult = m.Adult
                    })
                    .OrderBy(m => m.MovieName)
                    .ToList();

                foreach (var movie in movies)
                {
                    movieList.Add(movie.ID.ToString());
                    movieList.Add(movie.MovieName.ToString());
                    movieList.Add(movie.Genre.ToString());
                    movieList.Add(movie.Quantity.ToString());
                    movieList.Add(movie.Price.ToString());
                    movieList.Add(movie.Adult.ToString());
                }
                return movieList;
            }

        }

        public bool AddMovie(MovieEntity movie)
        {
            using(var db = new VideoClubDbContext())
            {
                db.Movies.Add(movie);
                db.SaveChanges();
            }

            return true;
        }

        public bool DeleteMovie(string movieName)
        {
            using(var db = new VideoClubDbContext())
            {
                var movie = db.Movies
                    .Where(m => m.Name == movieName)
                    .First();

                db.Movies.Remove(movie);
                db.SaveChanges();
                return true;
                
            }
        }

        public bool HasMovie(string name)
        {
            using (var db = new VideoClubDbContext())
            {
                var hasMovie = db.Movies
                    .Where(h => h.Name == name)
                    .Any();
                return hasMovie;
            }
        }

        public int MovieId(string name)
        {
            using( var db = new VideoClubDbContext())
            {
                var movieId = db.Movies
                    .Where(m => m.Name == name)
                    .FirstOrDefault();
                return movieId.Id;
            }
        }

        public MovieEntity GetMovieEntity(string movieName)
        {
            using(var db = new VideoClubDbContext())
            {
                var movie = db.Movies
                    .Where(m => m.Name == movieName)
                    .FirstOrDefault();
                return movie;
            }
        }
    }
}
