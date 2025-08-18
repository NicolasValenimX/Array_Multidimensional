using System.Runtime.InteropServices;
//declare e aloque na memoria um array de strings chamado alunos com 2 linhas e 5 colunas e a seguir realize estas operações

//-inicializar um array com dados referente aos nomes dos alunos recebidos via teclado informando o indice da linha e coluna de cada elemento de que esta sendo recebido;
//-Exibir no console os dados informados no array bem com o indice da linha e da coluna de cada elemento;

//Usar nomes dos alunos para seguir respetitando a ordem indiciada:
//-Maria, Paulo, Marta, Pedro, Carlos,
//- Silvia, Amanda, Manoel, Puala, Alicia.


//Delcrando e alocando memoria.
string[,] alunos = new string[2, 5]; //Alunnos [i, j]

Console.WriteLine("\nAtribuindo nome do alunos em duas linhas e 5 colunas\n");

Console.WriteLine("{Maria, Paulo, Marta, Pedro, Carlos}");
Console.WriteLine("{Silvia, Pedro, Alicia, Manoel, Paula}\n");

for (int i = 0; i < alunos.GetLength(0); i++)
{
    for (int j = 0; j < alunos.GetLength(1); j++)
    {
        Console.WriteLine($"Informe o valor para o elemento na posição [{i}, {j}]");
        alunos[i, j] = Console.ReadLine();
    }
}

Console.WriteLine("\nConteudo do Array alunos: ");

for (int i = 0; i < alunos.GetLength(0); i++)
{
    for (int j = 0; j < alunos.GetLength(1); j++)
    {
        Console.Write($"[{i}, {j}] = {alunos[i, j]}\t ");
    }
    Console.WriteLine();
}

Console.ReadKey();
