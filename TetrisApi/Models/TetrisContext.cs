using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace TetrisApi.Models
{
    public class TetrisContext : DbContext
    {
        public TetrisContext(DbContextOptions<TetrisContext> options)
            : base(options)
        {
        }

        public DbSet<TetrisItem> Tetris { get; set; } = null!;
    }
}