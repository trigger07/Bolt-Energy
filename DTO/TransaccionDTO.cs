using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Common;

namespace Data.DTO
{
    public partial class TransaccionDTO : BaseDTO
    {
        protected int codTransaccion;
        protected string descripcion;
        protected string detalle;
        protected decimal monto;
        protected DateTime fecTransaccion;
        protected bool esActivo;
        protected int codTipoPago;
        protected int codSocio;
        protected string numComprobante;
        protected string numReciboGym;
        protected string usuarioCreacion;
        protected DateTime fecCreacion;
        protected string usuarioModificacion;
        protected DateTime fecModificacion;
        protected int codCatPago;

        public int CodTransaccion
        {
            get
            {
                return codTransaccion;
            }
            set
            {
                codTransaccion = value;
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

        public string Detalle
        {
            get
            {
                return detalle;
            }
            set
            {
                detalle = value;
                IsDirty = true;
            }
        }

        public decimal Monto
        {
            get
            {
                return monto;
            }
            set
            {
                monto = value;
                IsDirty = true;
            }
        }

        public DateTime FechaTransaccion
        {
            get
            {
                return fecTransaccion;
            }
            set
            {
                fecTransaccion = value;
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

        public int CodTipoPago
        {
            get
            {
                return codTipoPago;
            }
            set
            {
                codTipoPago = value;
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

        public string NumComprobante
        {
            get
            {
                return numComprobante;
            }
            set
            {
                numComprobante = value;
                IsDirty = true;
            }
        }

        public string NumReciboGym
        {
            get
            {
                return numReciboGym;
            }
            set
            {
                numReciboGym = value;
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

        public int CodCatPago
        {
            get
            {
                return codCatPago;
            }
            set
            {
                codCatPago = value;
                IsDirty = true;
            }
        }
    }
}
