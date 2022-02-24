namespace POONomina {
    public class Empleo {
        public Trabajador Trabajador { get; set; }
        public PuestoLaboral PuestoLaboral { get; set; }
        public DateTime FechaDeContratacion { get; set; }
        public int NumeroDeContrato { get; set; }

        private Random r;

        public Empleo(Trabajador trabajador, PuestoLaboral puesto)
        {
            r=new Random(DateTime.Now.Second);
            this.Trabajador = trabajador;
            this.PuestoLaboral = puesto;
            this.FechaDeContratacion = DateTime.Now;
            this.NumeroDeContrato = r.Next(2000,5000);
        }
    }
}
