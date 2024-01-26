namespace System
{
	public static class StringExtensionsComNamespaceSystem
	{
		public static string SomentePrimeirasLetras(this string str)
		{
			return string.Join(" ", str.Split(" ").Select(s => s[0]));
		}
    }
}