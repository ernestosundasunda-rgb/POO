using System;
using System.Collections.Generic;

namespace Universidade
{
    class Program
    {
        static UnidadeCurricular poo;
        static List<Estudante> todosAlunos;

        static void Main(string[] args)
        {
            // Inicializar a unidade curricular
            poo = new UnidadeCurricular("Programacao Orientada a Objetos", "POO2024");
            todosAlunos = new List<Estudante>();

            // Criar avaliações padrão (composição)
            Teste teste1 = new Teste("Teste Unico", 0.30, 0);
            Projecto projecto1 = new Projecto("Projecto Final", 0.30, 0);
            ExameFinal exame1 = new ExameFinal("Exame Normal", 0.40, 0);

            poo.AdicionarAvaliacao(teste1);
            poo.AdicionarAvaliacao(projecto1);
            poo.AdicionarAvaliacao(exame1);

            // Criar estudantes de exemplo
            Estudante aluno1 = new Estudante("Carlos Silva", "E001");
            Estudante aluno2 = new Estudante("Ana Santos", "E002");
            Estudante aluno3 = new Estudante("Bruno Costa", "E003");

            poo.AdicionarEstudante(aluno1);
            poo.AdicionarEstudante(aluno2);
            poo.AdicionarEstudante(aluno3);

            todosAlunos.Add(aluno1);
            todosAlunos.Add(aluno2);
            todosAlunos.Add(aluno3);

            // DADOS ATTRINUIDO
            poo.AtribuirNotas("E001", 15, 14, 12);
            poo.AtribuirNotas("E002", 8, 10, 9);
            poo.AtribuirNotas("E003", 16, 15, 14);

            int escolha;

            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("    SISTEMA DE GESTAO UNIVERSITARIA--ERNESTO MENDES ");
                Console.WriteLine();
                Console.WriteLine("1 - Registrar novo estudante");
                Console.WriteLine("2 - Registrar docente");
                Console.WriteLine("3 - Atribuir notas a um estudante");
                Console.WriteLine("4 - Emitir pauta");
                Console.WriteLine("5 - Mostrar dados de um estudante");
                Console.WriteLine("6 - Listar todos os estudantes");
                Console.WriteLine("7 - Listar avaliacoes da UC");
                Console.WriteLine("0 - Sair");
                Console.Write("\nEscolha uma opcao: ");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        RegistrarEstudante();
                        break;
                    case 2:
                        RegistrarDocente();
                        break;
                    case 3:
                        AtribuirNotas();
                        break;
                    case 4:
                        EmitirPauta();
                        break;
                    case 5:
                        MostrarEstudante();
                        break;
                    case 6:
                        ListarEstudantes();
                        break;
                    case 7:
                        ListarAvaliacoes();
                        break;
                    case 0:
                        Console.WriteLine("A sair do sistema...");
                        break;
                    default:
                        Console.WriteLine("Opcao invalida!");
                        break;
                }

                if (escolha != 0)
                {
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }

            } while (escolha != 0);
        }

        static void RegistrarEstudante()
        {
            Console.Clear();
            Console.WriteLine("=== REGISTAR NOVO ESTUDANTE ===\n");

            Console.Write("Nome do aluno: ");
            string nomeAluno = Console.ReadLine();

            Console.Write("Codigo do aluno: ");
            string codigoAluno = Console.ReadLine();

            // VALIDARRC ODIGO
            for (int i = 0; i < todosAlunos.Count; i++)
            {
                if (todosAlunos[i].Codigo == codigoAluno)
                {
                    Console.WriteLine("\nErro: Ja existe um estudante com este codigo!");
                    return;
                }
            }

            Estudante novoAluno = new Estudante(nomeAluno, codigoAluno);
            poo.AdicionarEstudante(novoAluno);
            todosAlunos.Add(novoAluno);

            Console.WriteLine("\nEstudante registado com sucesso!");
        }

        static void RegistrarDocente()
        {
            Console.Clear();
            Console.WriteLine("=== REGISTAR NOVO DOCENTE ===\n");

            Console.Write("Nome do docente: ");
            string nomeDoc = Console.ReadLine();

            Console.Write("Codigo do docente: ");
            string codigoDoc = Console.ReadLine();

            Console.Write("Departamento: ");
            string depart = Console.ReadLine();

            Console.Write("Tipo (1 - Titular, 2 - Assistente): ");
            int tipo = int.Parse(Console.ReadLine());

            if (tipo == 1)
            {
                Console.Write("Especialidade: ");
                string esp = Console.ReadLine();

                Titular titular = new Titular(nomeDoc, codigoDoc, depart, esp);
                Console.WriteLine("\nDocente Titular registado com sucesso!");
                Console.WriteLine("Nome: " + titular.Nome);
                Console.WriteLine("Especialidade: " + titular.Especialidade);
            }
            else if (tipo == 2)
            {
                Console.Write("Area: ");
                string area = Console.ReadLine();

                Assistente assist = new Assistente(nomeDoc, codigoDoc, depart, area);
                Console.WriteLine("\nDocente Assistente registado com sucesso!");
                Console.WriteLine("Nome: " + assist.Nome);
                Console.WriteLine("Area: " + assist.Area);
            }
            else
            {
                Console.WriteLine("\nTipo invalido!");
            }
        }

        static void AtribuirNotas()
        {
            Console.Clear();
            Console.WriteLine("=== ATRIBUIR NOTAS A UM ESTUDANTE ===\n");

            if (todosAlunos.Count == 0)
            {
                Console.WriteLine("Nao ha estudantes registados!");
                return;
            }

            // Mostrar estudantes
            Console.WriteLine("Estudantes inscritos:");
            for (int i = 0; i < todosAlunos.Count; i++)
            {
                Console.WriteLine((i + 1) + " - " + todosAlunos[i].Codigo + " | " + todosAlunos[i].Nome);
            }

            Console.Write("\nDigite o codigo do estudante: ");
            string codigoBusca = Console.ReadLine();

            // Procurar estudante
            bool encontrado = false;
            for (int i = 0; i < todosAlunos.Count; i++)
            {
                if (todosAlunos[i].Codigo == codigoBusca)
                {
                    encontrado = true;
                    Console.Write("Nota do Teste (0-20): ");
                    double nTeste = double.Parse(Console.ReadLine());

                    Console.Write("Nota do Projecto (0-20): ");
                    double nProj = double.Parse(Console.ReadLine());

                    Console.Write("Nota do Exame (0-20): ");
                    double nExame = double.Parse(Console.ReadLine());

                    poo.AtribuirNotas(codigoBusca, nTeste, nProj, nExame);

                    // Mostrar nota final calculada
                    double notaFinal = todosAlunos[i].CalcularNotaFinal();
                    Console.WriteLine("Nota final calculada: " + notaFinal.ToString("F1"));
                }
            }

            if (encontrado == false)
            {
                Console.WriteLine("Estudante nao encontrado!");
            }
        }

        static void EmitirPauta()
        {
            Console.Clear();
            poo.EmitirPauta();
        }

        static void MostrarEstudante()
        {
            Console.Clear();
            Console.WriteLine("=== DADOS DO ESTUDANTE ===\n");

            if (todosAlunos.Count == 0)
            {
                Console.WriteLine("Nao ha estudantes registados!");
                return;
            }

            Console.Write("Digite o codigo do estudante: ");
            string codigoBusca = Console.ReadLine();

            bool encontrado = false;
            for (int i = 0; i < todosAlunos.Count; i++)
            {
                if (todosAlunos[i].Codigo == codigoBusca)
                {
                    encontrado = true;
                    Console.WriteLine("\n--- FICHA DO ESTUDANTE ---");
                    Console.WriteLine("Nome: " + todosAlunos[i].Nome);
                    Console.WriteLine("Codigo: " + todosAlunos[i].Codigo);
                    Console.WriteLine("Nota Teste: " + todosAlunos[i].NotaTeste);
                    Console.WriteLine("Nota Projecto: " + todosAlunos[i].NotaProjecto);
                    Console.WriteLine("Nota Exame: " + todosAlunos[i].NotaExame);
                    Console.WriteLine("Nota Final: " + todosAlunos[i].CalcularNotaFinal().ToString("F1"));
                    Console.WriteLine("--------------------------");
                }
            }

            if (encontrado == false)
            {
                Console.WriteLine("Estudante nao encontrado!");
            }
        }

        static void ListarEstudantes()
        {
            Console.Clear();
            Console.WriteLine("=== LISTA DE ESTUDANTES ===\n");

            if (todosAlunos.Count == 0)
            {
                Console.WriteLine("Nao ha estudantes registados!");
                return;
            }

            for (int i = 0; i < todosAlunos.Count; i++)
            {
                Console.WriteLine("Codigo: " + todosAlunos[i].Codigo);
                Console.WriteLine("Nome: " + todosAlunos[i].Nome);
                Console.WriteLine("Nota Final: " + todosAlunos[i].CalcularNotaFinal().ToString("F1"));
                Console.WriteLine("--------------------------");
            }
        }

        static void ListarAvaliacoes()
        {
            Console.Clear();
            Console.WriteLine("=== AVALIACOES DA UNIDADE CURRICULAR ===\n");
            Console.WriteLine("UC: " + poo.Titulo);
            Console.WriteLine("Codigo: " + poo.CodigoUC);
            Console.WriteLine("\nAvaliacoes configuradas:");
            Console.WriteLine("1. Teste (Peso: 30%)");
            Console.WriteLine("2. Projecto (Peso: 30%)");
            Console.WriteLine("3. Exame Final (Peso: 40%)");
            Console.WriteLine("\nNota Final = Teste*0.30 + Projecto*0.30 + Exame*0.40");
        }
    }
}