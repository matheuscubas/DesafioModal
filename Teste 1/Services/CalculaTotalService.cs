public class CalculaTotalService
{
  public double CalculaTotal(double precoPorQuilo, int tara, int pesoDoPratoDoCliente)
  {
    int pesoFinalEmGramas = pesoDoPratoDoCliente - tara;
    var pesoFinalEmQuilos = (double)pesoFinalEmGramas / 1000;
    double precoFinal = pesoFinalEmQuilos * precoPorQuilo;

    return precoFinal;
  }
}