using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public class Endereco
    {
        public string LOGRADOURO { get; private set; }
        public string CEP { get; private set; }
        public string CIDADE { get; private set; }
        public string ESTADO { get; private set; }

        public Endereco(string logradouro, string cep, string cidade, string estado)
        {
            LOGRADOURO = logradouro.VerificaStringVazia();
            CEP = cep.VerificaStringVazia();
            CIDADE = cidade.VerificaStringVazia();
            ESTADO = estado.VerificaStringVazia();
        }

    }
}
