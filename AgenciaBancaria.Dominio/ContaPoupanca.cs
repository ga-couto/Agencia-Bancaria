using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public class ContaPoupanca : ContaBancaria
    {
        public decimal PERCENTUALRENDIMENTO { get; private set; }


        public ContaPoupanca(Cliente cliente) : base(cliente)
        {
            PERCENTUALRENDIMENTO = 0.003M;
        }
    }
}
