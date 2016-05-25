namespace VideoStore.Model
{
    using System;
    using System.Collections.Generic;

    public class OrderEntity
    {
        public OrderEntity()
        {
            this.GetDate = DateTime.Now;
        }

        public int Id { get; set; }
        public DateTime GetDate { get; set; }
        public int PersonId { get; set; }
        public PersonEntity Person { get; set; }
        public int MovieId { get; set; }
        public MovieEntity Movie { get; set; }
    }
}