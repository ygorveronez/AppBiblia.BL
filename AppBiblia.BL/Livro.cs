using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBiblia.BL
{
    public class Livro
    {
        public int IdLivro { get; set; }
        public string Nome { get; set; }

        public List<Capitulo> getCapitulos { get; set; }

    }
}
