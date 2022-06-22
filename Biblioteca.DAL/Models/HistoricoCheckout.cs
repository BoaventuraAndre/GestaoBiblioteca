using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Biblioteca.DAL.Models
{
   public class HistoricoCheckout
    {
        public int Id { get; set; }
        [Required]
        public AtivoBiblioteca AtivoBiblioteca { get; set; }
        [Required]
        public CartaoMembro CartaoMembro { get; set; }
        [Required]
        public DateTime Saiu { get; set; }
        public DateTime? Entrou { get; set; }
    }
}
