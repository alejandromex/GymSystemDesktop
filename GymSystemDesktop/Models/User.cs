using GymSystemDesktop.DbConnection;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymSystemDesktop.Models
{

    class User
    {
        private DbConn sql = DbConn.GetInstance();

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Llave { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public string PlanRegistrado { get; set; }
        public string Direccion { get; set; }
        public string Celular { get; set; }
        public string Img { get; set; }




        public bool RegistrarUsuario()
        {
            bool response;

            try
            {
                sql.ExecuteQueryWithParams($"spINSERT_CreateNewUserClient", new string[] { Nombre, Apellido, Edad + "", Llave, FechaInicio + "", FechaFin + "", PlanRegistrado, Direccion, Celular, Img });
                response = true;
            }
            catch(Exception ex)
            {
                response = false;
            }

            return response;
        }
    }
}
