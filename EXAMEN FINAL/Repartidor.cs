class repartidor:empleado,Interfaz
{
    string zona{get;set;}
    public repartidor(string nombre,int edad, double salario,string zona):base(nombre,edad,salario)
    {

        this.zona=zona;
    }
    public void Iplus()
    {
        double salarioT=0;
        if(Edad<25 & zona == "zona 3")
        {
            salarioT=salario+plus;
            System.Console.WriteLine("EL SALARIO TOTAL DEL REPARTIDOR: "+ Nombre +" :");
            System.Console.WriteLine("EL REPARTIDOR TIENE UN SALARIO DE: "+ salarioT);
        }
        else
        {
            System.Console.WriteLine("EL SALARIO TOTAL DEL REPARTIDOR: "+ Nombre +" :");
            System.Console.WriteLine("EL REPARTIDOR TIENE UN SALARIO DE: "+ salarioT);
        }
    }
}
