using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Common;

namespace Data.DTO
{
    public partial class TipoPagoDTO : BaseDTO
    {
        protected int codTipoPago;
        protected string descripcion;

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
    }
}
