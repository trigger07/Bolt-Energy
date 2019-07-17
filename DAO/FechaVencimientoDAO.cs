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
    public partial class FechaVencimientoDAO : BaseDAO<FechaVencimientoDTO>
    {

        #region Constantes
        const string SP_GETALL = "dbo.";
        const string SP_GETBYID = "usp_ObtenerFechaVencimiento";
        const string SP_OBTENERFECHAVENCIMIENTOSOCIO = "dbo.usp_ObtenerMorosidadSocio";
        const string SP_SAVENEW = "dbo.usp_InsertarFecVencimiento";
        const string SP_SAVEEXISTING = "dbo.usp_ActualizarFecVencimiento";
        #endregion

        #region Constructores
        public FechaVencimientoDAO() { }
        public FechaVencimientoDAO(string database) : base(database) { }
        #endregion

        public FechaVencimientoDTO ObtenerFecVencimiento(int pCodSocio, int pCodCortesia)
        {
            FechaVencimientoDTO fecDto = new FechaVencimientoDTO();
            DbCommand command = db.GetStoredProcCommand(SP_OBTENERFECHAVENCIMIENTOSOCIO);

            db.AddInParameter(command, "@CodSocio", DbType.Int32, pCodSocio);
            db.AddInParameter(command, "@CodCortesia", DbType.Int32, pCodCortesia);
            IDataReader dataReader = null;
            try
            {
                dataReader = db.ExecuteReader(command);
                fecDto = Fill(dataReader);
            }
            finally
            {
                if (!dataReader.IsClosed)
                    dataReader.Close();
            }
            return fecDto;
        }

        public FechaVencimientoDTO ObtenerFecha(int pCodSocio)
        {
            FechaVencimientoDTO fecDto = new FechaVencimientoDTO();
            DbCommand command = db.GetStoredProcCommand(SP_GETBYID);

            db.AddInParameter(command, "@CodSocio", DbType.Int32, pCodSocio);
            IDataReader dataReader = null;
            try
            {
                dataReader = db.ExecuteReader(command);
                fecDto = Fill2(dataReader);
            }
            finally
            {
                if (!dataReader.IsClosed)
                    dataReader.Close();
            }
            return fecDto;
        }

        private FechaVencimientoDTO Fill2(IDataReader dataReader)
        {
            FechaVencimientoDTO fecDto = null;
            try
            {
                if (dataReader.Read())
                {
                    fecDto = new FechaVencimientoDTO();
                    fecDto.CodFecVencimiento = (int)dataReader["Fev_Codigo"];
                    fecDto.FechaVencimiento = (DateTime)dataReader["Fev_FechaVencimiento"];
                    fecDto.CodSocio = (int)dataReader["Soc_Codigo"];
                    fecDto.Dia = (int)dataReader["Dia"];
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
            return fecDto;
        }

        private FechaVencimientoDTO Fill(IDataReader dataReader)
        {
            FechaVencimientoDTO fecDto = null;
            try
            {
                if (dataReader.Read())
                {
                    fecDto = new FechaVencimientoDTO();
                    fecDto.CodRetorno = (int)dataReader["CodigoRetorno"];
                    
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

            return fecDto;
        }


        protected override void SaveNew(FechaVencimientoDTO fecDto)
        {
            DbCommand cmd = db.GetStoredProcCommand(SP_SAVENEW);
            try
            {
                BuildParameters(cmd, fecDto);
                db.ExecuteNonQuery(cmd);
            }
            catch
            {
                throw;
            }
        }

        protected override void SaveExisting(FechaVencimientoDTO fecDto)
        {
            DbCommand cmd = db.GetStoredProcCommand(SP_SAVEEXISTING);
            try
            {
                BuildParametersUpdate(cmd, fecDto);
                db.ExecuteNonQuery(cmd);
            }
            catch
            {
                throw;
            }
        }

        protected override void Delete(FechaVencimientoDTO entityDto)
        {
            throw new NotImplementedException();
        }

        private void BuildParameters(DbCommand command, FechaVencimientoDTO fecDto)
        {
            try
            {
                db.AddInParameter(command, "@FecVencimiento", DbType.DateTime, fecDto.FechaVencimiento);
                db.AddInParameter(command, "@Descripcion", DbType.String, fecDto.Descripcion);
                db.AddInParameter(command, "@Soc_Codigo", DbType.Int32, fecDto.CodSocio);
                db.AddInParameter(command, "@UsuarioCreacion", DbType.String, fecDto.UsuarioCreacion);
                db.AddInParameter(command, "@FecCreacion", DbType.DateTime, fecDto.FechaCreacion);
            }
            catch
            {
                throw;
            }
        }

        private void BuildParametersUpdate(DbCommand command, FechaVencimientoDTO fecDto)
        {
            try
            {
                db.AddInParameter(command, "@Soc_Codigo", DbType.Int32, fecDto.CodSocio);
                db.AddInParameter(command, "@FecVencimiento", DbType.DateTime, fecDto.FechaVencimiento);
                db.AddInParameter(command, "@Descripcion", DbType.String, fecDto.Descripcion);
                db.AddInParameter(command, "@UsuarioModificacion", DbType.String, fecDto.UsuarioModificacion);
                db.AddInParameter(command, "@FechaModificacion", DbType.DateTime, fecDto.FechaModificacion);
            }
            catch
            {
                throw;
            }
        }
    }
}
