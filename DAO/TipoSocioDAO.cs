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
    public partial class TipoSocioDAO : BaseDAO<TipoSocioDTO>
    {
        #region Constantes
        const string SP_GETALL = "dbo.usp_ObtenerTodosTipoSocio";
        const string SP_GETBYID = "dbo.usp_ObtenerTipoSocio";
        const string SP_SAVENEW = "dbo.";
        const string SP_SAVEEXISTING = "dbo.";
        #endregion

        #region Constructores
        public TipoSocioDAO() { }
        public TipoSocioDAO(string database) : base(database) { }
        #endregion


        #region GetData
        public TipoSocioDTO ObtenerTipoSocio(int pCodTipoSocio)
        {
            TipoSocioDTO tipoSocioDto = new TipoSocioDTO();
            DbCommand command = db.GetStoredProcCommand(SP_GETBYID);

            db.AddInParameter(command, "@CodTipoSocio", DbType.Int32, pCodTipoSocio);
            IDataReader dataReader = null;
            try
            {
                dataReader = db.ExecuteReader(command);
                tipoSocioDto = Fill(dataReader);
            }
            finally
            {
                if (!dataReader.IsClosed)
                    dataReader.Close();
            }
            return tipoSocioDto;
        }

        public List<TipoSocioDTO> ObtenerTodosTipoSocio()
        {
            List<TipoSocioDTO> list = new List<TipoSocioDTO>();
            TipoSocioDTO tipoSocioDto = new TipoSocioDTO();

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

        private TipoSocioDTO Fill(IDataReader dataReader)
        {
            TipoSocioDTO tipoSocioDto = null;
            try
            {
                if (dataReader.Read())
                {
                    tipoSocioDto = new TipoSocioDTO();
                    tipoSocioDto.CodTipoSocio = (int)dataReader["Codigo"];
                    tipoSocioDto.Descripcion = (string)dataReader["Descripcion"];
                    tipoSocioDto.Detalle = (string)dataReader["Detalle"];
                    tipoSocioDto.EsActivo = (bool)dataReader["Estado"];
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
            return tipoSocioDto;
        }

        private List<TipoSocioDTO> FillList(IDataReader dataReader)
        {
            List<TipoSocioDTO> tipoSocioDtoList = new List<TipoSocioDTO>();

            TipoSocioDTO t = new TipoSocioDTO();
            t.CodTipoSocio = 0;
            t.Descripcion = "Seleccione";
            tipoSocioDtoList.Add(t);

            try
            {
                if (dataReader.FieldCount > 1)
                {
                    while (dataReader.Read())
                    {
                        TipoSocioDTO tipoSocioDto = new TipoSocioDTO();
                        tipoSocioDto.CodTipoSocio = (int)dataReader["Codigo"];
                        tipoSocioDto.Descripcion = (string)dataReader["Descripcion"];
                        tipoSocioDto.Detalle = (string)dataReader["Detalle"];
                        tipoSocioDto.EsActivo = (bool)dataReader["Estado"];
                        tipoSocioDtoList.Add(tipoSocioDto);
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
            return tipoSocioDtoList;
        }
        #endregion

        protected override void SaveNew(TipoSocioDTO entityDto)
        {
            throw new NotImplementedException();
        }

        protected override void SaveExisting(TipoSocioDTO entityDto)
        {
            throw new NotImplementedException();
        }

        protected override void Delete(TipoSocioDTO entityDto)
        {
            throw new NotImplementedException();
        }
    }
}
