using BlogMVC.Models.Entidades;
using Microsoft.EntityFrameworkCore;

namespace BlogMVC.Models.Contexto
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>()
                .HasOne(p => p.Blog)
                .WithMany(b => b.Posts)
                .HasForeignKey(p => p.BlogId);

            modelBuilder.Entity<Post>()
                .HasOne(p => p.Usuario)
                .WithMany(b => b.Posts)
                .HasForeignKey(p => p.UsuarioId);
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Post> Post { get; set; }

    }
}
