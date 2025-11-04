using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mi_proyecto_sena.Data;
using mi_proyecto_sena.Models;
using mi_proyecto_sena.SERVICES;
using Npgsql.Replication;

namespace mi_proyecto_sena.Implementacion
{
    public class UsuarioService : IUsuarioservices
    {
        private readonly DBContext dBContext;
        public UsuarioService(DBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public async void CrearUsuario(usuarioModel usuario)
        {
            if (usuario != null)
            {
                dBContext.Usuarios.Add(usuario);
                await dBContext.SaveChangesAsync();
            }

        }
    }
}
