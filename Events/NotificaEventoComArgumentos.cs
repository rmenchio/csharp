namespace Events
{
    public class Argumentos : EventArgs
	{
		public string Propriedade { get; set; }

        public Argumentos(string propriedade)
        {
            Propriedade = propriedade;
        }
    }

	public class NotificaEventoComArgumentos
    {
		// Declaração do delegate que será utilizado pelos inscritos para obter os eventos.
		public delegate void NotificaExecucao(object origem, Argumentos e);

		// Declaração do evento, onde adicionaremos os inscritos desse evento.
		public event NotificaExecucao Inscritos;

        // Outra forma de usar um handler de evento sem precisar declarar um delegate
        public event EventHandler<Argumentos> InscritosDois;

        public void Executar()
		{
			Console.WriteLine("Executando.....");
			Thread.Sleep(3000);

			EnviarNotificacao();
        }

		protected virtual void EnviarNotificacao()
		{
			// Se houverem inscritos, envia a notificação, junto com argumentos, se necessário.
			if (Inscritos != null)
				Inscritos(this, new Argumentos("Teste"));

            if (InscritosDois != null)
                InscritosDois(this, new Argumentos("Teste"));
        }
	}
}