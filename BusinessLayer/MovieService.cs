
namespace BusinessLayer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using VideoClub.Repository;
    using VideoClub.Models;

    public class MovieService
    {
        MovieRepository movieRepository = new MovieRepository();
        GenreService genreService = new GenreService();
        OrderRepository orderRepository = new OrderRepository();

        public string AddMovie(string name, string director, string genre, string quantity, string price, bool adult)
        {
            if(name != null & director != null & genre != null & quantity != null & price != null)
            {

                int movieQuantity = Int32.Parse(quantity);
                decimal moviePrice = Convert.ToDecimal(price);
                var genreEntity = genreService.AddGenre(genre);
                var movie = new MovieEntity()
                {
                    GenreId = genreEntity.Id,
                    Name = name,
                    DirectorName = director,
                    Price = moviePrice,
                    Quantity = movieQuantity,
                    CurrentQuantity = movieQuantity,
                    Adult = adult,               
                };
                if (movieRepository.HasMovie(name) == false)
                {
                    if (movieRepository.AddMovie(movie) == true)
                    {
                        return "Филма е запазен!";
                    }
                    else { return "Филме не е запазен."; }
                }
                else { return "Имате съвпадащ филм"; }
                
            }
            else { return "Имате непопълнени полета"; }
        }

        public string DeleteMovie(string movieNumber, string movieName)
        {
            if(movieRepository.HasMovie(movieName) == true)
            {
                int number = int.Parse(movieNumber);
                if (orderRepository.MovieHasOrders(number) == false)                    
                {
                    movieRepository.DeleteMovie(movieName);
                    return "Филмът е изтрит";
                }
                else { return "Филмът не е изтрит, резервиран e от клиент."; }
            }
            else { return "Въвели сте несъществуващ филм"; }
        }

        //public void UpdateMovie();

        public List<string> SelectAllMovie()
        {
            return movieRepository.SelectAllMovies();
        }

        public List<string> SelectMovieByName(string movieName)
        {
            return movieRepository.SelectMovieByName(movieName);
        }

    }
}
