// See https://aka.ms/new-console-template for more information

using POONomina;

Console.WriteLine("Hello, World!");

Trabajador t1 = new Trabajador();
t1.Nombre = "Jose";
t1.PrimerApe = "Garcia";
t1.SegundoApe = "Alvarez";
t1.FechaNacimiento = new DateTime(1981,05,26);
t1.Sexo = 'H';

Trabajador t2 = new Trabajador();
t2.Nombre = "Juan Carlos";
t2.PrimerApe = "Garcia";
t2.SegundoApe = "Roque";
t2.Sexo = 'H';

MostrarTrabajador(t1);

void MostrarTrabajador(Trabajador trabajador)
{
    Console.WriteLine($"{t1.Nombre} {t1.PrimerApe} {t1.SegundoApe} {t1.FechaNacimiento.ToShortDateString()}");
}