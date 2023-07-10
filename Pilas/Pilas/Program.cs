internal class Program
{
    private static void Main(string[] args)
    {
        
        Stack<int> numeros = new Stack<int>();

        foreach(int i in new int[5] {44,66,77,57,456})
        {
            numeros.Push(i);    
        }

        Console.WriteLine("Desapilando {0}", numeros.Peek());
        numeros.Pop();

        foreach (int i in numeros)
        {
            Console.WriteLine(i);
        }

    }
}