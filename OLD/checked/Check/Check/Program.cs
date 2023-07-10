namespace LanzarExcepciones { 

    internal class Program
    {
        private static void Main(string[] args)
        {

            Console.WriteLine("Introduce número");
            int num=int.Parse(Console.ReadLine());

            try { 
            Console.WriteLine(NombreDelMes(num));
            }catch(Exception e) {
                Console.WriteLine(e.Message);
                Console.WriteLine("Desde acá continuaría el programa");
            }
        }


        public static string NombreDelMes (int mes)
        {
            switch(mes) 
            {
                case 1:
                    return "Enero";
                case 2:
                    return "Febrero";
                case 3:
                    return "Marzo";
                case 4:
                    return "Abril";
                case 5:
                    return "Mayo";
                case 6:
                    return "Junio";

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

    }

}