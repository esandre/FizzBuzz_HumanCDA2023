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

        Assert.Equal(limite, lignes.Length);

        for (var i = 0; i < lignes.Length; i++)
        {
            var ligne = lignes[i];
            var nombreAttendu = i + 1U;
            var estDivisibleParTrois = nombreAttendu % 3 == 0;
            var estDivisibleParCinq = nombreAttendu % 5 == 0;

            if (estDivisibleParTrois && estDivisibleParCinq)
                Assert.Equal("FizzBuzz", ligne);
            else if(estDivisibleParTrois) 
                Assert.Equal("Fizz", ligne);
            else if (estDivisibleParCinq)
                Assert.Equal("Buzz", ligne);
            else
            {
                var nombre = uint.Parse(ligne);
                Assert.Equal(nombreAttendu, nombre);
            }
        }
    }

    [Fact]
    public void AfficherListeNombreNegatifs()
    {
        // ETANT DONNE une limite négative
        const int limite = -20;

        // QUAND on appelle ListeNombres.Afficher avec une limite <limite> négative
        var sortie = ListeNombres.Afficher(limite);

        // ALORS la liste des <limite> premiers nombres entiers négatifs s'affiche, chacun sur une ligne
        var lignes = sortie.Split(Environment.NewLine);

        Assert.Equal(Math.Abs(limite), lignes.Length);

        for (var i = 0; i < lignes.Length; i++)
        {
            var ligne = lignes[i];
            var nombreAttendu = -(i + 1U);
            var estDivisibleParTrois = nombreAttendu % 3 == 0;
            var estDivisibleParCinq = nombreAttendu % 5 == 0;

            if (estDivisibleParTrois && estDivisibleParCinq)
                Assert.Equal("BuzzFizz", ligne);
            else if (estDivisibleParTrois)
                Assert.Equal("Fizz", ligne);
            else if (estDivisibleParCinq)
                Assert.Equal("Buzz", ligne);
            else
            {
                var nombre = int.Parse(ligne);
                Assert.Equal(nombreAttendu, nombre);
            }
        }
    }

    [Fact]
    public void Trois_Est_Fizz()
    {
        // QUAND on appelle ListeNombres.Afficher avec une limite d'au-moins 3
        var sortie = ListeNombres.Afficher(3);

        // ALORS trois est remplacé par Fizz
        var lignes = sortie.Split(Environment.NewLine);

        Assert.Equal("Fizz", lignes.Last());
    }
}