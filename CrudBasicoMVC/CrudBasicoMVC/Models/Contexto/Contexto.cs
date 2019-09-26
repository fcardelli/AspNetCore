using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudBasicoMVC.Models.Contexto
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
            Database.EnsureCreated();// Verifica se o banco existe, se não ele cria
        }

        public DbSet<Usuario> Usuario { get; set; }
    }
}
