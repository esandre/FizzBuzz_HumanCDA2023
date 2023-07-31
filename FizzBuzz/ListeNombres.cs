namespace FizzBuzz;

public static class ListeNombres
{
    public static string Afficher(int limite)
    {
        var nombres = limite >= 0 ? Enumerable.Range(1, limite) : NegativeRange(-1, limite);
        var representations = nombres.Select(ReprésenterNombre);

        return string.Join(Environment.NewLine, representations);
    }

    private static string ReprésenterNombre(int nombre)
    {
        var estDivisibleParTrois = nombre % 3 == 0;
        var estDivisibleParCinq = nombre % 5 == 0;
        var estNégatif = nombre < 0;

        if (estDivisibleParTrois && estDivisibleParCinq) 
            return estNégatif ? "BuzzFizz" : "FizzBuzz";

        if (estDivisibleParTrois) return "Fizz";

        if (estDivisibleParCinq) return "Buzz";
        return nombre.ToString();
    }

    private static IEnumerable<int> NegativeRange(int start, int limite)
    {
        return Enumerable.Range(Math.Abs(start), Math.Abs(limite))
            .Select(nombre => -nombre);
    }
}