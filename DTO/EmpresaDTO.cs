using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Common;

namespace Data.DTO
{
    public partial class EmpresaDTO : BaseDTO
    {
        protected int codEmpresa;
        protected string nombreEmpresa;
        protected string descripcion;
        protected string telefono1;
        protected string telefono2;
        protected string correo;
        protected bool esActivo;
        protected string usuarioCreacion;
        protected DateTime fecCreacion;
        protected string usuarioModificacion;
        protected DateTime fecModificacion;

        public int CodEmpresa 
        {
            get
            {
                return codEmpresa;
            }
            set
            {
                codEmpresa = value;
                IsDirty = true;
            }
        }

        public string NombreEmpresa
        {
            get
            {
                return nombreEmpresa;
            }
            set
            {
                nombreEmpresa = value;
                IsDirty = true;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }
            set
            {
                descripcion = value;
                IsDirty = true;
            }
        }

        public string Telefono1
        {
            get
            {
                return telefono1;
            }
            set
            {
                telefono1 = value;
                IsDirty = true;
            }
        }

        public string Telefono2
        {
            get
            {
                return telefono2;
            }
            set
            {
                telefono2 = value;
                IsDirty = true;
            }
        }

        public string Correo
        {
            get
            {
                return correo;
            }
            set
            {
                correo = value;
                IsDirty = true;
            }
        }

        public bool EsActivo
        {
            get
            {
                return esActivo;
            }
            set
            {
                esActivo = value;
                IsDirty = true;
            }
        }

        public string UsuarioCreacion
        {
            get
            {
                return usuarioCreacion;
            }
            set
            {
                usuarioCreacion = value;
                IsDirty = true;
            }
        }

        public DateTime FechaCreacion
        {
            get
            {
                return fecCreacion;
            }
            set
            {
                fecCreacion = value;
                IsDirty = true;
            }
        }

        public string UsuarioModificacion
        {
            get
            {
                return usuarioModificacion;
            }
            set
            {
                usuarioModificacion = value;
                IsDirty = true;
            }
        }

        public DateTime FechaModificacion
        {
            get
            {
                return fecModificacion;
            }
            set
            {
                fecModificacion = value;
                IsDirty = true;
            }
        }
    }
}
