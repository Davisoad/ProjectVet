using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    internal class Cachorro:Animal
    {
        private string vacina;

        public string Vacina { get => vacina; set => vacina = value; }

        override public string MostraDados()
        {
            return base.MostraDados() + vacina;
        }

        override public double CalculaPreco()
        {
            double valor;
            if (Raca == "Pitbull")
                valor = preco * 2;
            else if (Raca == "Dálmata")
                valor = preco * 3;
            else
                valor = preco + 200;
            return valor;
        }

    }
}
