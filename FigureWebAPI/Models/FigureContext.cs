using System;
using Microsoft.EntityFrameworkCore;

namespace FigureWebAPI.Models {
    public class FigureContext : DbContext{
        public FigureContext(DbContextOptions<FigureContext> options)
           : base(options) {
            Database.EnsureCreated();
        }

        public DbSet<CreateFigure> CreateFigures { get; set; }
    }
}
