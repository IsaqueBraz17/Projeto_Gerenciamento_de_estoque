using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProgramaçãoOrientadaObjetos_02
{
    // Classe Program, que contém o método Main para executar o programa
    internal class Program
    {
        // Método principal que é executado quando o programa começa
        static void Main(string[] args)
        {
            // Cria um objeto 'p' da classe Produto
            Produto p = new Produto();

            // Solicita ao usuário os dados do produto
            Console.WriteLine("Entre os dados do produto:");

            // Lê o nome do produto fornecido pelo usuário
            Console.WriteLine("Nome: ");
            p.Nome = Console.ReadLine(); // Atribui o nome lido à propriedade Nome

            // Lê o preço do produto fornecido pelo usuário e converte para double
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Converte para double, com cultura invariável para lidar com ponto como separador decimal

            // Lê a quantidade do produto no estoque fornecida pelo usuário e converte para inteiro
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Converte para int, sem afetar a cultura

            // Exibe os dados do produto no formato personalizado (via ToString)
            Console.WriteLine("Dados do Produto: " + p);

            Console.WriteLine(); // Quebra de linha para melhor visualização

            // Solicita ao usuário o número de produtos a serem adicionados ao estoque
            Console.Write("Digite o número de produtos a ser adicionados no estoque: ");
            int qte = int.Parse(Console.ReadLine()); // Lê a quantidade e converte para inteiro
            p.AdicionarProdutos(qte); // Chama o método AdicionarProdutos para atualizar a quantidade no estoque

            Console.WriteLine(); // Quebra de linha

            // Exibe os dados atualizados do produto após a adição
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine(); // Quebra de linha

            // Solicita ao usuário o número de produtos a serem removidos do estoque
            Console.Write("Digite o número de produtos a ser removidos do estoque: ");
            qte = int.Parse(Console.ReadLine()); // Lê a quantidade e converte para inteiro
            p.RemoverProdutos(qte); // Chama o método RemoverProdutos para atualizar a quantidade no estoque

            Console.WriteLine(); // Quebra de linha

            // Exibe os dados atualizados do produto após a remoção
            Console.WriteLine("Dados atualizados: " + p);

            Console.ReadLine(); // Aguarda o usuário pressionar uma tecla para encerrar o programa
        }
    }
}

