﻿using System;
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
        public List<string> SelectAllOrders()
        {
            List<string> listOrders = new List<string>();
            using (var db = new VideoClubDbContext())
            {
                var orders = db.Orders
                    .Where(o => o.Person.Name != null)
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
        public List<string> SelectOrdersByName(string personName)
        {
            List<string> listOrders = new List<string>();
            using( var db = new VideoClubDbContext())
            {
                var orders = db.Orders
                    .Where(o => o.Person.Name == personName)
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

        public bool MovieHasOrders(int number)
        {
            using(var db = new VideoClubDbContext())
            {
                var hasOrder = db.Orders
                    .Where(o => o.MovieId == number)
                    .Any();
                return hasOrder;
            }
        }

        public bool PersonHasOrders(string personName)
        {
            using(var db = new VideoClubDbContext())
            {
                var hasOrder = db.Orders
                    .Where(o => o.Person.Name == personName)
                    .Any();
                return hasOrder;
            }
        }
    }
}
