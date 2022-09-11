public class FormService
{
  public double Preco;
  public int Tara;
  public int PesoTotal;

  public void PrintForm()
  {
    Console.WriteLine("Insira o preço do KG de hoje! no formato R$ XX,XX(respeite as casas decimais):");
    Preco = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Insira o valor da Tara do prato(em gramas):");
    Tara = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Insira o peso total em gramas do prato do cliente:");
    PesoTotal = Convert.ToInt16(Console.ReadLine());
  }
}