using System;

namespace Universidade
{
    public class Estudante : Pessoa, IAvaliavel
    {
        private double notaTeste;
        private double notaProjecto;
        private double notaExame;

        public Estudante() : base()
        {
            notaTeste = 0;
            notaProjecto = 0;
            notaExame = 0;
        }

        public Estudante(string nome, string codigo) : base(nome, codigo)
        {
            notaTeste = 0;
            notaProjecto = 0;
            notaExame = 0;
        }

        public double NotaTeste
        {
            get { return notaTeste; }
            set { notaTeste = value; }
        }

        public double NotaProjecto
        {
            get { return notaProjecto; }
            set { notaProjecto = value; }
        }

        public double NotaExame
        {
            get { return notaExame; }
            set { notaExame = value; }
        }

        // Implementação da interface IAvaliavel
        // Ponderação: Teste 30%, Projecto 30%, Exame 40%
        public double CalcularNotaFinal()
        {
            double resultado = (notaTeste * 0.30) + (notaProjecto * 0.30) + (notaExame * 0.40);
            return resultado;
        }
    }
}