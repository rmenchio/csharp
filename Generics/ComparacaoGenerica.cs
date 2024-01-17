namespace Generics
{
	public class ComparacaoGenerica
    {
		public T QualObjetoEhMaior<T>(T a, T b) where T : IComparable
		{
			return a.CompareTo(b) > 0 ? a : b;
		}

        public void Testando()
        {
            Console.WriteLine(QualObjetoEhMaior(new Teste(23), new Teste(20)).Valor);
        }
	}

    public class Teste : IComparable
    {
        public int Valor { get; set; }

        public Teste(int valor)
        {
            Valor = valor;
        }

        public int CompareTo(object? obj)
        {
            return Valor > ((Teste)obj).Valor ? 1 : (Valor < ((Teste)obj).Valor ? -1 : 0);
        }
    }
}