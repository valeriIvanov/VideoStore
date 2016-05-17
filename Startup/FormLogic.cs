using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using System.Windows.Forms;
using System.Data;

namespace Startup
{
    public class FormLogic
    {
        private PersonService personService = new PersonService();
        private MovieService movieService = new MovieService();
        private OrderService orderService = new OrderService();
        private GenreService genreService = new GenreService();

        public string[] GenreNames()
        {
            return genreService.GetGenreName();
        }

        public DataTable SelectMovies(bool allmovie, string movieName)
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Филм");
            dataTable.Columns.Add("Жанр");
            dataTable.Columns.Add("Наличност");
            dataTable.Columns.Add("Цена");
            dataTable.Columns.Add("За възрастни");

            List<string> movieList = new List<string>();
            if (allmovie == true)
            {
                movieList = movieService.SelectAllMovie();
            }
            else
            {
                movieList = movieService.SelectMovieByName(movieName);
            }

            for (int index = 0; index < movieList.Count ; index +=6)
            {
                dataTable.Rows.Add(movieList[index], movieList[index + 1], movieList[index + 2], movieList[index + 3],
                    movieList[index + 4], movieList[index + 5]);                
            }
            return dataTable;
        }

        public DataTable PersonOrders(bool sortByName, string personName)
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("Заявка N:");
            dataTable.Columns.Add("Име на клиент");
            dataTable.Columns.Add("Филм");
            dataTable.Columns.Add("Дата на взимане");

            List<string> list = new List<string>();
            if (sortByName == true)
            {
                list = orderService.ListOrdersByName(personName);
            }
            else { list = orderService.SelectAllOrders(); }

            for (int index = 0; index < list.Count; index +=4)
            {
                dataTable.Rows.Add(list[index], list[index + 1], list[index + 2], list[index + 3]);
            }
            return dataTable;
        }

        public string AddPerson(string name, string bornYear)
        {
            return personService.AddPerson(name, bornYear);
        }

        public string UpdatePerson(string personID, string personName, string personYear)
        {
            return personService.UpdatePerson(personID, personName, personYear);
        }

        public string DeletePerson(string personName)
        {
            return personService.DeletePerson(personName);
        }

        public DataTable SelectPerson(string personName)
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Име");
            dataTable.Columns.Add("Година на Раждане");

            List<string> personList = personService.SelectPerson(personName);
            for(int index = 0 ; index < personList.Count; index +=3)
            {
                dataTable.Rows.Add(personList[index], personList[index + 1], personList[index + 2]);
            }
            return dataTable;
        }

        public string AddMovie(string name, string director, string genre, string quantity, string price, bool adult)
        {
            return movieService.AddMovie(name, director, genre, quantity, price, adult);
        }

        public string UpdateMovie(string movieID, string name, string director, string genre, string quantity, 
                                    string price, bool adult)
        {
            return movieService.UpdateMovie(movieID, name, director, genre, quantity, price, adult);
        }

        public string DeleteMovie(string movieID, string movieName)
        {
            return movieService.DeleteMovie(movieID, movieName);
        }

        public string AddOrder(string movieName, string personName)
        {
            return orderService.MakeOrder(movieName, personName);
        }

        public string DeleteOrder(string orderNumber)
        {
            return orderService.DeleteOrder(orderNumber);
        }
    }
}
