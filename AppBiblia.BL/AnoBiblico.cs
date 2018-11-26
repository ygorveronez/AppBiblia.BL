using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBiblia.BL
{
    public class AnoBiblico
    {
        public AnoBiblico()
        {
            this.Usuario = new Usuario();
        }
        public int IdAnoBiblico { get; set; }
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime DataInicio { get; set; }

        public DateTime getPrevisaoTermino(int idAnoBiblico)
        {
            throw new NotImplementedException();
        }

        public List<ProgramaDiario> getProgramas()
        {
            throw new NotImplementedException();
        }

        public double getPorcentagemConcluido()
        {
            throw new NotImplementedException();
        }

        public AnoBiblico comecarAnoBiblico(int idUsuario, DateTime diaInicio)
        {
            throw new NotImplementedException();
        }
    }
}
