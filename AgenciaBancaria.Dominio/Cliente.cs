using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public class Cliente
    {
        public string NOME { get; private set; }
        public string CPF { get; private set; }
        public string RG { get; private set; }
        public string CNH { get; set; }
        public Endereco ENDERECO { get; set; }
       

        public Cliente(string nome, string cpf, string rg, string cnh, Endereco endereco)
        {
            NOME = nome.VerificaStringVazia();
            CPF = cpf.VerificaStringVazia();
            RG = rg.VerificaStringVazia();
            CNH = cnh.VerificaStringVazia();
            ENDERECO = endereco ?? throw new Exception("Informe o endereço, por favor!");
                          

        }

      
    }
}
