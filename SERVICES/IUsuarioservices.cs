using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mi_proyecto_sena.Models;

namespace mi_proyecto_sena.SERVICES
{
    public interface IUsuarioservices
    {
        void CrearUsuario(usuarioModel usuario);
    }
}