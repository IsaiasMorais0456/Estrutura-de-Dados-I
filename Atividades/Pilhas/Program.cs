using System.Collections.Generic;

Console.WriteLine("Descobrindo se a palavra é um palíndromo");

Stack<char> chars = new Stack<char>();

Console.Write("Digite uma palavra: ");
string palavra = Console.ReadLine() ?? "";
string palavramudada = "";

foreach (char c in palavra)
{
    chars.Push(c);
    palavramudada += c;
}
foreach (char c in palavra)
{
    palavramudada += chars.Pop();
    palavramudada = palavramudada.Remove(0, 1);
}
while (chars.Count > 0)
    {
        Console.WriteLine(chars.Pop());
    }

if (palavra == palavramudada) // Verifica se a palavra é igual à palavra invertida
{
    Console.WriteLine(palavramudada);
    Console.WriteLine("A palavra é um palíndromo");
}
else
{
    Console.WriteLine(palavramudada);
    Console.WriteLine("A palavra não é um palíndromo");
}