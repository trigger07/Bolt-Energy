using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Common;

namespace Data.DTO
{
    public partial class AsistenciaDTO : BaseDTO 
    {
        protected int codAsistencia;
        protected string descripcion;
        protected DateTime fecAsistencia;
        protected bool esActivo;
        protected int codSocio;
        protected string usuarioCreacion;
        protected DateTime fecCreacion;
        protected string usuarioModificacion;
        protected DateTime fecModificacion;

        public int CodAsistencia
        {
            get
            {
                return codAsistencia;
            }
            set
            {
                codAsistencia = value;
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

        public DateTime FechaAsistencia
        {
            get
            {
                return fecAsistencia;
            }
            set
            {
                fecAsistencia = value;
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
