#region imports
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
#endregion

namespace Data.DAO
{
    public partial class CategoriaPagoDAO : BaseDAO<CategoriaPagoDTO>
    {
        #region Constantes
        const string SP_GETALL = "dbo.usp_ObtenerPeriodosPago";
        const string SP_ = "dbo.";
        const string SP_SAVENEW = "dbo.";
        const string SP_GETBYID = "dbo.usp_ObtenerPeriodoPago";
        #endregion

        #region Constructores
        public CategoriaPagoDAO() { }
        public CategoriaPagoDAO(string database) : base(database) { }
        #endregion

        public CategoriaPagoDTO ObtenerCategoriaPago(int pCodCatPago)
        {
            CategoriaPagoDTO catPagoDto = new CategoriaPagoDTO();
            DbCommand command = db.GetStoredProcCommand(SP_GETBYID);

            db.AddInParameter(command, "@CodCatPago", DbType.Int32, pCodCatPago);
            IDataReader dataReader = null;
            try
            {
                dataReader = db.ExecuteReader(command);
                catPagoDto = Fill(dataReader);
            }
            finally
            {
                if (!dataReader.IsClosed)
                    dataReader.Close();
            }
            return catPagoDto;
        }

        public List<CategoriaPagoDTO> ObtenerTodasCatPago()
        {
            List<CategoriaPagoDTO> list = new List<CategoriaPagoDTO>();
            CategoriaPagoDTO catPagoDto = new CategoriaPagoDTO();
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

        private CategoriaPagoDTO Fill(IDataReader dataReader)
        {
            CategoriaPagoDTO catPagoDto = null;
            try
            {
                if (dataReader.Read())
                {
                    catPagoDto = new CategoriaPagoDTO();
                    catPagoDto.CodCatPago = (int)dataReader["Codigo"];
                    catPagoDto.Descripcion = (string)dataReader["Descripcion"];
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
            return catPagoDto;
        }

        private List<CategoriaPagoDTO> FillList(IDataReader dataReader)
        {
            List<CategoriaPagoDTO> catPagoDtoList = new List<CategoriaPagoDTO>();

            CategoriaPagoDTO c = new CategoriaPagoDTO();
            c.CodCatPago = 0;
            c.Descripcion = "Seleccione";
            catPagoDtoList.Add(c);

            try
            {
                if (dataReader.FieldCount > 1)
                {
                    while (dataReader.Read())
                    {
                        CategoriaPagoDTO catPagoDto = new CategoriaPagoDTO();
                        catPagoDto.CodCatPago = (int)dataReader["Codigo"];
                        catPagoDto.Descripcion = (string)dataReader["Descripcion"];
                        catPagoDtoList.Add(catPagoDto);
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
            return catPagoDtoList;
        }

        protected override void SaveNew(CategoriaPagoDTO entityDto)
        {
            throw new NotImplementedException();
        }

        protected override void SaveExisting(CategoriaPagoDTO entityDto)
        {
            throw new NotImplementedException();
        }

        protected override void Delete(CategoriaPagoDTO entityDto)
        {
            throw new NotImplementedException();
        }
    }
}
