namespace POONomina
{
    public class Trabajador{
        public string Nombre { get; set; }
        public string  PrimerApe { get; set; }
        public string SegundoApe { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public char  Sexo { get; set; }

        public void MostrarDatos(){
            Console.WriteLine($"{Nombre} {PrimerApe} {SegundoApe}\t {Sexo}\t {FechaNacimiento.ToShortDateString()} ");
        }
    }
}