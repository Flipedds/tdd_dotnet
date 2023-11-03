namespace Models;

public class Calculadora
{
    private readonly List<string> _historico;

    public Calculadora()
    {
        _historico = new List<string>();
    }
    public int Somar(int valorUm, int valorDois)
    {   
        int res = valorUm + valorDois;
        _historico.Insert(0, "Res" + res);
        return res;
    }

    public int Subtrair(int valorUm, int valorDois)
    {
        int res = valorUm - valorDois;
        _historico.Insert(0, "Res" + res);
        return res;
    }
    public int Dividir(int valorUm, int valorDois)
    {
        int res = valorUm / valorDois;
        _historico.Insert(0, "Res" + res);
        return res;
    }
    public int Multiplicar(int valorUm, int valorDois)
    {
        int res = valorUm * valorDois;
        _historico.Insert(0, "Res" + res);
        return res;
    }

    public List<string> GetHistorico()
    {
        List<string> res = new();
        for (int i = 0; i < 3; i++)
        {
            res.Add(_historico[i]);
        }
        return res;
    }
}
