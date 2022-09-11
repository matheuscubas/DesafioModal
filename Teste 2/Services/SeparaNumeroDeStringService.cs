public class SeparaNumeroDeStringService
{
  public List<string> arrayDePalavras = new();
  public List<string> arrayDeNumeros = new();

  public void SepararStringDeNumero(string stringParaArrumar)
  {
    var ArrayDeStrings = stringParaArrumar.Split(',');

    for (var i = 0; i < ArrayDeStrings.Length; i++)
    {
      var word = ArrayDeStrings[i].Trim();
      int number;
      double decimalNumber;

      if (int.TryParse(word, out number) || double.TryParse(word, out decimalNumber))
      {
        arrayDeNumeros.Add(word);
      } else {
        arrayDePalavras.Add(word);
      }
    }
  }
}