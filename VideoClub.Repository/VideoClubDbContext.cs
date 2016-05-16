
namespace VideoClub.Repository
{
    using System.Data.Entity;
    using VideoClub.Models;

    public class VideoClubDbContext : DbContext
    {
        public VideoClubDbContext()
            : base("VideoClubDb")
        {

        }

        public virtual IDbSet<GenreEntity> Genres { get; set; }

        public virtual IDbSet<MovieEntity> Movies { get; set; }

        public virtual IDbSet<OrderEntity> Orders { get; set; }

        public virtual IDbSet<PersonEntity> Persons { get; set; }

    }
}