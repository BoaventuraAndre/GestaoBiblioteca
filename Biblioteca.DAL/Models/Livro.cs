using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Biblioteca.DAL.Models
{
    public class Livro : AtivoBiblioteca
    {
        [Required]
        public string ISBN { get; set; }

        [Required]
        public string Autor { get; set; }

        [Required]
        public string DeweyIndex { get; set; }

    }
}
