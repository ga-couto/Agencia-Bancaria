using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public abstract class ContaBancaria
    {
        public int NUMEROCONTA { get; init; }
        public int DIGITOVERIFICADOR { get; set; }
        public decimal SALDO { get; protected set; }
        public DateTime? DATAABERTURA { get; private set; }
        public DateTime? DATAENCERRAMENTO { get; private set; }
        public SituacaoConta SITUACAO { get; private set; }
        public string SENHA { get; private set; }
        public Cliente CLIENTE { get; init; }

        public void Abrir(string senha)
        {
            SetaSenha(senha);

            SITUACAO = SituacaoConta.Aberta;
        }

        private void SetaSenha(string senha)
        {
            senha = senha.VerificaStringVazia();

            if (!Regex.IsMatch(senha, @"^(?=.*?[a-z])(?=.*?[0-9]).{8,}$"));
            {
                throw new Exception("Digite 8 caracteres contendo letras e números");
            }

            SENHA = senha;
        }

        public virtual void Sacar(decimal valor, string senha)
        {
            if (SENHA != senha)
            {
                throw new Exception("Errou a senha ou está tentando roubar dinheiro. Tente novamente");
            }
            if (SALDO < valor)
            {
                throw new Exception("tA POBRE, MAKE MONEY MAN!!!");
            }

            SALDO -= valor;
        }

        public ContaBancaria(Cliente cliente)
        {
            Random random = new Random();
            NUMEROCONTA = random.Next(100,999);
            DIGITOVERIFICADOR = random.Next(0, 9);

            CLIENTE = cliente ?? throw new Exception("Informe o Cliente");

            SITUACAO = SituacaoConta.Criada;
        }             
    }
}
