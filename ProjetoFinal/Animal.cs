using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    abstract class Animal
    {
        private string nome;
        protected double preco;
        private string raca;

        public string Nome { get => nome; set => nome = value; }
        public string Raca { get => raca; set => raca = value; }
        public double Preco { set => preco = value; }

        virtual public string MostraDados()
        {
            return Nome + " - " + Raca + " - ";
        }

        abstract public double CalculaPreco();
    }
}
