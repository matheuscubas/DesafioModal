public class FormataNomeService
{
  public void FormataNome(string nomeDoFuncionario)
  {
    var arrayDeNomes = nomeDoFuncionario.Split(' ');
    var ultimoNome = arrayDeNomes.Last().ToUpper();
    var conectores = new List<string>() { "de", "da", "das", "do", "dos", "e" };
    var stringFinal = $"{ultimoNome},";
    var arrayFormatado = new List<string>() { stringFinal };

    for (int i = 0; i < arrayDeNomes.Length - 1; i++)
    {
      var name = arrayDeNomes[i];

      if (!conectores.Contains(name))
      {
        var nomeAbreviado = $" {name.ToUpper().First()}.";
        arrayFormatado.Add(nomeAbreviado);
      }
    }

    arrayFormatado.ForEach(x => Console.Write(x));
    Console.WriteLine();
  }
}