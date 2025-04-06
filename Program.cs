using System;

namespace ControleDeProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada de dados para o primeiro produto
            Console.WriteLine("Informe os dados do primeiro produto:");
            Produto produto1 = CriarProduto();

            // Entrada de dados para o segundo produto
            Console.WriteLine("\nInforme os dados do segundo produto:");
            Produto produto2 = CriarProduto();

            // Exibição dos detalhes
            Console.WriteLine("\n=== DETALHES DOS PRODUTOS ===\n");
            produto1.ExibirDetalhes();
            produto2.ExibirDetalhes();

            // Comparação dos custos finais
            double custoFinal1 = produto1.CalcularCustoFinal();
            double custoFinal2 = produto2.CalcularCustoFinal();

            if (custoFinal1 > custoFinal2)
            {
                Console.WriteLine("O produto 1 tem o maior custo final.");
            }
            else if (custoFinal2 > custoFinal1)
            {
                Console.WriteLine("O produto 2 tem o maior custo final.");
            }
            else
            {
                Console.WriteLine("Ambos os produtos têm o mesmo custo final.");
            }
        }

        // Método auxiliar para criar um produto com entrada de dados
        static Produto CriarProduto()
        {
            Console.Write("Nome do produto: ");
            string nome = Console.ReadLine() ?? throw new ArgumentException("O nome não pode ser nulo.");

            Console.Write("Preço unitário: R$ ");
            double preco = double.Parse(Console.ReadLine() ?? throw new ArgumentException("O preço não pode ser nulo."));

            Console.Write("Quantidade em estoque: ");
            int quantidade = int.Parse(Console.ReadLine() ?? throw new ArgumentException("A quantidade não pode ser nula."));

            Console.Write("Desconto percentual: ");
            double desconto = double.Parse(Console.ReadLine() ?? throw new ArgumentException("O desconto não pode ser nulo."));

            return new Produto(nome, preco, quantidade, desconto);
        }
    }
}
