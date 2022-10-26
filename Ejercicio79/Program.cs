
class Ejercicio79
{
    static void main()
    {
        HashSet<string> diccio = new HashSet<string>(); 
        diccio.Add("Hola");
        diccio.Add("hasta luego");

        if (diccio.Contains("Adios"))
            Console.WriteLine("Adios si esta");
        if (diccio.Contains("Hola"))
            Console.WriteLine("Hola si esta");
    }
}