namespace POONomina
{
    public class Trabajador{
        public string Nombre { get; set; }
        public string  PrimerApe { get; set; }
        public string SegundoApe { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public char  Sexo { get; set; }

        public Trabajador(string nombre, string primerApellido, string segundoApellido, DateTime fechaDeNacimiento, Char sexo){
            this.Nombre = nombre;
            this.PrimerApe = primerApellido;
            this.SegundoApe = segundoApellido;
            this.FechaNacimiento = fechaDeNacimiento;
            this.Sexo = sexo;
        }

        public Trabajador(){
            Console.Write("Nombre: ");
            this.Nombre=Console.ReadLine();

            Console.Write("Primer apellido: ");
            this.PrimerApe=Console.ReadLine();

            Console.Write("Segundo apellido: ");
            this.SegundoApe=Console.ReadLine();

            Console.Write("Año de nacimiento: ");
            int anio=int.Parse(Console.ReadLine());

            Console.Write("Mes de nacimiento: ");
            int mes=int.Parse(Console.ReadLine());

            Console.Write("Día de nacimiento: ");
            int dia=int.Parse(Console.ReadLine());

            this.FechaNacimiento = new DateTime(anio, mes, dia);

            Console.Write("Sexo [H/M]: ");
            this.Sexo = char.Parse(Console.ReadLine());
        }

        public void MostrarDatos(){
            Console.WriteLine($"{Nombre} {PrimerApe} {SegundoApe}\t {Sexo}\t {FechaNacimiento.ToShortDateString()} ");
        }
    }
}