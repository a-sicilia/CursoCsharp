internal class Program
{
    private static void Main(string[] args)
    {
        
        List<int> num = new List<int>();

        int numIng = 9;

      
  
        while (numIng != 0)
        {
            Console.WriteLine("Ingresá un numero que no sea 0 (cero) bobito: ");
            numIng = Int32.Parse(Console.ReadLine());
            num.Add(numIng);
        }

        num.RemoveAt(num.Count-1);
        
        Console.WriteLine("Apretaste 0 (cero) estúpido");

        foreach (int i in num){
            Console.WriteLine(i);
        }
    }
}