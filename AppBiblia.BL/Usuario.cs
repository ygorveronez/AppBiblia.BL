using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBiblia.BL
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public bool validarUsuario(string email, string senha)
        {
            throw new NotImplementedException();
        }

        public bool getUsuario(int IdUsuario)
        {
            throw new NotImplementedException();
        }

    }
}
