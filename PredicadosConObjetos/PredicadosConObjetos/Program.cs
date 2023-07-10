using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Personas> listaDePersonas = new List<Personas>();
        Personas p1=new Personas();
        p1.Nombre = "Davi";
        p1.Edad = 36;

        Personas p2 = new Personas();
        p2.Nombre = "Ruben";
        p2.Edad = 16;

        Personas p3 = new Personas();
        p3.Nombre = "Ariel";
        p3.Edad = 66;

        Personas p4 = new Personas();
        p4.Nombre = "Gabriel";
        p4.Edad = 50;

        Personas p5 = new Personas();
        p5.Nombre = "Mika";
        p5.Edad = 5;


        listaDePersonas.AddRange(new Personas[] { p1, p2, p3, p4 ,p5});

        Predicate<Personas> elPredicado = new Predicate<Personas>(ExisteDavid);

        bool existe = listaDePersonas.Exists(elPredicado); 
        Console.WriteLine(existe);
        
    }

    //sssssssssssssssssssssssssssssssssssssssssssssssssssssssssss


    static bool ExisteDavid(Personas persona)
    {
        if (persona.Nombre == "David") return true;
        else return false;
    }
}

class Personas
{
    private string nombre;
    private int edad;

    public string Nombre { get => nombre; set => nombre = value; }
    public int Edad { get => edad; set => edad = value; }
}