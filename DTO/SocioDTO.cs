using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Common;

namespace Data.DTO
{
    public partial class SocioDTO : BaseDTO 
    {
        protected int codSocio;
        protected string nombre;
        protected string apellido1;
        protected string apellido2;
        protected DateTime fecNacimiento;
        protected string correo;
        protected int diaPago;
        protected string telCelular;
        protected string telResidencia;
        protected string imagen;
        protected bool esActivo;
        protected int codTipoSocio;
        protected int codEmpresa;
        protected int codFecVencimiento;
        protected DateTime fecVencimiento;
        protected string descripcionFecha;
        protected string usuarioCreacion;
        protected DateTime fecCreacion;
        protected string usuarioModificacion;
        protected DateTime fecModificacion;

        public int CodSocio
        {
            get
            {
                return codSocio;
            }
            set
            {
                codSocio = value;
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

        public DateTime FechaNacimiento
        {
            get
            {
                return fecNacimiento;
            }
            set
            {
                fecNacimiento = value;
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

        public int DiaPago
        {
            get
            {
                return diaPago;
            }
            set
            {
                diaPago = value;
                IsDirty = true;
            }
        }

        public string TelCelular
        {
            get
            {
                return telCelular;
            }
            set
            {
                telCelular = value;
                IsDirty = true;
            }
        }

        public string TelResidencia
        {
            get
            {
                return telResidencia;
            }
            set
            {
                telResidencia = value;
                IsDirty = true;
            }
        }

        public string Imagen
        {
            get
            {
                return imagen;
            }
            set
            {
                imagen = value;
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

        public int CodTipoSocio
        {
            get
            {
                return codTipoSocio;
            }
            set
            {
                codTipoSocio = value;
                IsDirty = true;
            }
        }

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

        public int CodFecVencimiento
        {
            get
            {
                return codFecVencimiento;
            }
            set
            {
                codFecVencimiento = value;
                IsDirty = true;
            }
        }

        public DateTime FechaVencimiento
        {
            get
            {
                return fecVencimiento;
            }
            set
            {
                fecVencimiento = value;
                IsDirty = true;
            }
        }

        public string DescripcionFecha
        {
            get
            {
                return descripcionFecha;
            }
            set
            {
                descripcionFecha = value;
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
