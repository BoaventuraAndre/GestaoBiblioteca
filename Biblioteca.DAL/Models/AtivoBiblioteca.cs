using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Biblioteca.DAL.Models
{
    public abstract class AtivoBiblioteca
    {
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public int Ano{ get; set; }

        [Required]
        public Estado Estado { get; set; }

        [Required]
        public decimal Preco { get; set; }

        public string ImageUrl { get; set; }
        public int NumeroDeCopias { get; set; }
        public virtual BibliotecaSurcusal Localizacao { get; set; }

    }
}
