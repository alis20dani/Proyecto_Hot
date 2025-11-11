using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mi_proyecto_sena.Models
{
    public class usuarioModel
    {
        public int User_Id { get; set; }
        public required string Usuario_Nombre { get; set; }
        public required string Usuario_Apellido { get; set; }
        public required string Usuario_Correo { get; set; }
        public required string Usuario_Contrasena { get; set; }

    }
}