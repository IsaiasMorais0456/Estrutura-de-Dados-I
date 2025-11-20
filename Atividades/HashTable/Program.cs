using System.Collections;
// Dictionary dic = new Dictionary();


/*
    A tabela Hash é naseada mo conceito de par chave - valor a chave é da mesma 
    forma de se acessar o respectivo valor e spor ser chave deve ser unica

*/
Hashtable hashtable = new Hashtable()
{
    {"Isaias Morais", "123"}, {"Eduarda Huber", "456"}
};

// Uma forma de adicionar um novo par 

hashtable["Jusé Augusto"] = "789";

hashtable.Add("Mauro Silva", "666");

// verificar se existem pares chave-valor na tabela hash

if (hashtable.Count > 0)
{
    // Percorrer os pares armazenados
    foreach (DictionaryEntry entry in hashtable)
    {
        Console.WriteLine($"Chave: {entry.Key}, Valor: {entry.Value}");
    }
}
else
{
    Console.WriteLine("A tabela hash está vazia");
}

// Vimos que ao adicionar uma chave repetida ao hashtable o programa crasha e interrompe a execução.
// para evitar este comportamento, fazemos o uso da cláusula try{} catch{}


try
{
    hashtable.Add("Isaias Morais", "123");
}
catch (ArgumentException ae)
{
    Console.WriteLine("Não é possível adicionar chaves iguais.");
    // Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Erro Desconhecido.");
}
finally
{
    Console.WriteLine("Agora vai, segue em frente");
}

Console.WriteLine("Informe a chave");
string key = Console.ReadLine()!;
Console.WriteLine("Informe o valor");
string value = Console.ReadLine()!;

try
{
    hashtable.Add(key, value);
    Console.WriteLine("Par chave-valor adicionado!");
}
catch
{
    Console.WriteLine("Ops, Chave já existente");
}

Console.WriteLine("O que procura Cabrón?");
string search = Console.ReadLine()!;


if (hashtable.ContainsKey(search))
{
    Console.WriteLine($"Achei! O valor para a chave {search} é {hashtable[search]}");
}
else
{
    Console.WriteLine("Não achei não mermão");
}


/* uma empresa de entregas de logística precisa gerenciar os códigos das etiquetas de entrega para cada pacote de produto 
em seu respectivo código de barras. Observe que a chave é o código de rastreio e o valor é o código de barras da 
encomenda. 

Escreva um produto que armazene em um dicionário ou uma quantidade x de informações referentes ao rastreio e ao pacote
permitindo ao usuário inseri-las em tempo de execução. Tome cuidado para que o Sistema informe quando houver lançamentos repetidos e não ocasionar 
erros inesperados. Em seguida forneça um recurso para que o usuáro possa procurar tanto por código de rastreio quanto por
código da encomenda e de um retorno amigável e informativo ao usuário.

*/



Dictionary<string, string> logistics = new Dictionary<string, string>();

