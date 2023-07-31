using System.ComponentModel;

namespace FizzBuzz.Test;

public class FizzBuzzTest
{
    [Theory]
    [InlineData(20)]
    [InlineData(10)]
    public void AfficherListeNombres(int limite)
    {
        // QUAND on appelle ListeNombres.Afficher avec une limite <limite>
        var sortie = ListeNombres.Afficher(limite);

        // ALORS la liste des <limite> premiers nombres entiers positifs s'affiche, chacun sur une ligne
        var lignes = sortie.Split(Environment.NewLine);

        Assert.Equal((int) limite, lignes.Length);
        var nombres = lignes.Select(uint.Parse).ToArray();
        for (var i = 0U; i < limite; i++) Assert.Equal(i + 1U, nombres[i]);
    }

    [Fact]
    public void AfficherListeNombreNegatifs()
    {
        // ETANT DONNE une limite négative
        const int limite = -5;

        // QUAND on appelle ListeNombres.Afficher avec une limite <limite> négative
        var sortie = ListeNombres.Afficher(limite);

        // ALORS la liste des <limite> premiers nombres entiers négatifs s'affiche, chacun sur une ligne
        var lignes = sortie.Split(Environment.NewLine);

        Assert.Equal(Math.Abs(limite), lignes.Length);
        var nombres = lignes.Select(int.Parse).ToArray();
        for (var i = 0U; i < Math.Abs(limite); i++) Assert.Equal(-(i + 1U), nombres[i]);
    }
}