internal class Program
{
    private static void Main(string[] args)
    {
        comercial comercial1 = new comercial("DON RAMON",45,450,290);
        comercial1.Imprimir();
        
        comercial comercial2 = new comercial("DOÑA MARI",40,425,100);
        comercial2.Imprimir();
        repartidor repartidor1= new repartidor("ENRIQUE",20,380,"zona 3");
        repartidor1.Imprimir();
        repartidor repartidor2 = new repartidor("ESPERANZA",21,355,"zona 1");
        repartidor2.Imprimir();

        List <empleado> ListaEmpleado = new List<empleado>();
        ListaEmpleado.Add(comercial1);
        ListaEmpleado.Add(comercial2);
        ListaEmpleado.Add(repartidor1);
        ListaEmpleado.Add(repartidor2);
        foreach (Interfaz item in ListaEmpleado)
        {
            item.Iplus();
        }
    }
}