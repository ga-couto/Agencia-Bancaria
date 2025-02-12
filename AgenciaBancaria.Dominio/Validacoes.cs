﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public static class Validacoes
    {
        public static string VerificaStringVazia(this string textoAnalisado)
        {
            return string.IsNullOrWhiteSpace(textoAnalisado) ?
                throw new Exception("Inserção inválida. Digite novamente")
                : textoAnalisado;
        }
    }
}
