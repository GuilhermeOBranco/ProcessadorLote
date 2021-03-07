using System;
using ggg_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace ggg_backend.Context
{
    public class MemmoryDatabaseContext: DbContext
    {
        public MemmoryDatabaseContext(DbContextOptions<MemmoryDatabaseContext> options) : base (options)
        {
            
        }
        public DbSet<Solicitacao> Solicitacao {get; set;}
        public DbSet<Usuario> Usuario {get; set;}


    }
}