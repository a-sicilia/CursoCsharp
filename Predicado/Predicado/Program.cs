internal class Program
{
    private static void Main(string[] args)
    {


        List<int> listaNumeros = new List<int>();
        listaNumeros.AddRange(new int[] {1,2,3,4,5,6,7,8,9,10} );


        Predicate<int> ElDelegado = new Predicate<int>(DamePares);

        List<int> listaNumEnteros= listaNumeros.FindAll(ElDelegado); 

        foreach(int i in listaNumEnteros) Console.WriteLine(i);
    }

    static bool DamePares(int num) {

        if (num % 2 == 0) return true;
        else return false;
    
    }
}

