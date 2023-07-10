internal class Program
{
    private static void Main(string[] args)
    {
        /* Caballos caballos = new Caballos("Juanito");
         Humano humano = new Humano("David");
         Gorilla gorilla = new Gorilla("Magila");

         caballos.mostrarNombre();
         caballos.pensar();
         Console.WriteLine("\n");

         humano.mostrarNombre();
         humano.pensar();
         Console.WriteLine("\n");


         gorilla.mostrarNombre();
         gorilla.pensar();
         Console.WriteLine("\n");

         Mamiferos mamifero = new Gorilla("Ariel");
         mamifero.pensar();
         Console.WriteLine("\n----------------------------------------------------------------------\n");

         Console.WriteLine("Cantidad de patas del caballo: "+ caballos.NumeroDePatas());*/

        Lagartija gex = new Lagartija("Juancho");
        gex.respirar();
        gex.mostrarNombre();

        Humano juan = new Humano("Humano");
        juan.respirar();
        


    }
}


/// /////////////////////////////////////////////////////////////////////////////


abstract class Animales
{
    public void respirar()
    {
        Console.WriteLine("Estoy respirando");
    }

    public abstract void mostrarNombre();
}


/// /////////////////////////////////////////////////////////////////////////////


class Mamiferos : Animales
{
    private string nombreSerVivo="Default";


    public Mamiferos(string nombre)
    {
        nombreSerVivo = nombre;
    }


    public void cuidarCrias()
    {
        Console.WriteLine("Cuidando de las crias");
    }


    public virtual void pensar()
    {
        Console.WriteLine("Pensamiento instintivo");
    }

    public override void mostrarNombre()
    {
        Console.WriteLine("El nombre del mamifero es: "+nombreSerVivo);
    }
}


interface IMamiferosTerrestres{
    int NumeroDePatas();
}

/// <summary>
/// //////////////////////////////////////////////////////////////////////////////
/// </summary>

class Caballos : Mamiferos, IMamiferosTerrestres
{
    public Caballos(string nombre) : base(nombre){ }

    public void galopar()
    {
        Console.WriteLine("Soy un caballo y estoy galopando");
    }

    public int NumeroDePatas()
    {
        return 4;
    }
}



class Humano : Mamiferos
{
    public Humano(string nombre) : base(nombre) { }

    public override void pensar()
    {
        Console.WriteLine("Soy humano y pienso");
    }
}



class Gorilla : Mamiferos
{
    public Gorilla(string nombre) : base(nombre) { }


    public void treparArbol()
    {
        Console.WriteLine("Soy un gorilla y me trepo");
    }

    public override void pensar()
    {
        Console.WriteLine("El gorila tambien piensa");
    }
}



class Ballena : Mamiferos
{
    public Ballena(String  nombre) : base(nombre)
    {

    }

    public void nadar()
    {
        Console.WriteLine("Puedo nadar");

    }
}



class Lagartija : Animales
{
    string nombreReptil;

    public Lagartija(string nombreReptil)
    {
        this.nombreReptil = nombreReptil;
    }

    public override void mostrarNombre()
    {
        Console.WriteLine("El nombre del reptil es: {0} ",nombreReptil);
    }


}