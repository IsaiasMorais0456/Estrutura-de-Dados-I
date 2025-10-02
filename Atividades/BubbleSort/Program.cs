// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ordenação com Bubble Sort");

string[] Letras = new string[]{
   "I", "J", "A", "C", "B", "E", "H", "G", "F", "D"
};

BubbleSort.BubbleSortOrder.Sort(Letras);

foreach (var letra in Letras) 
{
    Console.Write($"[{letra}] ");
}

