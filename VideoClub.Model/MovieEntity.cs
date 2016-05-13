

namespace VideoClub.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
//    using System.ComponentModel.DataAnnotations;

    public class MovieEntity
    {
        public MovieEntity()
        {
            //this.Quantity = 3;
        }

        public int Id { get; set; }

 //       [Required(ErrorMessage = "Не сте въвели име на филма!")]
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int CurrentQuantity { get; set; }
        public decimal Price { get; set; }
        public string DirectorName { get; set; }
        public bool Adult { get; set; }
        public int GenreId { get; set; }
        public virtual GenreEntity Genre { get; set; }
    }
}

