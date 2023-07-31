namespace FizzBuzz;

public static class ListeNombres
{
    public static string Afficher()
    {
        return string.Join(Environment.NewLine, Enumerable.Range(1, 20));
    }
}