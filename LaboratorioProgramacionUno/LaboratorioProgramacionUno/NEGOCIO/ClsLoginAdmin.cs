using LaboratorioProgramacionUno.DOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaboratorioProgramacionUno.DAO;
namespace LaboratorioProgramacionUno.NEGOCIO

{
    class ClsLoginAdmin
    {
        Login log = new Login();
        ClsListaAdministradores Cls = new ClsListaAdministradores();
        public int acceso(Login log)
        {
            int estado = 0;
            for (int i = 0; i < Cls.admin.Length; i++)
            {
                if (log.Administrador.Equals(Cls.admin[i]) && log.AdminPassword.Equals(Cls.adminpass[i]))
                    estado = 1;
                {

                }
            }
            return estado;
        }
    }
}
