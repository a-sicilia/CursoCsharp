internal class Program
{
    private static void Main(string[] args)
    {

        //EJEMPLO MISMA CLASE GENERICA CON OBJETOS

        /*Elementos<Empleado> arrayDeElementos = new Elementos<Empleado>(3);
        arrayDeElementos.addElemento(new Empleado(1500));
        arrayDeElementos.addElemento(new Empleado(2500));
        arrayDeElementos.addElemento(new Empleado(3500));

        Empleado salarioEmpleado = arrayDeElementos.getElemento(1);
        Console.WriteLine(salarioEmpleado.getSalario());
        */



        //EJEMPLO MISMA CLASE GENERICA PERO CON STERINGS

        Elementos<String> arrayDeElementos = new Elementos<String>(3);

        arrayDeElementos.addElemento("Ariel");
        arrayDeElementos.addElemento("David");
        arrayDeElementos.addElemento("Sicilia");


        String nombre = arrayDeElementos.getElemento(1);
        Console.WriteLine(nombre);

    }
}


class Empleado
{
    private double salario;

    public Empleado(double salario)
    {
        this.salario = salario; 
    }

    public double getSalario()
    {
        return salario;
    }
}


////////////////////////////////////////////////////////////////////////////////////////// /
class Elementos<T>
{
    private T[] elementos;
    int i=0;

    public Elementos(int i)
    {
 
        elementos = new T[i];
    
    }

    public void addElemento(T obj)
    {
        elementos[i] = obj;
        i++;
    }

    public T getElemento(int i)
    {
        return elementos[i];
    }
}