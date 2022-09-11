public class Program
{
  static void Main(string[] args)
  {
    var intro = new IntroService();
    var form = new FormService();
    var formatador = new FormataNomeService();

    intro.PrintIntro();
    form.PrintForm();
    formatador.FormataNome(form.NomeDoFuncionario);

    Console.WriteLine("Para finalizar o programa pressione qualquer tecla");
    Console.ReadKey();
  }
}
