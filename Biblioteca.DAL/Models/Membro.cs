using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.DAL.Models
{
    public class Membro
    {
        public int id { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Morada { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string TelephoneNumber { get; set; }

        public virtual CartaoMembro CartaoMembro { get; set; }
        public virtual BibliotecaSurcusal BibliotecaSurcusalPrincipal {get; set;}
    }
}
