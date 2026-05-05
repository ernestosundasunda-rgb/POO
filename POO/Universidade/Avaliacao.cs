using System;

namespace Universidade
{
    public abstract class Avaliacao
    {
        protected string designacao;
        protected double peso;

        public Avaliacao()
        {
            designacao = "";
            peso = 0;
        }

        public Avaliacao(string designacao, double peso)
        {
            this.designacao = designacao;
            this.peso = peso;
        }

        public string Designacao
        {
            get { return designacao; }
            set { designacao = value; }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        // Método abstrato
        public abstract double Nota();
    }
}