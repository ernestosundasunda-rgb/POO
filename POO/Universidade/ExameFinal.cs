using System;

namespace Universidade
{
    public class ExameFinal : Avaliacao
    {
        private double notaObtida;

        public ExameFinal() : base()
        {
            notaObtida = 0;
        }

        public ExameFinal(string designacao, double peso, double notaObtida)
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