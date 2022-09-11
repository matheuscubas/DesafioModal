public class Program
{
  public static void Main(string[] args)
  {
    var intro = new IntroService();
    var form = new FormService();
    var separador = new SeparaNumeroDeStringService();

    intro.PrintIntro();
    form.PrintForm();
    separador.SepararStringDeNumero(form.StringParaSeparar);
    Console.WriteLine("Lista de numeros: ");
    Console.WriteLine("[{0}]", string.Join(", ", separador.arrayDeNumeros));
    Console.WriteLine();
    Console.WriteLine("Lista de palavras: ");
    Console.WriteLine("[{0}]", string.Join(", ", separador.arrayDePalavras));
    Console.WriteLine();
    Console.WriteLine("Para finalizar o programa pressione qualquer tecla.");
    Console.ReadKey();
  }
}