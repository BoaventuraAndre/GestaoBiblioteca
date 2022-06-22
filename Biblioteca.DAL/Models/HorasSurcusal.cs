using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Biblioteca.DAL.Models
{
    public class HorasSurcusal
    {
        public int Id { get; set; }
        public BibliotecaSurcusal Surcusal { get; set; }

        [Range(0, 6)]
        public int DiaDaSemana { get; set; }

        [Range(0, 23)]
        public int HoraAbertura { get; set; }

        [Range(0, 23)]
        public int HoraFecho { get; set; }

    }
}
