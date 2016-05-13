
namespace VideoClub.Models
{
    using System;
    using System.Collections.Generic;
    //    using System.ComponentModel.DataAnnotations;

    public class GenreEntity
    {
        public GenreEntity()
        {
        }

        public int Id { get; set; }

        //        [Required(ErrorMessage = "Не сте въвели име на жанра!")]
        public GenreName Name { get; set; }
    }
}