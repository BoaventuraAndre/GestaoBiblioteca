using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.DAL.Models
{
    public class CartaoMembro
    {
        public int Id { get; set; }
        public decimal Cotas { get; set; }
        public DateTime Registo { get; set; }
        public virtual IEnumerable<Checkout> Checkouts { get; set; }
    }
}
