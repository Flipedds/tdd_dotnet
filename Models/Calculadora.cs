namespace Models;

public class Calculadora
{
    private List<string> historico = new();
    public int Somar(int valorUm, int valorDois)
    {   
        int res = valorUm + valorDois;
        historico.Insert(0, "Res" + res);
        return res;
    }

    public int Subtrair(int valorUm, int valorDois)
    {
        int res = valorUm - valorDois;
        historico.Insert(0, "Res" + res);
        return res;
    }
    public int Dividir(int valorUm, int valorDois)
    {
        int res = valorUm / valorDois;
        historico.Insert(0, "Res" + res);
        return res;
    }
    public int Multiplicar(int valorUm, int valorDois)
    {
        int res = valorUm * valorDois;
        historico.Insert(0, "Res" + res);
        return res;
    }

    public List<string> GetHistorico()
    {
        List<string> res = new();
        for (int i = 0; i < 3; i++)
        {
            res.Add(historico[i]);
        }
        return res;
    }
}
