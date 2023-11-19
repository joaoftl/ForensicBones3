﻿using Microsoft.EntityFrameworkCore;

namespace ForensicBones3.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        //public DbSet<Relatorio> Relatorios { get; set; }
        //public DbSet<InventarioEsqueleto> InventariosEsqueletos { get; set; }

    }
}
