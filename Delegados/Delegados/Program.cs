internal class Program
{
    private static void Main(string[] args)
    {

        //puntero al metodo SaludoBienvenida de la clase MensajeBienvenida
        delegado ElDelegado = new delegado(MensajeBienvenida.SaludoBienvenida);
        //Utilizo el metodo apuntado
        ElDelegado("David");

        ElDelegado = new delegado(MensajeAdios.SaludoAdios);
        ElDelegado("Extermineitor");
    }
}


delegate void delegado(string nom);

class MensajeBienvenida
{
    public static void SaludoBienvenida(string nom)
    {
        Console.WriteLine("Hola {0}",nom);
    }
}

class MensajeAdios
{
    public static void SaludoAdios(string nom)
    {
        Console.WriteLine("Nos vimos {0}",nom);
    }
}

    
