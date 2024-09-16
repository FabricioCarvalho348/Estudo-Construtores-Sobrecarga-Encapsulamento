namespace Aula02.Encapsulamento;

class Program
{
    static void Main(string[] args)
    {
        Produto produtoUm = new Produto("TV", 500.00, 10);

        Console.WriteLine(produtoUm.Nome);
        Console.WriteLine(produtoUm.Preco);
        Console.WriteLine(produtoUm.Quantidade);

        // Implementação Get e Set criando métodos
        // produtoUm.GetNome();
        // produtoUm.SetNome("Rádio");

        // Sem Encapsulamento podemos alterar os atributos da classe.
        // produtoUm.Quantidade = 100;
    }
}