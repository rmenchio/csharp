namespace ExtensionMethods
{
	public static class StringExtensions
	{
		public static string EncurtarMensagem(this string str, int numeroPalavras)
		{
			if(numeroPalavras <= 0)
				throw new IndexOutOfRangeException("O número de palavras deve ser maior que 0.");

			if (str.Length <= numeroPalavras)
				return str;

			return string.Join(" ", str.Split(" ").Take(numeroPalavras)) + "...";
		}
    }
}