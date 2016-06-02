
namespace BusinessLayer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using VideoStore.Repository;
    using VideoStore.Model;

    public class MovieService
    {
        private MovieRepository movieRepository = new MovieRepository();
        private GenreService genreService = new GenreService();
        private OrderRepository orderRepository = new OrderRepository();

        public string AddMovie(string name, string director, string genre, string price, bool adult)
        {
            if (name != "" & director != "" & genre != "" & price != "")
            {
                try
                {
                    decimal moviePrice = Convert.ToDecimal(price);
                    var genreEntity = genreService.AddGenre(genre);
                    var movie = new MovieEntity()
                    {
                        GenreId = genreEntity.Id,
                        Name = name,
                        DirectorName = director,
                        Price = moviePrice,
                        Adult = adult,
                    };
                    if (movieRepository.HasEntity(name) == false)
                    {
                        if (movieRepository.AddEntity(movie) == true)
                        {
                            return "Филма е запазен!";
                        }
                        else { return "Филме не е запазен."; }
                    }
                    else { return "Имате съвпадащ филм"; }
                }
                catch (OutOfMemoryException)
                {
                    return "Достигнахте лимита на паметта за съхранение!";
                }
                catch(IndexOutOfRangeException)
                {
                    return "Въвели сте стойност по-голяма от допустимата";
                }
                catch(Exception ex)
                {
                    return ex.ToString();
                }
            }
            else { return "Имате непопълнени полета"; }
        }

        public string UpdateMovie(string movieID, string name, string director, string genre, string price, bool adult)
        {
            if (movieID != "" & name != "" & director != "" & genre != "" & price != "")
            {
                int id = Int32.Parse(movieID);
                decimal moviePrice = Convert.ToDecimal(price);
                var genreEntity = genreService.AddGenre(genre);
                var movie = new MovieEntity()
                {
                    Id = id,
                    GenreId = genreEntity.Id,
                    Name = name,
                    DirectorName = director,
                    Price = moviePrice,
                    Adult = adult,
                };
                if (movieRepository.HasEntityByNameAndOtherId(movie) == false)
                {
                    if (movieRepository.UpdateEntity(movie) == true)
                    {
                        return "Филма е редактиран!";
                    }
                    else { return "Филме не е редактиран."; }
                }
                else { return "Имате съвпадащ филм"; }

            }
            else { return "Имате непопълнени полета"; }
        }

        public string DeleteMovie(string movieNumber, string movieName)
        {
            if(movieRepository.HasEntity(movieName) == true)
            {
                int number = int.Parse(movieNumber);
                if (orderRepository.MovieHasOrders(number) == false)                    
                {
                    movieRepository.DeleteEntity(movieName);
                    return "Филмът е изтрит";
                }
                else { return "Филмът не е изтрит, резервиран e от клиент."; }
            }
            else { return "Въвели сте несъществуващ филм"; }
        }

        public List<string> SelectAllMovie()
        {
            return movieRepository.SelectAll();
        }

        public List<string> SelectMovieByName(string movieName)
        {
            return movieRepository.SelectByName(movieName);
        }

    }
}
