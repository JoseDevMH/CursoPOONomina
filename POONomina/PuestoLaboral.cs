namespace POONomina
{
    public class PuestoLaboral{
        List<string> puestos;
        Random r;
        public string Nombre { get; set; }
        public float  Salario { get; set; }
        public bool EsDeBase { get; set; }

    public PuestoLaboral(Random r)
    {
        puestos = new List<string>();
        this.r = r;
        puestos.Add("Gerente");
        puestos.Add("Subgerente");
        puestos.Add("Jefe(a)");
        puestos.Add("Auxiliar");
        puestos.Add("Ayudante");
        puestos.Add("Obrero(a)");
        puestos.Add("Coodinador");
        puestos.Add("Enfermero");
        puestos.Add("Director");

        //Asignar los datos a las propiedades del constructor de forma aleatoria
        Nombre = puestos[r.Next(0, puestos.Count-1)];
        Salario = r.Next(8000, 63000);
        if(r.NextDouble() > 0.5){
            EsDeBase = true;
        }
        else{
            EsDeBase = false;
        }
    }

    public string DescribirPuesto(){
        return $"{Nombre}\n{Salario}\nEs de base: {EsDeBase}";
    }
    }

   
}