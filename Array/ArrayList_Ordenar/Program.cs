using System.Collections;

var lista = new ArrayList() { "A", "C", "D", "B", "E" };

foreach (var item in lista)
{
    Console.Write($"{item}");
}

Console.WriteLine("\nNumero do array antes do clear:\n" + lista.Count);
lista.Clear();
Console.WriteLine("\nNumero do array depois do clar:" + lista.Count);

Console.WriteLine("\nOrdenado");
foreach (var item in lista)
{
    Console.Write($"{item}");
}


Console.ReadKey();