public class Program
{
  private static void Main(string[] args)
  {
    var intro = new IntroService();
    var form = new FormService();
    var calculaTotal = new CalculaTotalService();

    intro.PrintIntro();
    form.PrintForm();
    double preco = form.Preco;
    int tara = form.Tara;
    int pesoTotal = form.PesoTotal;
    double total = Math.Round(calculaTotal.CalculaTotal(preco,tara,pesoTotal), 2);
    Console.WriteLine($"O prato de {pesoTotal} gramas custa R${total}");
    Console.WriteLine("Para finalizar o programa pressione qualquer teclar.");
    Console.ReadKey();
  }
}