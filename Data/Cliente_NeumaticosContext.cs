using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cliente_Neumaticos.Models;

    public class Cliente_NeumaticosContext : DbContext
    {
    //sirvase como la interpretacion de la base de datos aun objeto comun de c#
        public Cliente_NeumaticosContext (DbContextOptions<Cliente_NeumaticosContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente_Neumaticos.Models.Cliente>? Cliente { get; set; }
    }
