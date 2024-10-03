using CodeFirstBasic.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstBasic.Context
{
    public class PatikaFirstDbContext : DbContext
    {
        public PatikaFirstDbContext(DbContextOptions<PatikaFirstDbContext> options) : base(options)
        {

        }

        public DbSet<GameEntity> Games => Set<GameEntity>();
        public DbSet<MovieEntity>Movies => Set<MovieEntity>();

    
    }

}
