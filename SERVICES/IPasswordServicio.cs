using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mi_proyecto_sena.SERVICES
{
    public interface IPasswordServicio
    {
        string HashPassword(string password);
    }
}