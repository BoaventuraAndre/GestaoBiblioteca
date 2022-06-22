using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Biblioteca.DAL.Models
{
    public class BibliotecaSurcusal
    {
        
        public int Id { get; set; }

        [Required]
        [StringLength(30, ErrorMessage= "O nome da surcusal tem que ter menos de 30 caracteres!")]
        public string Nome { get; set; }
        
        [Required]
        public string Morada { get; set; }

        [Required]
        public string Telefone { get; set; }
        public string Descricao { get; set; }
        public DateTime HoraAbertura { get; set; }

        public virtual IEnumerable<Membro> Membros { get; set; }
        public virtual IEnumerable<AtivoBiblioteca> AtivoBibliotecas { get; set; }

        public string ImageUrl { get; set; }


    }
}
