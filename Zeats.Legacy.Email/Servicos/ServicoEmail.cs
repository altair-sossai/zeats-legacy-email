using System.Collections.Generic;
using System.Threading.Tasks;
using Zeats.Legacy.Email.Anexos;

namespace Zeats.Legacy.Email.Servicos
{
    public abstract class ServicoEmail : IServicoEmail
    {
        public void EnviarEmailAsync(string assunto, string corpo, string destinatario, List<Anexo> anexos = null)
        {
            Task.Factory.StartNew(() => { EnviarEmail(assunto, corpo, new List<string> {destinatario}, anexos); });
        }

        public void EnviarEmailAsync(string assunto, string corpo, List<string> destinatarios, List<Anexo> anexos = null)
        {
            Task.Factory.StartNew(() => { EnviarEmail(assunto, corpo, destinatarios, anexos); });
        }

        public void EnviarEmail(string assunto, string corpo, string destinatario, List<Anexo> anexos = null)
        {
            EnviarEmail(assunto, corpo, new List<string> {destinatario}, anexos);
        }

        public abstract void EnviarEmail(string assunto, string corpo, List<string> destinatarios, List<Anexo> anexos = null);
    }
}