using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    internal class Gato:Animal
    {
        private int idade;

        public int Idade { get => idade; set => idade = value; }

        override public string MostraDados()
        {
            return base.MostraDados() + idade;
        }

        override public double CalculaPreco()
        {
            double valor;
            if (idade < 3)
                valor = preco * 2;
            else
                valor = preco + 200;
            return valor;
        }
    }
}
