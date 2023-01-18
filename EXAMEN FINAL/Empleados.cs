class empleado
{
    public string Nombre{get;set;}
    public int Edad{get;set;}
    public double salario{get;set;}
    public double plus=300;

    public empleado(string nombre,int edad,double salario)
    {
        this.Nombre=nombre;
        this.Edad=edad;
        this.salario=salario;
    }
    public void Imprimir()
    {
   
        System.Console.WriteLine("NOMBRE: "+ Nombre);
        System.Console.WriteLine("EDAD: "+ Edad);
        System.Console.WriteLine("SALARIO: "+salario);

    }
}