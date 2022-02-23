// See https://aka.ms/new-console-template for more information

using POONomina;

Trabajador t1 = new Trabajador();
t1.Nombre = "Jose";
t1.PrimerApe = "Garcia";
t1.SegundoApe = "Alvarez";
t1.FechaNacimiento = new DateTime(1981,05,26);
t1.Sexo = 'H';

Trabajador t2 = new Trabajador();
t2.Nombre = "Carlos";
t2.PrimerApe = "Garcia";
t2.SegundoApe = "Roque";
t1.FechaNacimiento = new DateTime(2000,03,11);
t2.Sexo = 'H';

Trabajador t3 = new Trabajador();
t3.Nombre = "Julia";
t3.PrimerApe = "Hernandez";
t3.SegundoApe = "Silva";
t3.FechaNacimiento = new DateTime(1995,10,17);
t3.Sexo = 'M';

Trabajador t4= new Trabajador();
t4.Nombre = "Sofia";
t4.PrimerApe = "Perez";
t4.SegundoApe = "Lavou";
t4.FechaNacimiento = new DateTime(1978,09,28);
t4.Sexo = 'M';


List<Trabajador> trabajadores = new List<Trabajador>();
trabajadores.Add(t1);
trabajadores.Add(t2);
trabajadores.Add(t3);
trabajadores.Add(t4);
Console.WriteLine("================================================");
Console.WriteLine($"Trabajadores en la lista: {trabajadores.Count}");
Console.WriteLine("================================================");

foreach (Trabajador item in trabajadores)
{
    item.MostrarDatos();
}
