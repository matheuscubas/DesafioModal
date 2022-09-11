public class IntroService
{
  public void PrintIntro()
  {
    var defaultIntro = @"
    Bem-vindo ao Restaurante Bacana
    Obrigado por sua visita, é um prazer recebe-lo.
    Nosso atendente irá pesar e realizar a cobrança
    rapidamente!
    ";

    Console.WriteLine(defaultIntro);
  }
}