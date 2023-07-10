using Poo;

internal class Program
{
    private static void Main(string[] args)
    {
        //realizarTarea();

       var miVariable = new {Nombre="Ariel", Edad=36 };

        Console.WriteLine($"La persona {miVariable.Nombre} tiene una edad de: {miVariable.Edad}");

    }

    private static void realizarTarea()
    {
        Punto punto = new Punto();

        Punto punto1 = new Punto(2,18);


        Console.WriteLine($"Cantidad de instancias creadas:  {punto.getContadorInstancias()}");
    }
}