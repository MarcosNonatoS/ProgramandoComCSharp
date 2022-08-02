using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fintech.Dominio
{
    public class Agencia
    {
        public Banco Banco { get; set; }
        public int Numero { get; set; }
        public int DigitoVerificador { get; set; }

       
    }
}
