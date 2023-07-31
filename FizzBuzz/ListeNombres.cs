namespace FizzBuzz;

public static class ListeNombres
{
    public static string Afficher(uint taille)
    {
        return string.Join(Environment.NewLine, Enumerable.Range(1, (int) taille));
    }
}