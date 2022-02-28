namespace POONomina {
    public class Generadora {
        Random r;
        public List<Empleo> Empleos {get; set;}
        public Generadora(int numEmpleados, int numPuestos, int numEmpleos)
        {
            r = new Random();
            List<string> nombres = new List<string>();
            nombres.Add("JOSE");
            nombres.Add("MARIA");
            nombres.Add("HEBER");
            nombres.Add("MATIAS");
            nombres.Add("EMMANUEL");

            List<string> apellidos = new List<string>();
            apellidos.Add("GARCIA");
            apellidos.Add("ALVAREZ");
            apellidos.Add("QUINTANILLA");
            apellidos.Add("GRANADO");
            apellidos.Add("ARREDONDO");
            apellidos.Add("ACOSTA");
            apellidos.Add("RANGEL");
            apellidos.Add("CHIQUITO");
            apellidos.Add("PEREZ");

            List<Trabajador> trabajadores = new List<Trabajador>();
            for (int i = 0; i < numEmpleados; i++)
            {
                trabajadores.Add(new Trabajador(nombres[r.Next(0, nombres.Count - 1)], apellidos[r.Next(0, apellidos.Count-1)], apellidos[r.Next(0, apellidos.Count-1)], new DateTime(r.Next(1980, 2022), r.Next(1, 12), r.Next(1, 29)), SexoAleatorio()));
            }

            List<PuestoLaboral> puestos = new List<PuestoLaboral>();
            for (int i = 0; i < numPuestos; i++)
            {
                puestos.Add(new PuestoLaboral(r));
            }

            Empleos = new List<Empleo>();
            for (int i = 0; i < numEmpleos; i++)
            {
                Empleos.Add(new Empleo(trabajadores[r.Next(0,trabajadores.Count-1)], puestos[r.Next(0, puestos.Count-1)], r));
            }

        }
        private char SexoAleatorio()
        {
            if(r.NextDouble()>0.5)
            {
                return 'H';
            }
            else
            {
                return 'M';
            }
        }
    }
}