using Fundamentos.Models;
public class Cerveza : Bebida
{
    //al crear un construtor se pueden pasar datos opcionales, estos deben ir despues de los datos obligatorios
    //EL constructor de Cerveza es obligatorio la cantidad y opcional el nombre
    //Y si aplica esto los argumentos que recibe no necesariamente deben ir en orden.
    public Cerveza(int Cantidad, string Nombre = "Cerveza")
        : base(Nombre, Cantidad)
    {
        
    }
}
