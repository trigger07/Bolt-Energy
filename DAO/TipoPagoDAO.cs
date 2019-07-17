using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using Common;
using Data.DTO;
using System.Xml;
using System.IO;

namespace Data.DAO
{
    public partial class TipoPagoDAO : BaseDAO<TipoPagoDTO>
    {
        #region Constantes
        const string SP_GETALL = "dbo.usp_ObtenerTodosTipoPago";
        const string SP_OBTENERFECHAVENCIMIENTOSOCIO = "dbo.";
        const string SP_SAVENEW = "dbo.";
        const string SP_GETBYID = "dbo.usp_ObtenerTipoPago";
        #endregion

        #region Constructores
        public TipoPagoDAO() { }
        public TipoPagoDAO(string database) : base(database) { }
        #endregion

        #region GetDdata
        public TipoPagoDTO ObtenerTipoPago(int pCodTipoPago)
        {
            TipoPagoDTO tipoPagoDto = new TipoPagoDTO();
            DbCommand command = db.GetStoredProcCommand(SP_GETBYID);

            db.AddInParameter(command, "@CodTipoPago", DbType.Int32, pCodTipoPago);
            IDataReader dataReader = null;
            try
            {
                dataReader = db.ExecuteReader(command);
                tipoPagoDto = Fill(dataReader);
            }
            finally
            {
                if (!dataReader.IsClosed)
                    dataReader.Close();
            }
            return tipoPagoDto;
        }

        public List<TipoPagoDTO> ObtenerTodosTiposPago()
        {
            List<TipoPagoDTO> list = new List<TipoPagoDTO>();
            TipoPagoDTO tipoPagoDto = new TipoPagoDTO();
            DbCommand command = db.GetStoredProcCommand(SP_GETALL);
            IDataReader dataReader = null;
            try
            {
                dataReader = db.ExecuteReader(command);
                list = FillList(dataReader);
            }
            finally
            {
                if (!dataReader.IsClosed)
                    dataReader.Close();
            }
            return list;
        }

        private TipoPagoDTO Fill(IDataReader dataReader)
        {
            TipoPagoDTO tipoPagoDto = null;
            try
            {
                if (dataReader.Read())
                {
                    tipoPagoDto = new TipoPagoDTO();
                    tipoPagoDto.CodTipoPago = (int)dataReader["Codigo"];
                    tipoPagoDto.Descripcion = (string)dataReader["Descripcion"];
                }
                else
                {
                    //Exception
                }
            }
            finally
            {
                if (!dataReader.IsClosed)
                    dataReader.Close();
            }
            return tipoPagoDto;
        }

        private List<TipoPagoDTO> FillList(IDataReader dataReader)
        {
            List<TipoPagoDTO> tipoPagoDtoList = new List<TipoPagoDTO>();

            TipoPagoDTO t = new TipoPagoDTO();
            t.CodTipoPago = 0;
            t.Descripcion = "Seleccione";
            tipoPagoDtoList.Add(t);

            try
            {
                if (dataReader.FieldCount > 1)
                {
                    while (dataReader.Read())
                    {
                        TipoPagoDTO tipoPagoDto = new TipoPagoDTO();
                        tipoPagoDto.CodTipoPago = (int)dataReader["Codigo"];
                        tipoPagoDto.Descripcion = (string)dataReader["Descripcion"];
                        tipoPagoDtoList.Add(tipoPagoDto);
                    }
                }
                else
                {
                    //Exception
                }
            }
            finally
            {
                if (!dataReader.IsClosed)
                    dataReader.Close();
            }
            return tipoPagoDtoList;
        }
        #endregion

        protected override void SaveNew(TipoPagoDTO entityDto)
        {
            throw new NotImplementedException();
        }

        protected override void SaveExisting(TipoPagoDTO entityDto)
        {
            throw new NotImplementedException();
        }

        protected override void Delete(TipoPagoDTO entityDto)
        {
            throw new NotImplementedException();
        }
    }
}
