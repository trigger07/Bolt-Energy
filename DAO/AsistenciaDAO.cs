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
    public partial class AsistenciaDAO : BaseDAO<AsistenciaDTO>
    {
        #region Constantes
        const string SP_GETALL = "dbo.";
        const string SP_OBTENERFECHAVENCIMIENTOSOCIO = "dbo.";
        const string SP_SAVENEW = "dbo.usp_InsertarAsistencia";
        const string SP_GETSEARCH = "dbo.usp_ObtenerAsistenciaBusqueda";
        const string DELETE = "dbo.usp_BorrarAsistencia";
        #endregion

        #region Constructores
        public AsistenciaDAO() { }
        public AsistenciaDAO(string database) : base(database) { }
        #endregion

        protected override void SaveNew(AsistenciaDTO asistDto)
        {
            DbCommand cmd = db.GetStoredProcCommand(SP_SAVENEW);
            try
            {
                BuildParameters(cmd, asistDto);
                db.ExecuteNonQuery(cmd);
            }
            catch
            {
                throw;
            }
        }

        public DataSet ObtenerAsistenciasBusqueda(int pCodSocio, string pFechaI, string pFechaF, bool pHoy)
        {
            DataSet ds = new DataSet();
            DbCommand command = db.GetStoredProcCommand(SP_GETSEARCH);
            db.AddInParameter(command, "@CodSocio", DbType.Int32, pCodSocio);
            db.AddInParameter(command, "@FechaInicio", DbType.String, pFechaI);
            db.AddInParameter(command, "@FechaFinal", DbType.String, pFechaF);
            db.AddInParameter(command, "@Hoy", DbType.Boolean, pHoy);
            ds = db.ExecuteDataSet(command);

            return ds;
        }

        protected override void SaveExisting(AsistenciaDTO entityDto)
        {
            throw new NotImplementedException();
        }

        protected override void Delete(AsistenciaDTO entityDto)
        {
            throw new NotImplementedException();
        }

        public void BorrarAsistencia(int pCodAsistencia)
        {
            DbCommand cmd = db.GetStoredProcCommand(DELETE);
            try
            {
                db.AddInParameter(cmd, "@CodAsistencia", DbType.Int32, pCodAsistencia);
                db.ExecuteNonQuery(cmd);
            }
            catch
            {
                throw;
            }
        }

        private void BuildParameters(DbCommand command, AsistenciaDTO AsistDto)
        {
            try
            {
                //if (AsistDto.Method == ObjectMethod.New)
                //{
                //    db.AddOutParameter(command, "@Emp_Codigo", DbType.Int32, 10);
                //}
                //else if (AsistDto.Method == ObjectMethod.Delete)
                //{
                //    db.AddInParameter(command, "@Emp_Codigo", DbType.Int32, AsistDto.CodEmpresa);
                //}
                db.AddInParameter(command, "@Descripcion", DbType.String, AsistDto.Descripcion);
                db.AddInParameter(command, "@Fec_Asistencia", DbType.DateTime, AsistDto.FechaAsistencia);
                db.AddInParameter(command, "@Estado", DbType.Boolean, AsistDto.EsActivo);
                db.AddInParameter(command, "@Soc_Codigo", DbType.Int32, AsistDto.CodSocio);
                db.AddInParameter(command, "@UsuarioCreacion", DbType.String, AsistDto.UsuarioCreacion);
                db.AddInParameter(command, "@FecCreacion", DbType.DateTime, AsistDto.FechaCreacion);
            }
            catch
            {
                throw;
            }
        }
    }
}
