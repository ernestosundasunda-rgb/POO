using System;

namespace Universidade
{
    public class Docente : Pessoa
    {
        private string departamento;

        public Docente() : base()
        {
            departamento = "";
        }

        public Docente(string nome, string codigo, string departamento)
            : base(nome, codigo)
        {
            this.departamento = departamento;
        }

        public string Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }
    }
}