internal class Program
{
    private static void Main(string[] args)
    {
        Queue<int> numeros = new Queue<int>(); 
        
        foreach (int numero in new int[5] {22,66,77,88,156}) {
        
            numeros.Enqueue(numero);
        }


        foreach (int numero in numeros) {
            Console.WriteLine(numero);
        }

        Console.WriteLine("\nDescolando '{0}'", numeros.Dequeue());

        Console.WriteLine("\nNueva Queue: ");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }

    }
}