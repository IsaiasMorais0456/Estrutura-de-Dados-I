using System.Globalization;
using System.Runtime.CompilerServices;

Console.WriteLine(
    "Olá, Mundo!"
);

Console.WriteLine(
    ""
);

Console.WriteLine(
    "Informe seu nome:"
);


//? Operador nullable 
// indica que a variável pode ser nula
String? name = Console.ReadLine();
Console.WriteLine(
    $"Olá, Seja bem-vindo {name}!"
);

//declarando vetor
//sem inicialização
int[] numbers;

//iniciazando vetor
numbers = new int[5];
int[] numbers2 = new int[5];

//Atribuindo valores ao vetor

numbers2[0] = 1;
numbers2[1] = 2;
numbers2[2] = 3;
numbers2[3] = 4;
numbers2[4] = 5;

//declarando e inicializando com valores

int[] numbers3 = new int[] { 1, 2, 3, 4, 5 };

//simpificada

int[] numbers4 = { 1, 2, 3, 4, 5 };

//preenchendo um vetor com os 12 meses do ano

string[] months = new string[12];
for (int i = 1; i < 12; i++){
    DateTime FirstDay = new DateTime(DateTime.Now.Year, i, 1); 
    string MonthName = FirstDay.ToString("MMMM", CultureInfo.CreateSpecificCulture("En")); 
    months[i - 1] = MonthName;

}

foreach(var month in months){
    Console.WriteLine(month);
}


// 2 dimensões 

int[,] numbers52 = new int[5, 2];

int[,,] numbers543 = new int[5, 4, 3];

//Inicializando matriz valorada

int[,] nmb = new int[,] {
    {1 , 2, -9},
    {3, 4, 5  },
    {6, 7, 54 }
};

int myNumber = nmb[2, 1]; //acessando o valor 7

Console.WriteLine($"O número é: {myNumber}");