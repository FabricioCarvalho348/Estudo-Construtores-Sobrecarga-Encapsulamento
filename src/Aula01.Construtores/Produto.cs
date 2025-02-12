﻿using System.Globalization;

namespace Aula01.Construtores;

public class Produto
{
    public string Nome;
    public double Preco;
    public int Quantidade;

    public Produto()
    {
    }
    
    public Produto(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }
    
    public Produto(string nome, double preco, int quantidade)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }

    // UTILIZAÇÃO DO THIS
    // public Produto(string nome, double preco, int quantidade) : this(nome, preco)
    // {
    //     Quantidade = quantidade;
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