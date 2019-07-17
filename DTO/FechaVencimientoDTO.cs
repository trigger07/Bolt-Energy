using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Common;

namespace Data.DTO
{
    public partial class FechaVencimientoDTO : BaseDTO 
    {
        protected int cod_FecVencimiento;
        protected DateTime fecVencimiento;
        protected string descripcion;
        protected int codSocio;
        protected string usuarioCreacion;
        protected DateTime fecCreacion;
        protected string usuarioModificacion;
        protected DateTime fecModificacion;
        protected int codRetorno;
        protected int dia;

        public int CodFecVencimiento
        {
            get
            {
                return cod_FecVencimiento;
            }
            set
            {
                cod_FecVencimiento = value;
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

        public int Dia
        {
            get
            {
                return dia;
            }
            set
            {
                dia = value;
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

        public int CodRetorno
        {
            get
            {
                return codRetorno;
            }
            set
            {
                codRetorno = value;
                IsDirty = true;
            }
        }
    }
}
