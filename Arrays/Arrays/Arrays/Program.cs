internal class Program
{
    private static void Main(string[] args)
    {
        Empleado[] arrayEmploeado = new Empleado[2];

        Empleado emp = new Empleado("David", 36);
        Empleado emp2 = new Empleado("Ruben", 59);

        arrayEmploeado[0] = emp;
        arrayEmploeado[1] = emp2;

        for(int i=0; i< arrayEmploeado.Length; i++) Console.WriteLine(arrayEmploeado[i].getNombre()+"\n");
    
    }


}

class Empleado
{
    string nombre;
    int edad;

    public Empleado(string nombre, int edad) {

        this.nombre = nombre;
        this.edad = edad;

    }

    public string getNombre(){
        return (this.nombre);
        }

}