// See https://aka.ms/new-console-template for more information
using Fundamentos.Models;

Bebida bebida = new Bebida("Coca Cola", 355);
bebida.Beberse(125);
Console.WriteLine(bebida.Nombre);
Console.WriteLine(bebida.Cantidad);

Cerveza cerveza = new Cerveza(350);
cerveza.Beberse(50);
Console.WriteLine(cerveza.Nombre);
Console.WriteLine(cerveza.Cantidad);

Console.WriteLine("----------------------------------------------------------------");

//Arrays
//Declarar un arreglo, al momento de declararlo se puede asignar valores
int [] numeros = new int[10] { 1,2,3,4,5,6,7,8,9,0};

//Obtener elementos del arreglo
int numeroInicial = numeros[0];
int numeroFinal = numeros[9];
Console.WriteLine(numeroInicial);
Console.WriteLine(numeroFinal);

Console.WriteLine("----------------------------------------------------------------");

//Recorrer el arreglo
Console.WriteLine("Recorrer el arreglo con un ciclo for");
for (int i = 0; i < numeros.Length; i++)
{
    Console.Write(numeros[i]);
}
Console.WriteLine();
Console.WriteLine();


Console.WriteLine();
Console.WriteLine("----------------------------------------------------------------");
//Recorrer el arreglo
Console.WriteLine("Recorrer el arreglo con un ciclo foreach");
foreach (int item in numeros)
{

        Console.Write(item);

}
Console.WriteLine();
Console.WriteLine();


Console.WriteLine();
Console.WriteLine("----------------------------------------------------------------");
List<int> lista = new List<int> { 1,2,3,4,5,6,7,8,9,0};
lista.Add(10);
lista.Add(11);
lista.Remove(2);

//Recorrer las lista con un foreach
Console.WriteLine("Recorrer la lista con un ciclo foreach");
foreach (var numero in lista)
{
    Console.Write($"{numero} , ");
}
Console.WriteLine();
Console.WriteLine();

//Listas de clases

List<Cerveza> cervezas = new List<Cerveza>() {new Cerveza(80, "Cerveza Premium")};
cervezas.Add(new Cerveza(300));

Cerveza erdinger = new Cerveza(500, "Cerveza de Trigo");
cervezas.Add(erdinger);


Console.WriteLine();
Console.WriteLine("----------------------------------------------------------------");

//Recorrer las lista con un foreach
Console.WriteLine("Recorrer la lista con un ciclo foreach");
foreach (var cheve in cervezas)
{
    Console.WriteLine($"Cerveza: {cheve.Nombre} de {cheve.Cantidad} ml.");
}