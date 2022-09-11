class FormService
{
  public string? StringParaSeparar;
  public void PrintForm()
  {
    Console.WriteLine("Por favor insira a string que deverá ser separada:");
    StringParaSeparar = Console.ReadLine();
  }
}