using Microsoft.EntityFrameworkCore;
using System;
using WebPasajero.Models;

namespace WebPasajero.Data
{
    public class PasajeroContext :DbContext
    {
        public PasajeroContext(DbContextOptions<PasajeroContext> options)
             : base(options)
        {
        }


        public DbSet<Pasajero> People { get; set; }

    }
}
