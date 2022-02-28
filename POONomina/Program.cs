// See https://aka.ms/new-console-template for more information

using POONomina;


//Generar 20 nominas de forma aleatoria
List<Nomina> nominas = new List<Nomina>();
for (int i = 0; i < 20; i++)
{
    Nomina nomina = new Nomina();
    Generadora generadora = new Generadora(20,10,15);
    nomina.Empleos = generadora.Empleos;
    DateTime FechaActual = DateTime.Now;
    nomina.Fecha = FechaActual.AddDays(1*7);
    nominas.Add(nomina);
}

