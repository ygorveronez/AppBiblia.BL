using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBiblia.BL
{
    public class ProgramaDiario
    {
        public ProgramaDiario()
        {
            this.AnoBiblico = new AnoBiblico();
        }
        public int IdPrograma { get; set; }
        public int IdAnoBiblico { get; set; }
        public AnoBiblico AnoBiblico { get; set; }
        public int Dia { get; set; }
        public bool Concluido { get; set; }

        public List<ProgramaDiarioCapitulo> getCapituloDiario(int IdPrograma)
        {
            throw new NotImplementedException();
        }
    }
}
