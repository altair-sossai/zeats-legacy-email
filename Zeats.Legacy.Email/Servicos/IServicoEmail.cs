using System.Collections.Generic;
using Zeats.Legacy.Email.Anexos;

namespace Zeats.Legacy.Email.Servicos
{
    public interface IServicoEmail
    {
        void EnviarEmailAsync(string assunto, string corpo, string destinatario, List<Anexo> anexos = null);
        void EnviarEmailAsync(string assunto, string corpo, List<string> destinatarios, List<Anexo> anexos = null);
        void EnviarEmail(string assunto, string corpo, string destinatario, List<Anexo> anexos = null);
        void EnviarEmail(string assunto, string corpo, List<string> destinatarios, List<Anexo> anexos = null);
    }
}