internal class Program
{
    private static void Main(string[] args)
    {
        //AlacenEmpleados<Director> empleados = new AlacenEmpleados<Director>(3);
        //empleados.addElemento(new Director(2000));

        //No me deja instanciar la clase empleados por no implementar la interface IParaEmpleados
        AlacenEmpleados<Estudiante> empleados = new AlacenEmpleados<Estudiante>(3);
        empleados.addElemento(new Estudiante(2000));
    }
}

class Estudiante
{

    private int edad;

    public Estudiante(int edad)
    {
        this.edad = edad;
    }

    public int getEdad()
    {
        return this.edad;
    }

}



class AlacenEmpleados<T> where T : IParaEmpleados //Clase generica con restricción  (where T : IParaEmpleados)
{

    private int i = 0;
    private T[] datosEmpleado;

    public AlacenEmpleados(int z)
    {
        datosEmpleado = new T[z];
    }

    public void addElemento(T obj)
    {
        datosEmpleado[i]=obj;

        i++;
    }

    public T getEmpleado(int i) 
    {
        return datosEmpleado[i];
    }
}

class Director:IParaEmpleados
{
    private double salario;
    public Director(double salario)
    {
        this.salario=salario;
    }

    public double getSalario()
    {
        return salario;
    }
}


class Secretaria : IParaEmpleados
{

    private double salario;
    public Secretaria(double salario)
    {
        this.salario = salario;
    }
    public double getSalario()
    {
        return salario;
    }
}

class Electricista : IParaEmpleados
{

    private double salario;
    public Electricista(double salario)
    {
        this.salario = salario;
    }
    public double getSalario()
    {
        return salario;
    }
}

interface IParaEmpleados
{
    double getSalario();
}