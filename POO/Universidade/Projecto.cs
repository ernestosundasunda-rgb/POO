using System;

namespace Universidade
{
    public class Projecto : Avaliacao
    {
        private double notaObtida;

        public Projecto() : base()
        {
            notaObtida = 0;
        }

        public Projecto(string designacao, double peso, double notaObtida)
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