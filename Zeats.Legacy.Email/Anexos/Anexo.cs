using System.IO;

namespace Zeats.Legacy.Email.Anexos
{
    public class Anexo
    {
        public Anexo()
        {
        }

        public Anexo(byte[] conteudo)
        {
            Conteudo = new MemoryStream(conteudo);
        }

        public string Nome { get; set; }
        public string Tipo { get; set; }
        public Stream Conteudo { get; set; }
    }
}