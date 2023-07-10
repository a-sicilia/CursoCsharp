
using System.Runtime.InteropServices;

namespace primeraAplicacion { 
    internal class Program
    {
        private static void Main(string[] args)
        {     
            Console.WriteLine("Poné un numero");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Poné un numero");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = sunarNumeros(num1, num2);
            Console.WriteLine("El resultado es:" + resultado);
        }

        private static int sunarNumeros(int n1,int n2)
        {
            int res=n1+ n2;
            return res;
        }
    }

}