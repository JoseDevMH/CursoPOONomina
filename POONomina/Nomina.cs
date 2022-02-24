namespace POONomina {
    public class Nomina{
        public List<Empleo> Empleos { get; set; }
        public DateTime Fecha { get; set; }

        public Nomina(){
            Empleos= new List<Empleo>();
        }
        public float TotalDeNomina()
        {
            float total=0;
            foreach (Empleo item in Empleos)
            {
                total+=item.PuestoLaboral.Salario;
            }
            return total;
        }
    }
}