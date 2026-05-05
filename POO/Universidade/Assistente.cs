using System;

namespace Universidade
{
    public class Assistente : Docente
    {
        private string area;

        public Assistente() : base()
        {
            area = "";
        }

        public Assistente(string nome, string codigo, string departamento, string area)
            : base(nome, codigo, departamento)
        {
            this.area = area;
        }

        public string Area
        {
            get { return area; }
            set { area = value; }
        }
    }
}