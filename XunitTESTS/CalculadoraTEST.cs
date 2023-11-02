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
    [InlineData(1, 2, 3)]
    [InlineData(2, 3, 5)]
    [InlineData(4, 5, 9)]
    [InlineData(6, 5, 11)]
    public void CalculadoraSomarDeveRetornarSomaCorretamente(int numeroUm, int numeroDois, int res)
    {
        //act
        int resultado = _calculadora.Somar(numeroUm, numeroDois);

        //assert
        Assert.Equal(res, resultado);
    }
    [Theory]
    [InlineData(1, 2, -1)]
    [InlineData(2, 3, -1)]
    [InlineData(4, 5, -1)]
    [InlineData(6, 5, 1)]
    public void CalculadoraSubtrairDeveRetornarSubtracaoCorretamente(int numeroUm, int numeroDois, int res)
    {
        //act
        int resultado = _calculadora.Subtrair(numeroUm, numeroDois);

        //assert
        Assert.Equal(res, resultado);
    }

    [Theory]
    [InlineData(10, 2, 5)]
    [InlineData(15, 3, 5)]
    public void CalculadoraDividirDeveRetornarDivisaoCorretamente(int numeroUm, int numeroDois, int res)
    {
        //act
        int resultado = _calculadora.Dividir(numeroUm, numeroDois);

        //assert
        Assert.Equal(res, resultado);
    }

    [Theory]
    [InlineData(10, 0)]
    [InlineData(15, 0)]
    [InlineData(20, 0)]
    public void CalculadoraDividirRetornaExceptionAoDividirPor0(int numeroUm, int numeroDois)
    {
        //assert
        Assert.Throws<DivideByZeroException>(() => _calculadora.Dividir(numeroUm, numeroDois));
    }
}
