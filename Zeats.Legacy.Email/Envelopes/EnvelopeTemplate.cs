using Zeats.Legacy.Email.Servicos;
using Zeats.Legacy.Stubble.Helpers;

namespace Zeats.Legacy.Email.Envelopes
{
    public class EnvelopeTemplate : Envelope
    {
        private string _templateAssunto;
        private string _templateCorpo;

        public EnvelopeTemplate(IServicoEmail servicoEmail)
            : base(servicoEmail)
        {
        }

        public string TemplateAssunto
        {
            get => _templateAssunto;
            set
            {
                _templateAssunto = value;
                AplicarTemplate();
            }
        }

        public string TemplateCorpo
        {
            get => _templateCorpo;
            set
            {
                _templateCorpo = value;
                AplicarTemplate();
            }
        }

        private void AplicarTemplate()
        {
            if (!string.IsNullOrEmpty(TemplateAssunto))
                Assunto = StubbleHelper.Parse(TemplateAssunto, this);

            if (!string.IsNullOrEmpty(TemplateCorpo))
                Corpo = StubbleHelper.Parse(TemplateCorpo, this);
        }

        public override void Enviar(params string[] destinatarios)
        {
            AplicarTemplate();
            base.Enviar(destinatarios);
        }

        public override void EnviarAsync(params string[] destinatarios)
        {
            AplicarTemplate();
            base.EnviarAsync(destinatarios);
        }
    }
}