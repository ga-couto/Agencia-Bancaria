using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public class ContaCorrente : ContaBancaria
    {
        public decimal TAXAMANUTENCAO { get; private set; }

        public decimal LIMITE { get; private set; }

        public override void Sacar(decimal valor, string senha)
        {
            if (SENHA != senha)
            {
                throw new Exception("Errou a senha ou está tentando roubar dinheiro. Tente novamente");
            }
            if (SALDO + LIMITE < valor)
            {
                throw new Exception("tA POBRE, MAKE MONEY MAN!!!");
            }

            SALDO -= valor;
        }


        public ContaCorrente(Cliente cliente, decimal limite) : base(cliente)
        {
            TAXAMANUTENCAO = 30.75M;
            LIMITE = limite;
        }
    }
}
