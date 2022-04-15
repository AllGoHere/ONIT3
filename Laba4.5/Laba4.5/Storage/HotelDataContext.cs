using System;
using Laba4._5.Storage.Entity;
using Microsoft.EntityFrameworkCore;

namespace Laba4._5.Storage
{
    public class HotelDataContext : DbContext
    {

        public HotelDataContext(DbContextOptions<HotelDataContext> options) : base(options)
        {
        }


        public DbSet <Number> Numbers { get; set;  }
        public DbSet <Client> Clients { get; set;  }
        public DbSet <Personal> Personals { get; set; }
        public DbSet <CHnumber> CHnumbers { get; set;  }
        public DbSet <Hotel> Hotels { get; set; }

    }



}
