// See https://aka.ms/new-console-template for more information
using Fundamentos.Models;

Bebida bebida = new Bebida("Coca Cola", 355);
bebida.Beberse(125);
Console.WriteLine(bebida.Cantidad);

Cerveza cerveza = new Cerveza("Indio", 200);
cerveza.Beberse(50);
