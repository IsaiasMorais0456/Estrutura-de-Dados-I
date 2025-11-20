using System;
using System.Collections;

/* uma empresa de entregas de logística precisa gerenciar os códigos das etiquetas de entrega para cada pacote de produto 
em seu respectivo código de barras. Observe que a chave é o código de rastreio e o valor é o código de barras da 
encomenda. 

Escreva um produto que armazene em um dicionário ou uma quantidade x de informações referentes ao rastreio e ao pacote
permitindo ao usuário inseri-las em tempo de execução. Tome cuidado para que o Sistema informe quando houver lançamentos repetidos e não ocasionar 
erros inesperados. Em seguida forneça um recurso para que o usuáro possa procurar tanto por código de rastreio quanto por
código da encomenda e de um retorno amigável e informativo ao usuário.

*/

public class GerenciadorEtiquetas
{
    private Dictionary<string, string> _etiquetas;

    public GerenciadorEtiquetas()
    {
        _etiquetas = new Dictionary<string, string>();
    }

    public void AdicionarEtiqueta(string rastreio, string codigoBarras)
    {
        try
        {
            _etiquetas.Add(rastreio, codigoBarras);
            Console.WriteLine("Etiqueta adicionada com sucesso!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Erro: Código de rastreio já existe.");
        }
        finally
        {
            Console.WriteLine("Operação de adição concluída.");
        }
    }
    public void ProcurarEtiqueta(string rastreio)
    {
        if (_etiquetas.ContainsKey(rastreio))
        {
            Console.WriteLine($"Código de barras para o rastreio {rastreio}: {_etiquetas[rastreio]}");
        }
        else
        {
            Console.WriteLine("Etiqueta não encontrada.");
        }
    }

    public class program
    {
        static void Main(string[] args)
        {
            GerenciadorEtiquetas gerenciador = new GerenciadorEtiquetas();
            while (true)
            {
                Console.WriteLine("Informe o código de rastreio:");
                string rastreio = Console.ReadLine()!;
                Console.WriteLine("Informe o código de barras da encomenda:");
                string codigoBarras = Console.ReadLine()!;

                gerenciador.AdicionarEtiqueta(rastreio, codigoBarras);

                Console.WriteLine("Deseja adicionar outro par? (s/n)");
                string resposta = Console.ReadLine()!.ToLower();
                if (resposta != "s")
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
            while (true)
            {
                Console.WriteLine("Insira o código de rastreio que deseja procurar:");
                string searchRastreio = Console.ReadLine()!;

                gerenciador.ProcurarEtiqueta(searchRastreio);

                Console.WriteLine("Deseja fazer outra busca? (s/n)");
                string resposta = Console.ReadLine()!.ToLower();

                if (resposta == "s")
                {
                    continue; // volta ao começo para adicionar outro par
                }
                else
                {
                    break; // sai do laço
                }

            }   
        }
    }
}

