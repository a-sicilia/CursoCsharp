internal class Program
{
    private static void Main(string[] args)
    {

        Dictionary<string,int> edades= new Dictionary<string,int>();

        edades.Add("David", 36);
        edades.Add("Ruben", 58);
        edades.Add("Mika", 5);

        edades["Ema"] = 4;


        foreach (KeyValuePair<string, int> ed in edades)
        {
            Console.WriteLine("{0} tiene {1} años.",ed.Key,ed.Value);  
        }

    }
}