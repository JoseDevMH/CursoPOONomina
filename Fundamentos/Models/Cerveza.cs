using Fundamentos.Models;
public class Cerveza : Bebida
{
    public Cerveza() : base("Cervezas", 500)
    {

    }

    public Cerveza(string Nombre, int Cantidad) : base(Nombre, Cantidad)
    {
    }
}
