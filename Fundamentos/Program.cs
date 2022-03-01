// See https://aka.ms/new-console-template for more information
using Fundamentos.Models;

Bebida bebida = new Bebida("Coca Cola", 355);
bebida.Beberse(125);
Console.WriteLine(bebida.Nombre);
Console.WriteLine(bebida.Cantidad);

Cerveza cerveza = new Cerveza();
cerveza.Beberse(50);
Console.WriteLine(cerveza.Nombre);
Console.WriteLine(cerveza.Cantidad);
