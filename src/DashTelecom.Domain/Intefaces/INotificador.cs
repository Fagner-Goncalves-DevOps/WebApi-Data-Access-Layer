using System.Collections.Generic;
using DashTelecom.Domain.Notificacoes;

namespace DashTelecom.Domain.Intefaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}