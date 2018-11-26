using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBiblia.BL
{
    public class Capitulo
    {
        public Capitulo()
        {
            this.Livro = new Livro();
        }

        public int IdCapitulo { get; set; }
        public int IdLivro { get; set; }
        public Livro Livro { get; set; }
        public int NumCapitulo { get; set; }
        public TimeSpan Tempo { get; set; }
        public string LocalArquivo { get; set; }

        public string getArquivoDownload(int idCapitulo)
        {
            throw new NotImplementedException();
        }

        public Capitulo getCapituloDetalhe(int idCapitulo)
        {
            throw new NotImplementedException();
        }
    }
}
