using Models;
namespace XunitTESTS;
public class CalculadoraTEST
{
    private readonly Calculadora _calculadora;
    public CalculadoraTEST()
    {
        _calculadora = new Calculadora();
    }
    [Fact]
    public void CalculadoraSomarDeveRetornarSomaCorretamente()
    {
        //arrange
        int numeroUm = 1;
        int numeroDois = 2;

        //act
        int resultado = _calculadora.Somar(numeroUm, numeroDois);

        //assert
        Assert.Equal(3, resultado);
    }
}
