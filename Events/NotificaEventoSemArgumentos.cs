namespace Events
{
	public class NotificaEventoSemArgumentos
    {
		// Declaração do delegate que será utilizado pelos inscritos para obter os eventos.
		public delegate void NotificaExecucao(object origem, EventArgs e);

		// Declaração do evento, onde adicionaremos os inscritos desse evento.
		public event NotificaExecucao Inscritos;

		// Outra forma de usar um handler de evento sem precisar declarar um delegate
		public event EventHandler InscritosDois;

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
				Inscritos(this, EventArgs.Empty);

			if (InscritosDois != null)
				InscritosDois(this, EventArgs.Empty);
		}
	}
}