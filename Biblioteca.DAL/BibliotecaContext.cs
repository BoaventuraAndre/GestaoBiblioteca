using Biblioteca.DAL.Models;
using Microsoft.EntityFrameworkCore;


namespace Biblioteca.DAL
{
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext(DbContextOptions options) : base(options) { }

        public DbSet<AtivoBiblioteca> AtivosBiblioteca { get; set; }
        public DbSet<BibliotecaSurcusal> BibliotecaSurcusais { get; set; }


        public DbSet<CartaoMembro> CartoesMembro { get; set; }
        public DbSet<Checkout> Checkouts { get; set; }
        public DbSet<Espera> Esperas{ get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<HistoricoCheckout> HistoricosCheckout { get; set; }
        public DbSet<HorasSurcusal> HorasSurcusais { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Membro> Membros { get; set; }
        public DbSet<Video> Videos { get; set; }
    }
}
 