using System;

namespace Aula16Construtor
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto tenis = new Produto("Yeezy boost 350", 587412, 100, 500, "Cor cinza, Tamanho 41");

           System.Console.WriteLine($"Nome do produto: {tenis.Nome}");
           System.Console.WriteLine($"Codigo do produto: {tenis.Codigo}");
           System.Console.WriteLine($"Quantidade no estoque: {tenis.Estoque}");
           System.Console.WriteLine($"Preço do produto: {tenis.Preco}");
           System.Console.WriteLine($"Descrição do produto: {tenis.Descricao}");
        }
    }
}
