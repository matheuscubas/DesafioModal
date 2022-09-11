public class FormService
{
  public string NomeDoFuncionario;
  public void PrintForm()
  {
    Console.WriteLine("Por favor insira abaixo o nome do funcionário que você deseja formatar: ");
    NomeDoFuncionario = Console.ReadLine();
  }
}