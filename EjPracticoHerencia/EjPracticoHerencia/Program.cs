internal class Program
{
    private static void Main(string[] args)
    {
       Coche auto = new Coche();
        Avion avion = new Avion();

        auto.manejar();
        avion.manejar();

        Vehiculo vehiculo = new Vehiculo();
        vehiculo.manejar();
    }
}


class Vehiculo
{

    public void arrancar()
    {
        Console.WriteLine("Arrancando...");
    }


    public void detener()
    {
        Console.WriteLine("Deteniendo...");
    }

    public virtual void manejar()
    {
        Console.WriteLine("Todos los vehiculos se manejan");
    }
}


class Avion : Vehiculo
{
    public override void manejar()
    {
        Console.WriteLine("Piloteando Avion");
    }

}

class Coche : Vehiculo
{
    public override void manejar()
    {
        Console.WriteLine("Manejando un auto");
    }
}