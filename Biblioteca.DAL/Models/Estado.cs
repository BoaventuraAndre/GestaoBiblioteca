using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Biblioteca.DAL.Models
{
    public class Estado
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }

        [Required]
        public string Descricao { get; set; }
    }
}
