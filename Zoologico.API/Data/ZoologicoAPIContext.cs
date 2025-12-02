using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Zoologico_Modelos;

    public class ZoologicoAPIContext : DbContext
    {
        public ZoologicoAPIContext (DbContextOptions<ZoologicoAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Zoologico_Modelos.Especie> Especie { get; set; } = default!;

public DbSet<Zoologico_Modelos.Raza> Raza { get; set; } = default!;

public DbSet<Zoologico_Modelos.Animal> Animal { get; set; } = default!;
    }
