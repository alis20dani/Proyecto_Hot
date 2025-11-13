using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using mi_proyecto_sena.Implementacion;
using mi_proyecto_sena.Models;
using mi_proyecto_sena.SERVICES;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
        public async Task<IActionResult> register(usuarioModel usuario)
        {
            if (ModelState.IsValid)
            {
                await usuarioservice.CrearUsuario(usuario);
                return RedirectToAction("Index", "Home");
            }          
                return View(usuario);
        }

        [HttpGet]
        [Route("register")]
        public IActionResult Register()
        {
            return View();
        }
    }
}