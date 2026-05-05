using System;
using System.Collections.Generic;

namespace AluguerAutomoveis
{
    class Program
    {
        // Lista para guardar os veículos
        static List<Veiculo> garagem = new List<Veiculo>();

        static void Main(string[] args)
        {
            
            Veiculo carro1 = new Veiculo("ZJ-12-3´4-BB", "Toyota", "Corolla", 2022, 15000);
            Veiculo carro2 = new Veiculo("BB-56-78-AO", "MITSUBISHI", "L200", 2021, 22000);
            Veiculo carro3 = new Veiculo("CC-90-12-CD", "HIUNDAY", "I10", 2023, 5000);

            garagem.Add(carro1);
            garagem.Add(carro2);
            garagem.Add(carro3);

            int escolha;

            do
            {
                Console.Clear();
                Console.WriteLine("=== SISTEMA DE ALUGUER DE AUTOMOVEIS ===");
                Console.WriteLine("1 - Registrar novo veiculo");
                Console.WriteLine("2 - Atualizar quilometragem");
                Console.WriteLine("3 - Apresentar dados de um veiculo");
                Console.WriteLine("4 - Listar todos os veiculos");
                Console.WriteLine("5 - Demonstracao do sistema");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opcao: ");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        RegistrarVeiculo();
                        break;
                    case 2:
                        AtualizarQuilometragem();
                        break;
                    case 3:
                        ApresentarVeiculo();
                        break;
                    case 4:
                        ListarTodos();
                        break;
                    case 5:
                        Demonstracao();
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

        static void RegistrarVeiculo()
        {
            Console.Clear();
            Console.WriteLine("=== REGISTAR NOVO VEICULO ===\n");

            Console.Write("Placa: ");
            string novaPlaca = Console.ReadLine();

            Console.Write("Fabricante: ");
            string novoFabricante = Console.ReadLine();

            Console.Write("Tipo: ");
            string novoTipo = Console.ReadLine();

            Console.Write("Ano de fabrico: ");
            int novoAno = int.Parse(Console.ReadLine());

            Console.Write("Quilometragem atual: ");
            double novaKms = double.Parse(Console.ReadLine());

            Veiculo novoCarro = new Veiculo(novaPlaca, novoFabricante, novoTipo, novoAno, novaKms);
            garagem.Add(novoCarro);

            Console.WriteLine("\nVeiculo registado com sucesso!");
        }

        static void AtualizarQuilometragem()
        {
            Console.Clear();
            Console.WriteLine("=== ATUALIZAR QUILOMETRAGEM ===\n");

            if (garagem.Count == 0)
            {
                Console.WriteLine("Nao ha veiculos na garagem!");
                return;
            }

            
            for (int indice = 0; indice < garagem.Count; indice++)
            {
                Console.WriteLine((indice + 1) + " - " + garagem[indice].Placa + " | " +
                                  garagem[indice].Fabricante + " " + garagem[indice].Tipo);
            }

            Console.Write("\nDigite a placa do veiculo: ");
            string placaBusca = Console.ReadLine();

            Veiculo encontrado = null;

            for (int indice = 0; indice < garagem.Count; indice++)
            {
                if (garagem[indice].Placa == placaBusca)
                {
                    encontrado = garagem[indice];
                }
            }

            if (encontrado != null)
            {
                Console.Write("Quilometros percorridos: ");
                double kmsPercorridos = double.Parse(Console.ReadLine());
                encontrado.ActualizarQuilometragem(kmsPercorridos);
            }
            else
            {
                Console.WriteLine("Veiculo nao encontrado!");
            }
        }

        static void ApresentarVeiculo()
        {
            Console.Clear();
            Console.WriteLine("APRESENTAR DADOS DO VEICULO\n");

            if (garagem.Count == 0)
            {
                Console.WriteLine("Nao ha veiculos na garagem!");
                return;
            }

            
            for (int indice = 0; indice < garagem.Count; indice++)
            {
                Console.WriteLine((indice + 1) + " - " + garagem[indice].Placa + " | " +
                                  garagem[indice].Fabricante + " " + garagem[indice].Tipo);
            }

            Console.Write("\nDigite a placa do veiculo: ");
            string placaBusca = Console.ReadLine();

            Veiculo encontrado = null;

            
            for (int indice = 0; indice < garagem.Count; indice++)
            {
                if (garagem[indice].Placa == placaBusca)
                {
                    encontrado = garagem[indice];
                }
            }

            if (encontrado != null)
            {
                encontrado.ApresentarDados();
            }
            else
            {
                Console.WriteLine("Veiculo nao encontrado!");
            }
        }

        static void ListarTodos()
        {
            Console.Clear();
            Console.WriteLine("=== TODOS OS VEICULOS ===\n");

            if (garagem.Count == 0)
            {
                Console.WriteLine("Nao ha veiculos na garagem!");
            }
            else
            {
                for (int indice = 0; indice < garagem.Count; indice++)
                {
                    garagem[indice].ApresentarDados();
                }
            }
        }

        static void Demonstracao()
        {
            Console.Clear();
            Console.WriteLine("=== DEMONSTRACAO DO SISTEMA ===\n");

            Console.WriteLine("--- 3 OBJETOS INSTANCIADOS ---");
            for (int indice = 0; indice < garagem.Count; indice++)
            {
                garagem[indice].ApresentarDados();
            }

            Console.WriteLine("\n--- ATUALIZANDO QUILOMETRAGEM ---");
            Console.WriteLine("Veiculo AA-12-34 andou 150 km:");
            garagem[0].ActualizarQuilometragem(150);

            Console.WriteLine("\nVeiculo BB-56-78 andou 320 km:");
            garagem[1].ActualizarQuilometragem(320);

            Console.WriteLine("\n--- DADOS APOS ALUGUERES ---");
            garagem[0].ApresentarDados();
            garagem[1].ApresentarDados();
        }
    }
}