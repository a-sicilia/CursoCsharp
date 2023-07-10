internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Random numero=new Random();
        int aleatorio = numero.Next(0, 100);

        int miNum = 0;
        int intentos = 0;
        
        Console.WriteLine("introduce un numero entre 0 y 100");

        do
        {
            intentos++;
            try 
            {
                
                miNum = int.Parse(Console.ReadLine());

            }
            catch(Exception e) when (e.GetType() != typeof(FormatException))
            {   
                Console.WriteLine("Escribe numero valido por favor...");
                Console.WriteLine(e.Message);
                miNum = 0;

                
            }catch(FormatException e)
            {
                Console.WriteLine("Pusiste letras pa!");
            }
            if (miNum > aleatorio) Console.WriteLine("El num es más bajo");
            if (miNum < aleatorio) Console.WriteLine("El num es más alto");

        } while (aleatorio != miNum);

        Console.WriteLine("suma: " + test2);
        //Console.WriteLine("La pegaste loquito!!!!");
        //Console.WriteLine("Intentos erroneos: " + intentos);

    }
}