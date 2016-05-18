namespace BusinessLayer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using VideoStore.Repository;
    using VideoStore.Models;

    public class GenreService
    {
        private GenreRepository genreRepository = new GenreRepository();

        public GenreEntity AddGenre(string genre)
        {
            int genreName = GetGenreNumber(genre);
            var genres = new GenreEntity()
            {
                Name = (GenreName)genreName
            };

            if (genreRepository.HasGenre(genre) == false)
            {
                 return genreRepository.AddGenre(genres);
            }
            else return genreRepository.getGenreEntity(genre);
        }

        private int GetGenreNumber(string genre)
        {
            int genreNumber = 0;
            string[] names = Enum.GetNames(typeof(GenreName));
            foreach (var name in names)
            {

                if (name == genre)
                {
                    return genreNumber;
                }
                genreNumber++;
            }
            return genreNumber;
        }

        public string[] GetGenreName()
        {
            string[] genreNameList = Enum.GetNames(typeof(GenreName));

            return genreNameList;
        }
    }
}
