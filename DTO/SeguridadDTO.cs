using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Common;

namespace Data.DTO
{
    public partial class SeguridadDTO : BaseDTO
    {
        protected int codUsuario;
        protected string usuario;
        protected string password;
        protected string nombre;
        protected string apellido1;
        protected string apellido2;
        protected string rolDescripcion;

        public int CodUsuario
        {
            get
            {
                return codUsuario;
            }
            set
            {
                codUsuario = value;
                IsDirty = true;
            }
        }

        public string Usuario
        {
            get
            {
                return usuario;
            }
            set
            {
                usuario = value;
                IsDirty = true;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                IsDirty = true;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
                IsDirty = true;
            }
        }

        public string Apellido1
        {
            get
            {
                return apellido1;
            }
            set
            {
                apellido1 = value;
                IsDirty = true;
            }
        }

        public string Apellido2
        {
            get
            {
                return apellido2;
            }
            set
            {
                apellido2 = value;
                IsDirty = true;
            }
        }

        public string RolDescripcion
        {
            get
            {
                return rolDescripcion;
            }
            set
            {
                rolDescripcion = value;
                IsDirty = true;
            }
        }
    }
}
