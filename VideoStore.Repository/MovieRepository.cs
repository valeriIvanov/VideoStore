namespace VideoStore.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using VideoStore.Models;

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
                        Price = m.Price,
                        Adult = m.Adult,
                    })
                    .ToList();
                foreach (var movie in movies)
                {
                    movieList.Add(movie.ID.ToString());
                    movieList.Add(movie.MovieName.ToString());
                    movieList.Add(movie.Genre.ToString());
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
                    movieList.Add(movie.Price.ToString());
                    movieList.Add(movie.Adult.ToString());
                }
                return movieList;
            }

        }

        public bool UpdateMovie(MovieEntity movie)
        {
            using(var db = new VideoClubDbContext())
            {
                var updatedMovie = db.Movies
                    .Where(u => u.Id == movie.Id)
                    .First();
                updatedMovie.Name = movie.Name;
                updatedMovie.Price = movie.Price;
                updatedMovie.GenreId = movie.GenreId;
                updatedMovie.DirectorName = movie.DirectorName;
                updatedMovie.Adult = movie.Adult;
                db.SaveChanges();
            };
            return true;
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

        public bool HasMovie(string movieName)
        {
            using (var db = new VideoClubDbContext())
            {
                var hasMovie = db.Movies
                    .Where(h => h.Name == movieName)
                    .Any();
                return hasMovie;
            }
        }

        public bool HasMovieByNameAndOtherId(MovieEntity movie)
        {
            using( var db = new VideoClubDbContext())
            {
                var otherMovie = db.Movies
                    .Where(m => m.Name == movie.Name & m.Id != movie.Id)
                    .Any();
                return otherMovie;
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
