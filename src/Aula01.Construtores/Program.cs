using System.Globalization;

namespace Aula01.Construtores;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entre os dados do produto:");
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        
        Console.Write("Preço: ");
        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        Console.Write("Quantidade no estoque: ");
        int quantidade = int.Parse(Console.ReadLine());

        Produto produtoUm = new Produto();
        
        
        Produto produtoDois = new Produto(nome, preco);
        
        
        Produto produtoTres = new Produto(nome, preco, quantidade);
        
        Produto produtoQuatro = new Produto
        {
            Nome = "TV",
            Preco = 500.00,
            Quantidade = 20
        };
        
        
        Console.WriteLine();
        Console.WriteLine("Dados do produto: " + produtoUm);
        
        Console.WriteLine();
        Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
        
        int qte = int.Parse(Console.ReadLine());
        produtoUm.AdicionarProdutos(qte);
        
        Console.WriteLine();
        Console.WriteLine("Dados atualizados: " + produtoUm);
        
        Console.WriteLine();
        Console.Write("Digite o número de produtos a ser removido do estoque: ");
        qte = int.Parse(Console.ReadLine());
        
        produtoUm.RemoverProdutos(qte);
        
        Console.WriteLine();
        Console.WriteLine("Dados atualizados: " + produtoUm);
    }
}