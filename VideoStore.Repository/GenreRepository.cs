﻿namespace VideoStore.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using VideoStore.Model;

    public class GenreRepository
    {
        public GenreEntity AddGenre(GenreEntity genre)
        {
            using (var db = new VideoClubDbContext())
            {
                db.Genres.Add(genre);
                db.SaveChanges();
            }
            return genre;
        }

        public bool HasGenre(string genre)
        {
            using(var db = new VideoClubDbContext())
            {
                var hasGenre = db.Genres
                    .Where(h => h.Name.ToString() == genre)
                    .Any();
                return hasGenre;

            }
            
        }

        public GenreEntity getGenreEntity(string genre)
        {
            using (var db = new VideoClubDbContext())
            {
                var genres = db.Genres
                    .Where(h => h.Name.ToString() == genre)
                    .FirstOrDefault();
                return genres;
            }
        }
    }
}
