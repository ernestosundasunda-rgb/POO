using System;

namespace Universidade
{
    public class Titular : Docente
    {
        private string especialidade;

        public Titular() : base()
        {
            especialidade = "";
        }

        public Titular(string nome, string codigo, string departamento, string especialidade)
            : base(nome, codigo, departamento)
        {
            this.especialidade = especialidade;
        }

        public string Especialidade
        {
            get { return especialidade; }
            set { especialidade = value; }
        }
    }
}