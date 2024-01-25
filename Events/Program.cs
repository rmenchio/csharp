// Os eventos tem as mesmas características de um sistema de mensageria, possui mensagens, subscripters e senders

using Events;

#region Eventos sem argumentos

    // Declaração da classe que enviará notificações
    NotificaEventoSemArgumentos notificaEvento = new();

    // Declaração da classe que receberá notificações
    RecebeEvento recebeEvento = new();

    // Inscrevendo a classe recebedora a lista de inscritos da classe notificadora
    notificaEvento.Inscritos += recebeEvento.MetodoExecutadoAoReceberNotificacaoSemArgumento;

    notificaEvento.Executar();

#endregion

#region Eventos com argumentos

    // Declaração da classe que enviará notificações
    NotificaEventoComArgumentos notificaEventoComArgumento = new();

    // Inscrevendo a classe recebedora a lista de inscritos da classe notificadora
    notificaEventoComArgumento.Inscritos += recebeEvento.MetodoExecutadoAoReceberNotificacaoComArgumento;

    notificaEventoComArgumento.Executar();

#endregion

#region Utilizando handler de evento sem precisar criar um delegate próprio

    // Declaração da classe que enviará notificações
    NotificaEventoSemArgumentos notificaComHandler = new();
    NotificaEventoComArgumentos notificaComHandlerArgs = new();

    // Inscrevendo a classe recebedora a lista de inscritos da classe notificadora
    notificaComHandler.InscritosDois += recebeEvento.MetodoExecutadoAoReceberNotificacaoSemArgumento;
    notificaComHandlerArgs.InscritosDois += recebeEvento.MetodoExecutadoAoReceberNotificacaoComArgumento;

    notificaComHandler.Executar();
    notificaComHandlerArgs.Executar();

#endregion

Console.ReadLine();