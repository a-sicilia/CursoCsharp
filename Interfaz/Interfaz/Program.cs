using Interfaz;

internal class Program
{
    private static void Main(string[] args)
    {
        
        AvisosTrafico av1 = new AvisosTrafico();
        av1.MostrarAviso();

        AvisosTrafico av2 = new AvisosTrafico("Rulo","Mensaje enviado desde el construcrtor creado","22/6/2023");
        av2.MostrarAviso(); 

    }
}