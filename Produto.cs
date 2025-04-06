using System;

namespace ControleDeProdutos
{
    class Produto
    {
        // Atributos privados
        private string nome = string.Empty;
        private double precoUnitario;
        private int quantidade;
        private double desconto;

        // Propriedades com encapsulamento e validação
        public string Nome
        {
            get => nome;
            set => nome = value != "" ? value : throw new ArgumentException("O nome não pode ser vazio.");
        }

        public double PrecoUnitario
        {
            get => precoUnitario;
            set => precoUnitario = value >= 0 ? value : throw new ArgumentException("O preço não pode ser negativo.");
        }

        public int Quantidade
        {
            get => quantidade;
            set => quantidade = value >= 0 ? value : throw new ArgumentException("A quantidade não pode ser negativa.");
        }

        public double Desconto
        {
            get => desconto;
            set => desconto = (value >= 0 && value <= 100) ? value : throw new ArgumentException("O desconto deve estar entre 0 e 100.");
        }

        // Construtor
        public Produto(string nome, double precoUnitario, int quantidade, double desconto)
        {
            Nome = nome;
            PrecoUnitario = precoUnitario;
            Quantidade = quantidade;
            Desconto = desconto;
        }

        // Método para calcular o custo total (sem desconto)
        public double CalcularCustoTotal()
        {
            return PrecoUnitario * Quantidade;
        }

        // Método para calcular o custo final com desconto, se aplicável
        public double CalcularCustoFinal()
        {
            double custoTotal = CalcularCustoTotal();

            if (custoTotal > 5000)
            {
                return custoTotal - (custoTotal * (Desconto / 100));
            }

            return custoTotal;
        }

        // Método para exibir os detalhes do produto
        public void ExibirDetalhes()
        {
            Console.WriteLine($"Produto: {Nome}");
            Console.WriteLine($"Preço Unitário: R${PrecoUnitario:F2}");
            Console.WriteLine($"Quantidade: {Quantidade}");
            Console.WriteLine($"Desconto: {Desconto}%");
            Console.WriteLine($"Custo Total: R${CalcularCustoTotal():F2}");
            Console.WriteLine($"Custo Final: R${CalcularCustoFinal():F2}");
            Console.WriteLine("---------------------------");
        }
    }
}
