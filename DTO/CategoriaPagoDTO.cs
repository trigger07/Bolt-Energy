using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Common;

namespace Data.DTO
{
    public partial class CategoriaPagoDTO : BaseDTO
    {
        protected int codCatPago;
        protected string descripcion;

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
