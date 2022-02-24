// See https://aka.ms/new-console-template for more information

using POONomina;

Trabajador t1 = new Trabajador();
Trabajador t2 = new Trabajador();

List<Trabajador> trabajadores = new List<Trabajador>();
trabajadores.Add(t1);
trabajadores.Add(t2);

Console.WriteLine("================================================");
Console.WriteLine($"Trabajadores en la lista: {trabajadores.Count}");
Console.WriteLine("================================================");

foreach (Trabajador item in trabajadores)
{
    item.MostrarDatos();
}

Nomina nomina = new Nomina();
Console.WriteLine("-------------------------------------------------");
Console.WriteLine($"Total de la nomina: {nomina.TotalDeNomina()}");
Console.WriteLine("-------------------------------------------------");