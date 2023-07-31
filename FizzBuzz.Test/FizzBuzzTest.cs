namespace FizzBuzz.Test;

public class FizzBuzzTest
{
    [Fact]
    public void AfficherListeNombres()
    {
        // QUAND on appelle ListeNombres.Afficher
        var sortie = ListeNombres.Afficher();

        // ALORS la liste des 20 premiers nombres entiers positifs s'affiche, chacun sur une ligne
        var lignes = sortie.Split(Environment.NewLine);

        Assert.Equal(20, lignes.Length);
        var nombres = lignes.Select(uint.Parse).ToArray();
        for (var i = 0U; i < 20; i++)
        {
            Assert.Equal(i + 1U, nombres[i]);
        }
    }
}