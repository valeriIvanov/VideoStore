using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoStore.Repository;
using VideoStore.Model;

namespace BusinessLayer
{
    public class OrderService
    {
        private OrderRepository orderRepository = new OrderRepository();
        private MovieRepository movieRepository = new MovieRepository();
        private PersonRepository personRepository = new PersonRepository();

        public string MakeOrder(string movieName, string personName)
        {
            if(movieName != ""  & personName != "")
            {
                var date = DateTime.Now;
                int currentYear = date.Year;

                if(movieRepository.HasMovie(movieName) == true & personRepository.HasPerson(personName) == true)
                {
                    var personEntity = personRepository.GetPersonEntity(personName);
                    var movieEtity = movieRepository.GetMovieEntity(movieName);

                    if (movieEtity.Adult == true & (currentYear - personEntity.BornYear) >= 18)
                    {
                        
                        var order = new OrderEntity()
                        {
                            GetDate = date,
                            MovieId = movieEtity.Id,
                            PersonId = personEntity.Id

                        };

                        return orderRepository.AddOrder(order);
                    }
                    else { return "Филмът е предназначен за лица над 18г."; }
                }
                else { return "Въвели сте несъществуващ филм или човек"; }
            }
            else return "Имате непопълнени полета";
        }

        public string DeleteOrder(string orderNumber)
        {
            int number = int.Parse(orderNumber);
            return orderRepository.DeleteOrder(number);
        }

        public List<string> SelectAllOrders()
        {
            return orderRepository.SelectAllOrders();
        }

        public List<string> ListOrdersByName(string personName)
        {
            return orderRepository.SelectOrdersByName(personName);
        }

    }
}
