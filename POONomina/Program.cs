// See https://aka.ms/new-console-template for more information

using POONomina;


//Generar 20 nominas de forma aleatoria
List<Nomina> nominas = new List<Nomina>();
Console.WriteLine("Número de nominas que desea genrear: ");
int numNominas = int.Parse(Console.ReadLine());
for (int i = 0; i < numNominas; i++)
{
    Nomina nomina = new Nomina();
    Generadora generadora = new Generadora(20,10,15);
    nomina.Empleos = generadora.Empleos;
    DateTime FechaActual = DateTime.Now;
    nomina.Fecha = FechaActual.AddDays(i*7);
    nominas.Add(nomina);
}

Console.WriteLine("===\t ==========\t ==============");
Console.WriteLine("NUM\t FECHA     \t TOTAL");
Console.WriteLine("===\t ==========\t ==============");
int j=1;

foreach (Nomina item in nominas)
{
    Console.WriteLine($"{j++}\t {item.Fecha.ToShortDateString()}\t $ {item.TotalDeNomina()}");
    Console.WriteLine("-----------------------------------------------------");
    Console.WriteLine($"\tNOMBRE          \t PUESTO        \t SALARIO");
    foreach (Empleo empleo in item.Empleos)
    {
        
        Console.WriteLine($"\t{empleo.Trabajador.Nombre} {empleo.Trabajador.PrimerApe}\t {empleo.PuestoLaboral.Nombre} \t {empleo.PuestoLaboral.Salario}");
    }
    Console.WriteLine();
    Console.WriteLine("-----------------------------------------------------");
}

Console.WriteLine("=====================================================");
Console.WriteLine($"MEDIA: $ {ObtenerMedia(nominas)}");
Console.WriteLine($"PROMEDIO: $ {nominas.Average(n=>n.TotalDeNomina())}");
Console.WriteLine($"SUMA DE LAS NOMINAS: $ {nominas.Sum(n=>n.TotalDeNomina())}");
Console.WriteLine("=====================================================");

static float ObtenerMedia(List<Nomina> nominas){
    float max = nominas.Max(n=>n.TotalDeNomina());
    float min = nominas.Min(n=>n.TotalDeNomina());;
    return ((max - min) / 2) + min;
}