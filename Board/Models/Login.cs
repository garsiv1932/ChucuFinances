using System;
using System.Collections.Generic;
using Board.DTOs;
using Board.Servicios;

namespace Board.Models
{
    public class Login
    {
        public string user { get; set; }
        
        public string password { get; set; }

        private List<Ciudad> ciudades { get; set; }

        public Login()
        {
            ServicioLogin servicio = new ServicioLogin();
            ciudades = servicio.ciudadesUruguay();
        }
        
        public Login(string user, string password)
        {
            this.user = user;
            this.password = password;
        }

        public bool hacerLogin()
        {
            return true;
        }
    }
}