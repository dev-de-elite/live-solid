namespace SOLID.Console._2_OCP.Solucao;

public abstract class Conta
{
    public string Numero { get; set; } = default!;
    public decimal Saldo { get; set; }

    public abstract void CalcularRendimento(decimal taxa);
}
