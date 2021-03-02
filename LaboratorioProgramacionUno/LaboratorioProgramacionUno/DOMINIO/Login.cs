using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgramacionUno.DOMINIO
{
    class Login
    {

        private String usuario;
        private String password;
        private String administrador;
        private String adminPassword;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }
        public string Administrador { get => administrador; set => administrador = value; }
        public string AdminPassword { get => adminPassword; set => adminPassword = value; }

    }
}  


