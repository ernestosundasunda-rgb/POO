using System;
using System.Collections.Generic;

namespace Universidade
{
    public class UnidadeCurricular
    {
        private string titulo;
        private string codigoUC;
        private List<Estudante> inscritos;
        private List<Avaliacao> avaliacoes;

        public UnidadeCurricular()
        {
            titulo = "";
            codigoUC = "";
            inscritos = new List<Estudante>();
            avaliacoes = new List<Avaliacao>();
        }

        public UnidadeCurricular(string titulo, string codigoUC)
        {
            this.titulo = titulo;
            this.codigoUC = codigoUC;
            inscritos = new List<Estudante>();
            avaliacoes = new List<Avaliacao>();
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string CodigoUC
        {
            get { return codigoUC; }
            set { codigoUC = value; }
        }

        // Agregação: adiciona estudante à lista
        public void AdicionarEstudante(Estudante aluno)
        {
            inscritos.Add(aluno);
        }

        // Composição: adiciona avaliação à lista
        public void AdicionarAvaliacao(Avaliacao prova)
        {
            avaliacoes.Add(prova);
        }

        // Método para atualizar notas de um estudante
        public void AtribuirNotas(string codigoAluno, double notaTeste,
                                   double notaProjecto, double notaExame)
        {
            for (int i = 0; i < inscritos.Count; i++)
            {
                if (inscritos[i].Codigo == codigoAluno)
                {
                    inscritos[i].NotaTeste = notaTeste;
                    inscritos[i].NotaProjecto = notaProjecto;
                    inscritos[i].NotaExame = notaExame;
                    Console.WriteLine("Notas atribuidas com sucesso ao aluno " + inscritos[i].Nome);
                    return;
                }
            }
            Console.WriteLine("Aluno nao encontrado!");
        }

        // Emitir pauta ordenada alfabeticamente
        public void EmitirPauta()
        {
            Console.WriteLine();
            Console.WriteLine("           PAUTA DA UNIDADE CURRICULAR       ");
            Console.WriteLine();
            Console.WriteLine("UC: " + titulo + " (" + codigoUC + ")");
            Console.WriteLine();

            if (inscritos.Count == 0)
            {
                Console.WriteLine("Nenhum estudante inscrito.");
                return;
            }

            // Criar lista ordenada manualmente (bubble sort simples)
            List<Estudante> ordenada = new List<Estudante>();
            for (int i = 0; i < inscritos.Count; i++)
            {
                ordenada.Add(inscritos[i]);
            }

            // Ordenar por nome
            for (int i = 0; i < ordenada.Count - 1; i++)
            {
                for (int j = i + 1; j < ordenada.Count; j++)
                {
                    if (ordenada[i].Nome.CompareTo(ordenada[j].Nome) > 0)
                    {
                        Estudante temporario = ordenada[i];
                        ordenada[i] = ordenada[j];
                        ordenada[j] = temporario;
                    }
                }
            }

            // Mostrar pauta
            Console.WriteLine("Codigo\tNome\t\tNota Final");
            Console.WriteLine();
            for (int i = 0; i < ordenada.Count; i++)
            {
                double notaFinal = ordenada[i].CalcularNotaFinal();
                string situacao = notaFinal >= 10 ? "APROVADO" : "REPROVADO";
                Console.WriteLine(ordenada[i].Codigo + "\t" +
                                  ordenada[i].Nome + "\t\t" +
                                  notaFinal.ToString("F1") + " - " + situacao);
            }
            Console.WriteLine();
        }
    }
}