using System.Text;

namespace FizzBuzz;

public static class ListeNombres
{
    // For a Fistful of Dolipranes
    public static string Afficher(int limite)
    {
        var nombres = GénérerNombres(CancellationToken.None, limite > 0);
        nombres = nombres.Take(Math.Abs(limite));

        var builder = new StringBuilder();
        using var enumerator = nombres.GetEnumerator();

        while (enumerator.MoveNext())
        {
            builder.Append(enumerator.Current);
            builder.Append(Environment.NewLine);
        }

        return builder.ToString();
    }

    private static IEnumerable<string> GénérerNombres(CancellationToken token, bool positifs = true)
    {
        for(var current = 1;
            !token.IsCancellationRequested;
            current ++)
        {
            if (EstDivisiblePar(current, 3) && EstDivisiblePar(current, 5)) 
                yield return positifs ? "FizzBuzz" : "BuzzFizz";
            else if (EstDivisiblePar(current, 3)) 
                yield return "Fizz";
            else if (EstDivisiblePar(current, 5)) 
                yield return "Buzz";
            else 
                yield return positifs ? current.ToString() : (-current).ToString();
        }
    }

    private static bool EstDivisiblePar(int nombre, int diviseur)
        => nombre % diviseur == 0;
}