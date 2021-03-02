using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaboratorioProgramacionUno.DAO;
using LaboratorioProgramacionUno.DOMINIO;

namespace LaboratorioProgramacionUno.NEGOCIO

{
    class ClsLoginUsuario
    {
        Login log = new Login();
        clsListaUsuarios Cls = new clsListaUsuarios();

        public int acceso(Login log)
        {
            int estado = 0;
            for (int i = 0; i < Cls.user.Length; i++)
            {
                if (log.Usuario.Equals(Cls.user[i]) && log.Password.Equals(Cls.pass[i]))
                {
                    estado = 1;
                }

                {

                }
            }
            return estado;
        }
    }
}

