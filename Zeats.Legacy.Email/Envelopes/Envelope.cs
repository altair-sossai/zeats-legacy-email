using System.Collections.Generic;
using System.Linq;
using Zeats.Legacy.Email.Anexos;
using Zeats.Legacy.Email.Servicos;

namespace Zeats.Legacy.Email.Envelopes
{
    public class Envelope
    {
        private readonly IServicoEmail _servicoEmail;

        public Envelope(IServicoEmail servicoEmail)
        {
            _servicoEmail = servicoEmail;
            Anexos = new List<Anexo>();
        }

        public string Assunto { get; set; }
        public string Corpo { get; set; }
        public List<Anexo> Anexos { get; }

        public virtual void Enviar(params string[] destinatarios)
        {
            _servicoEmail.EnviarEmail(Assunto, Corpo, destinatarios.ToList(), Anexos);
        }

        public virtual void EnviarAsync(params string[] destinatarios)
        {
            _servicoEmail.EnviarEmailAsync(Assunto, Corpo, destinatarios.ToList(), Anexos);
        }
    }
}