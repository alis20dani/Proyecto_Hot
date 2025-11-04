using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using mi_proyecto_sena.Implementacion;
using mi_proyecto_sena.Models;
using mi_proyecto_sena.SERVICES;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Npgsql.Replication;

namespace mi_proyecto_sena.Controllers
{
    [Route("user")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioservices usuarioservice;

        public UsuarioController(IUsuarioservices usuarioservice)
        {
            this.usuarioservice = usuarioservice;
        }


        [HttpPost]
        [Route("register")]
        public IActionResult register(usuarioModel usuario)
        {
            if (usuario != null)
            {
                usuarioservice.CrearUsuario(usuario);
                return Ok("usuario creado");
            }
            else
            {
                return BadRequest("usuario no puede ser null");
            }

        }
    }
}