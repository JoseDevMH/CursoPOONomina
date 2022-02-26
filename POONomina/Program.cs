// See https://aka.ms/new-console-template for more information

using POONomina;

Random r = new Random();
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

List<PuestoLaboral> puestos = new List<PuestoLaboral>();

for (int i = 0; i < 4; i++)
{
    puestos.Add(new PuestoLaboral(r));
}

foreach (PuestoLaboral item in puestos)
{
    Console.WriteLine(item.DescribirPuesto());
}