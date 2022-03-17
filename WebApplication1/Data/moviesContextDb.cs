#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

    public class moviesContextDb : DbContext
    {
        public moviesContextDb (DbContextOptions<moviesContextDb> options)
            : base(options)
        {
        }

        public DbSet<WebApplication1.Models.movie> movie { get; set; }
    }
