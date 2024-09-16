using System.Globalization;

namespace Aula02.Encapsulamento;

public class Produto
{
    // Auto Properties
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Quantidade { get; set; }

    public Produto()
    {
    }

    public Produto(string nome, double preco, int quantidade)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }

    // Propriedades implementadas
    // public string Nome
    // {
    //     get { return _nome; }
    //     set
    //     {
    //         if (value != null && value.Length > 1)
    //         {
    //             _nome = value;
    //         }
    //     }
    // }
    //
    // public double Preco
    // {
    //     get { return _preco; }
    // }
    //
    // public int Quantidade
    // {
    //     get { return _quantidade; }
    // }
    
    // Getters e Setters implementados
    // public string GetNome()
    // {
    //     return _nome;
    // }
    //
    // public void SetNome(string nome)
    // {
    //     if (nome != null && nome.Length > 1)
    //     {
    //         _nome = nome;
    //     }
    // }
    //
    // public double GetPreco()
    // {
    //     return _preco;
    // }
    
    public double ValorTotalEmEstoque() {
        return Preco * Quantidade;
    }
    public void AdicionarProdutos(int quantidade) {
        Quantidade += quantidade;
    }
    public void RemoverProdutos(int quantidade) {
        Quantidade -= quantidade;
    }
    public override string ToString() {
        return Nome
               + ", $ "
               + Preco.ToString("F2", CultureInfo.InvariantCulture)
               + ", "
               + Quantidade
               + " unidades, Total: $ "
               + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
    }
}