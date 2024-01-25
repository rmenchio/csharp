namespace Events
{
	public class RecebeEvento
	{
		public void MetodoExecutadoAoReceberNotificacaoSemArgumento(object origem, EventArgs e)
		{
			Console.WriteLine($"Recebi o evento de {origem.ToString()} sem argumentos {e.ToString()}");
		}

        public void MetodoExecutadoAoReceberNotificacaoComArgumento(object origem, Argumentos e)
        {
            Console.WriteLine($"Recebi o evento de {origem.ToString()} com o argumento {e.Propriedade}");
        }
    }
}