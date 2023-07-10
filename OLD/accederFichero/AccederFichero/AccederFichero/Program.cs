internal class Program
{
    private static void Main(string[] args)
    {
        
        StreamReader archivo = null;

        try
        {

            string linea;
            int contador = 0;

            string path = @"C:\Users\\Rulo\\Desktop\test.txt";
            archivo = new StreamReader(path);

            while((linea=archivo.ReadLine()) != null)
            {
                Console.WriteLine(linea);
                contador++;
            }
        
        }catch(Exception e)
        {
            Console.WriteLine("Error en la lectura del archivo");
        }
        finally
        {
            if (archivo != null) archivo.Close();
            Console.WriteLine("Conexion con el archivo cerrada...");
        }



    }
}