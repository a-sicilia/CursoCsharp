internal class Program
{

    public delegate int OperacionesMatematicas(int numero);
    public delegate int Suma(int n1,int n2);

    public delegate bool ComparaPersonas(Personas p1, Personas p2);
    private static void Main(string[] args)
    {

        /*
        OperacionesMatematicas delegado = new OperacionesMatematicas(num => num*num);
        Console.WriteLine(delegado(5));

        Suma delegado2 = new Suma((num1,num2) => num1 + num2);
        Console.WriteLine(delegado2(5,5)); 




        //Otro EJEMPLO

          List<int> numeros=new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        List<int> numPares = numeros.FindAll(i=>i%2==0);

        foreach(int i in numPares) Console.WriteLine(i);
        */

        Personas p1 =new Personas();
        p1.Nombre = "David";
        p1.Edad = 72;


        Personas p2 = new Personas();
        p2.Nombre = "David";
        p2.Edad = 36;


        ComparaPersonas comparaEdad = (pe1, pe2) =>
         {
             if (pe1.Edad == pe2.Edad) return true;
             else return false;
         };
        Console.WriteLine("Tienen la misma edad?: {0}",comparaEdad(p1, p2));


        ComparaPersonas comparaNom = (pe1, pe2) =>
        {
            if (pe1.Nombre== pe2.Nombre) return true;
            else return false;
        };
        Console.WriteLine("Se llaman igual?: {0}",comparaNom(p1, p2));

    }

    

}



class Personas
{
    private string nombre;
    private int edad;

    public string Nombre { get => nombre; set => nombre = value; }
    public int Edad { get => edad; set => edad = value; }
}