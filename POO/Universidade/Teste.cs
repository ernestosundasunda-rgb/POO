using System;

namespace Universidade
{
    public class Teste : Avaliacao
    {
        private double notaObtida;

        public Teste() : base()
        {
            notaObtida = 0;
        }

        public Teste(string designacao, double peso, double notaObtida)
            : base(designacao, peso)
        {
            this.notaObtida = notaObtida;
        }

        public double NotaObtida
        {
            get { return notaObtida; }
            set { notaObtida = value; }
        }

        public override double Nota()
        {
            return notaObtida;
        }
    }
}