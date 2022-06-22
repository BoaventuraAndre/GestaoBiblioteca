using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Biblioteca.DAL.Models
{
   public class Checkout
    {
        public int Id { get; set; }
        [Required]
        public AtivoBiblioteca AtivoBiblioteca { get; set; }
        public CartaoMembro CartaoMembro { get; set; }
        public DateTime Desde { get; set; }
        public DateTime Ate { get; set; }
    }
}
