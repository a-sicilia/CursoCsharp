internal class Program
{
    private static void Main(string[] args)
    {
       
        LinkedList<int> numeros = new LinkedList<int>();   

        foreach(int i in new int[] { 0, 10, 20, 25, 30, 50 })
        {
            numeros.AddLast(i);
        }
        
        /*
        foreach(int i in numeros )
        {
            Console.WriteLine(i);
        }
        */


        //IGUAL QUE EL FOREACH
         for(LinkedListNode<int> nodo=numeros.First; nodo != null; nodo = nodo.Next)
        {
            int num = nodo.Value;
            Console.WriteLine(num);
        }

    }
}