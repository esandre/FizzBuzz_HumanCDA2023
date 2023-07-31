namespace FizzBuzz.Test;

public class FizzBuzzTest
{
    [Theory]
    [InlineData(20U)]
    [InlineData(10U)]
    public void AfficherListeNombres(uint limite)
    {
        // QUAND on appelle ListeNombres.Afficher avec une limite <limite>
        var sortie = ListeNombres.Afficher(limite);

        // ALORS la liste des <limite> premiers nombres entiers positifs s'affiche, chacun sur une ligne
        var lignes = sortie.Split(Environment.NewLine);

        Assert.Equal((int) limite, lignes.Length);
        var nombres = lignes.Select(uint.Parse).ToArray();
        for (var i = 0U; i < limite; i++) Assert.Equal(i + 1U, nombres[i]);
    }
}