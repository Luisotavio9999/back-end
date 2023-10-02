using Microsoft.EntityFrameworkCore;
using _18_CLUD_BD.Models;

namespace _18_CLUD_BD.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        //no meu DbSet carrera todos os jogos salvos no banco de dados 
        public DbSet<Jogo> jogos {get; set;}

    }
}