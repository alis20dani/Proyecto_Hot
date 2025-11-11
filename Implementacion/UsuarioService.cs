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
        private readonly IPasswordServicio passwordServicio;

        public UsuarioService(DBContext dBContext, IPasswordServicio passwordServicio)
        {
            this.dBContext = dBContext;
            this.passwordServicio = passwordServicio;
        }

        public async Task CrearUsuario(usuarioModel usuario)
        {
            if (usuario != null)
            {
                usuario.Usuario_Contrasena = passwordServicio.HashPassword(usuario.Usuario_Contrasena);
                dBContext.Usuarios.Add(usuario);
                await dBContext.SaveChangesAsync();
            }

        }
    }
}
