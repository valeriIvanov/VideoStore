namespace VideoStore.Models
{
    using System;
    using System.Collections.Generic;
//    using System.ComponentModel.DataAnnotations;

    public class PersonEntity
    {

        public PersonEntity()
        {

        }
        public int Id { get; set; }

//        [Required(ErrorMessage = "Не сте въвели име на човека!")]
        public string Name { get; set; }

//        [Range(1910, 3000, ErrorMessage = "Въвели сте несъществуваща дата!")]
        public int BornYear { get; set; }

    }
}
