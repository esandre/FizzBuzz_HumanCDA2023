namespace FizzBuzz;

public static class ListeNombres
{
    public static string Afficher(int limite)
    {
        var nombres = limite >= 0 ? Enumerable.Range(1, limite) : NegativeRange(-1, limite);
        var representations = nombres.Select(n => n % 3 == 0 ? "Fizz" : n.ToString());

        return string.Join(Environment.NewLine, representations);
    }

    private static IEnumerable<int> NegativeRange(int start, int limite)
    {
        return Enumerable.Range(Math.Abs(start), Math.Abs(limite))
            .Select(nombre => -nombre);
    }
}