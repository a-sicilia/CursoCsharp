using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {

        string frase = "La Rioja 2128 1124042928";


        string patron = @"\d{3}|24";

        string patron2 = "La Rioja (2128)? 1124042928";

        Regex expRegular = new Regex(patron2);

        MatchCollection matchCollection = expRegular.Matches(frase);

        if(matchCollection.Count > 0 ) Console.WriteLine("Tiene numeros");
        else Console.WriteLine("No tiene numeros");

    }
}