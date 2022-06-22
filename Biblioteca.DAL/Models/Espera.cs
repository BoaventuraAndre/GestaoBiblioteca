using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.DAL.Models
{
    public class Espera
    {
        public int Id { get; set; }
        public virtual AtivoBiblioteca AtivoBiblioteca { get; set; }
        public virtual CartaoMembro CartaoMembro { get; set;  }
        public DateTime EsperaPedida { get; set; }
    }
}
