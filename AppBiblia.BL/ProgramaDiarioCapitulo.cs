using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBiblia.BL
{
    public class ProgramaDiarioCapitulo
    {
        public ProgramaDiarioCapitulo()
        {   
            this.Programa = new ProgramaDiario();
        }

        public int IdPrograma { get; set; }
        public int IdCapitulo { get; set; }

        public ProgramaDiario Programa { get; set; }
        public Capitulo Capitulo { get; set; }
    }
}
