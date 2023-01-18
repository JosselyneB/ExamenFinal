class comercial:empleado,Interfaz
{
    double comision{get;set;}
    public comercial(string nombre,int edad, double salario,double comision)
                       :base(nombre,edad,salario)
    {
   
        this.comision=comision;
    }
    public void Iplus()
    {
        double salarioTotal=0;
        if(Edad>30 & comision>200)
        {
            salarioTotal=salario+plus;
            System.Console.WriteLine("EL SALSARIO TOTAL DEL EMPLEADO: "+ Nombre +" : ");
            System.Console.WriteLine("EL EMPLEADO TIENE UN SALARIO DE: "+ salarioTotal);
        }
            else
            {
              System.Console.WriteLine("EL SALSARIO TOTAL DEL EMPLEADO: "+ Nombre +" : ");
            System.Console.WriteLine("EL EMPLEADO TIENE UN SALARIO DE: "+ salarioTotal);
            }
    }
}