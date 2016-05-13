using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClub.Data;
using VideoClub.Models;

namespace VideoClub.Repository
{
    public class OrderRepository
    {
        public List<string> SelectOrders()
        {
            List<string> listOrders = new List<string>();
            using( var db = new VideoClubDbContext())
            {
                var orders = db.Orders
                    .Where(o => o.PersonId == 1)
                    .Select(e => new
                    {
                        OrdersNumber = e.Id,
                        PersonName = e.Person.Name,
                        MovieName = e.Movie.Name,
                        MakeTimeOrder = e.GetDate
                    }
                    )
                    .ToList();
                    
                foreach (var order in orders)
                {
                    listOrders.Add(order.OrdersNumber.ToString());
                    listOrders.Add(order.PersonName.ToString());
                    listOrders.Add(order.MovieName.ToString());
                    listOrders.Add(order.MakeTimeOrder.ToShortDateString().ToString());
                }
                return listOrders;
            }
        }
        public string AddOrder(OrderEntity order)
        {
            using(var db = new VideoClubDbContext())
            {
                db.Orders.Add(order);
                db.SaveChanges();
            }
            return "Заявката е регистрирана";
        }

        public string DeleteOrder(int orderNumber)
        {
            using (var db = new VideoClubDbContext())
            {
                var order = db.Orders
                    .Where(o => o.Id == orderNumber)
                    .First();
                db.Orders.Remove(order);
                db.SaveChanges();
                return "Заявката беше истрита.";
            }
        }
    }
}
