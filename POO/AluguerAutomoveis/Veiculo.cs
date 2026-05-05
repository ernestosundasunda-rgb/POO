using System;
using System.Collections.Generic;
using System.Text;

namespace AluguerAutomoveis
{
    public class Veiculo
    {
        // Atributos privados
        private string placa;
        private string fabricante;
        private string tipo;
        private int anoFabrico;
        private double kmsRodados;

        // Construtor sem parâmetros
        public Veiculo()
        {
            placa = "";
            fabricante = "";
            tipo = "";
            anoFabrico = 0;
            kmsRodados = 0;
        }

        // Construtor parametrizado
        public Veiculo(string placa, string fabricante, string tipo,
                       int anoFabrico, double kmsRodados)
        {
            this.placa = placa;
            this.fabricante = fabricante;
            this.tipo = tipo;
            this.anoFabrico = anoFabrico;
            this.kmsRodados = kmsRodados;
        }

        // Propriedade Placa
        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        // Propriedade Fabricante
        public string Fabricante
        {
            get { return fabricante; }
            set { fabricante = value; }
        }

        // Propriedade Tipo
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        // Propriedade AnoFabrico
        public int AnoFabrico
        {
            get { return anoFabrico; }
            set { anoFabrico = value; }
        }

        // Propriedade KmsRodados
        public double KmsRodados
        {
            get { return kmsRodados; }
            set { kmsRodados = value; }
        }

        // Método para atualizar quilometragem
        public void ActualizarQuilometragem(double kms)
        {
            if (kms > 0)
            {
                kmsRodados = kmsRodados + kms;
                Console.WriteLine("Quilometragem atualizada com sucesso!");
            }
            else
            {
                Console.WriteLine("Erro: Os quilometros devem ser positivos!");
            }
        }

        // Método para apresentar dados
        public void ApresentarDados()
        {
            Console.WriteLine("--- DADOS DO VEICULO ---");
            Console.WriteLine("Placa: " + placa);
            Console.WriteLine("Fabricante: " + fabricante);
            Console.WriteLine("Tipo: " + tipo);
            Console.WriteLine("Ano de Fabrico: " + anoFabrico);
            Console.WriteLine("Quilometragem: " + kmsRodados + " km");
            Console.WriteLine("------------------------");
        }
    }
}
