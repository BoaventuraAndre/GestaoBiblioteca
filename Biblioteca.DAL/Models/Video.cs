using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Biblioteca.DAL.Models
{
    public class Video : AtivoBiblioteca
    {
        [Required]
        public string Director { get; set; }
    }
}
