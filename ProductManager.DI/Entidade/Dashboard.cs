using ProductManager.DI.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Domain.Entidade
{
    public class Dashboard
    {
        public Tipo Tipo { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitarioMedio { get; set; }
    }
}
