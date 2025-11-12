using QuickSortModel;
int[] integerValues = { 11, 12, -42, 0, 1, 90, 68, 6, 9 };


QuickSort.Sort(integerValues);

Console.WriteLine("Vetor de Inteiros");
Console.WriteLine(string.Join(", ", integerValues));
Console.WriteLine("*******************");

string[] stringValues = { "Manoel Gomes", "Hitler", "Tais Carla", "Marcão Bolado", "João Mamão", "Sigma Isaias" };

QuickSort.Sort(stringValues);
Console.WriteLine(string.Join(", ", stringValues));