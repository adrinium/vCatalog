﻿using Microsoft.EntityFrameworkCore;
using vCatalogRazor.Models;

namespace vCatalogRazor.Data
{
    public class CatalogDbContext : DbContext
    {
        public CatalogDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Promotie>  Promotii { get; set; }
        public DbSet<Clasa> Clase { get; set; }
        public DbSet<Profesor> Profesori { get; set; }
        public DbSet<Elev> Elevi { get; set; }
        public DbSet<Modul> Module { get; set; }
        public DbSet<TipNota> TipNote { get; set; }
        public DbSet<Nota> Note { get; set; }

    }
}
