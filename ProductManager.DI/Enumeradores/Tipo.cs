using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.DI.Enumeradores
{
    public enum Tipo
    {
        [Description("Material")]
        Material = 0,
        [Description("Serviço")]
        Servico = 1
    }
}
