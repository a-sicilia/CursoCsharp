internal class Program
{
    private static void Main(string[] args)
    {
        Empleado david = new Empleado("David");

        //Se pueden usar las propiedades como variables, sin geters ni seters
        david.SALARIO = 1500;
        david.SALARIO = david.SALARIO+500;
        Console.WriteLine("El saslario del empleado es: "+david.SALARIO);
    }
}


class Empleado
{

    private string nombre;
    private double salario;

    public Empleado(string nombre)
    {
        this.nombre = nombre;
    }

    public double setSalario(double salario)
    {
        if (salario < 0) return 0;
        else return salario;
        
    }


    
    ///  PROPIEDADDDDDDDDDDDDDDDDDDD
    
    public double SALARIO
    {
        get => this.salario; 
        set => this.salario = setSalario(value);

    }
}