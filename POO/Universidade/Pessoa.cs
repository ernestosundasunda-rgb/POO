using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidade
{
    public class Pessoa
    {
        private string nome;
        private string codigo;

        public Pessoa()
        {
            nome = "";
            codigo = "";
        }

        public Pessoa(string nome, string codigo)
        {
            this.nome = nome;
            this.codigo = codigo;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
    }
}
