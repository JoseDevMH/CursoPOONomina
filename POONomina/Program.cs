// See https://aka.ms/new-console-template for more information

using POONomina;

List<Trabajador> trabajadores = new List<Trabajador>();
Trabajador t1 = new Trabajador();
Trabajador t2 = new Trabajador();

trabajadores.Add(t1);
trabajadores.Add(t2);

for (int i = 0; i < 2; i++)
{
    trabajadores.Add(new Trabajador());
}

Console.WriteLine("\n\n DATOS DE LOS TRABAJADORES");

foreach (Trabajador item in trabajadores)
{
    item.MostrarDatos();
}