using System;
using AgenciaBancaria.Dominio;

namespace AgenciaBancaria.App
{
    class Program
    {
        static void Main(string[] args)
        
        {
            try
            {
                Endereco endereco = new Endereco("Logradouro", "CEP", "Cidade", "Estado");
                Cliente cliente = new Cliente("Nome", "CPF", "RG", "CNH", endereco);

                ContaCorrente conta = new ContaCorrente(cliente, 1000);
                Console.WriteLine("Conta " + conta.SITUACAO + ": " + conta.NUMEROCONTA + "-" + conta.DIGITOVERIFICADOR);
                string senha = "gabr2021";

                conta.Abrir(senha);
                Console.WriteLine("Conta " + conta.SITUACAO + ": " + conta.NUMEROCONTA + "-" + conta.DIGITOVERIFICADOR);

                conta.Sacar(10,senha);
                Console.WriteLine("Saldo: " + conta.SALDO);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
