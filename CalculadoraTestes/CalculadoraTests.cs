namespace CalculadoraTestes;

using Calculadora.Models;

public class CalculadoraTests
{
    public Calculadora ConstruirClasse()
    {
        string data = "31/05/2024";
        Calculadora calc = new Calculadora(data);

        return calc;
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    public void TesteSomar(double n1, double n2, double resultado)
    {
        // Arrange
        Calculadora calc = ConstruirClasse();

        // Act
        double resultadoCalculadora = calc.Somar(n1, n2);

        // Assert
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(1, 2, -1)]
    [InlineData(4, 5, -1)]
    public void TesteSubtrair(double n1, double n2, double resultado)
    {
        // Arrange
        Calculadora calc = ConstruirClasse();

        // Act
        double resultadoCalculadora = calc.Subtrair(n1, n2);

        // Assert
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(4, 5, 20)]
    public void TesteMultiplicar(double n1, double n2, double resultado)
    {
        // Arrange
        Calculadora calc = ConstruirClasse();

        // Act
        double resultadoCalculadora = calc.Multiplicar(n1, n2);

        // Assert
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(1, 2, 0.5)]
    [InlineData(4, 5, 0.8)]
    public void TesteDividir(double n1, double n2, double resultado)
    {
        // Arrange
        Calculadora calc = ConstruirClasse();

        // Act
        double resultadoCalculadora = calc.Dividir(n1, n2);

        // Assert
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TestarDivisaoPorZero()
    {
        // Arrange
        Calculadora calc = ConstruirClasse();

        // Act / Assert
        Assert.Throws<DivideByZeroException>(
            () => calc.Dividir(3,0)
        );
    }

    [Fact]
    public void TestarHistoricoDeOperacoes()
    {
        // Arrange
        Calculadora calc = ConstruirClasse();

        // Act 
        calc.Somar(1, 2);
        calc.Somar(2, 8);
        calc.Somar(3, 7);
        calc.Somar(4, 1);

        var lista = calc.HistoricoDeOperacoes();
        
        // Assert
        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}