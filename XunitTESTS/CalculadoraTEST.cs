using Models;
namespace XunitTESTS;
public class CalculadoraTEST
{
    private readonly Calculadora _calculadora;
    public CalculadoraTEST()
    {
        _calculadora = new Calculadora();
    }
    [Theory]
    [InlineData(1, 2)]
    [InlineData(2, 3)]
    [InlineData(4, 5)]
    [InlineData(6, 5)]
    public void CalculadoraSomarDeveRetornarSomaCorretamente(int numeroUm, int numeroDois)
    {
        //act
        int resultado = _calculadora.Somar(numeroUm, numeroDois);

        //assert
        Assert.Equal(numeroUm + numeroDois, resultado);
    }
}
