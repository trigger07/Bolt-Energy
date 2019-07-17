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
    public partial class SocioDAO : BaseDAO<SocioDTO>
    {
        #region Constantes
        const string SP_GETALL = "dbo.usp_ObtenerTodosSocio";
        const string SP_GETBYID = "dbo.usp_ObtenerSocio";
        const string SP_SAVENEW = "dbo.usp_InsertarSocio";
        const string SP_SAVEEXISTING = "dbo.usp_ActualizarSocio";
        const string SP_GETSOCIOBUSQUEDA = "dbo.usp_ObtenerSocioBusqueda";
        #endregion

        #region Constructores
        public SocioDAO() { }
        public SocioDAO(string database) : base(database) { }
        #endregion

        #region GetData
        public SocioDTO ObtenerSocio(int pCodSocio)
        {
            SocioDTO SocioDto = new SocioDTO();
            DbCommand command = db.GetStoredProcCommand(SP_GETBYID);

            db.AddInParameter(command, "@CodSocio", DbType.Int32, pCodSocio);
            IDataReader dataReader = null;
            try
            {
                dataReader = db.ExecuteReader(command);
                SocioDto = Fill(dataReader);
            }
            finally
            {
                if (!dataReader.IsClosed)
                    dataReader.Close();
            }
            return SocioDto;
        }

        public List<SocioDTO> ObtenerTodosSocio()
        {
            List<SocioDTO> list = new List<SocioDTO>();
            SocioDTO SocioDto = new SocioDTO();
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

        public DataSet ObtenerSociosBusqueda(string pNombreCompleto, int pCodTipoSocio, int pCodEmpresa, string pFecha)
        {
            DataSet ds = new DataSet();
            DbCommand command = db.GetStoredProcCommand(SP_GETSOCIOBUSQUEDA);
            db.AddInParameter(command, "@NombreCompleto", DbType.String, pNombreCompleto);
            db.AddInParameter(command, "@CodTipoSocio", DbType.Int32, pCodTipoSocio);
            db.AddInParameter(command, "@CodEmpresa", DbType.Int32, pCodEmpresa);
            db.AddInParameter(command, "@Fecha", DbType.String, pFecha);
            ds = db.ExecuteDataSet(command);

            return ds;
        }

        private SocioDTO Fill(IDataReader dataReader)
        {
            SocioDTO SocioDto = null;
            try
            {
                if (dataReader.Read())
                {
                    SocioDto = new SocioDTO();
                    SocioDto.CodSocio = (int)dataReader["Soc_Codigo"];
                    SocioDto.Nombre = (string)dataReader["Soc_Nombre"];
                    SocioDto.Apellido1 = (string)dataReader["Soc_Apellido1"];
                    SocioDto.Apellido2 = (string)dataReader["Soc_Apellido2"];
                    SocioDto.FechaNacimiento = (DateTime)dataReader["Soc_FechaNacimiento"];
                    SocioDto.Correo = (string)dataReader["Soc_Correo"];
                    SocioDto.DiaPago = (int)dataReader["Soc_DiaPago"];
                    SocioDto.TelCelular = (string)dataReader["Soc_TelCelular"];
                    SocioDto.TelResidencia = (string)dataReader["Soc_TelResidencia"];
                    SocioDto.Imagen = (string)dataReader["Soc_Imagen"];
                    SocioDto.EsActivo = (bool)dataReader["Soc_Estado"];
                    SocioDto.CodTipoSocio = (int)dataReader["Tso_Codigo"];
                    SocioDto.CodEmpresa = (int)dataReader["Emp_Codigo"];
                    SocioDto.UsuarioCreacion = (string)dataReader["Soc_UsuarioCreacion"];
                    SocioDto.FechaCreacion = (DateTime)dataReader["Soc_FechaCreacion"];
                    SocioDto.UsuarioModificacion = (string)dataReader["Soc_UsuarioModificacion"];
                    SocioDto.FechaModificacion = (DateTime)dataReader["Soc_FechaModificacion"];
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
            return SocioDto;
        }

        private List<SocioDTO> FillList(IDataReader dataReader)
        {
            List<SocioDTO> SocioDtoList = new List<SocioDTO>();
            try
            {
                if (dataReader.FieldCount > 1)
                {
                    while (dataReader.Read())
                    {
                        SocioDTO SocioDto = new SocioDTO();
                        SocioDto.CodSocio = (int)dataReader["Soc_Codigo"];
                        SocioDto.Nombre = (string)dataReader["Soc_Nombre"];
                        SocioDto.Apellido1 = (string)dataReader["Soc_Apellido1"];
                        SocioDto.Apellido2 = (string)dataReader["Soc_Apellido2"];
                        SocioDto.FechaNacimiento = (DateTime)dataReader["Soc_FechaNacimiento"];
                        SocioDto.Correo = (string)dataReader["Soc_Correo"];
                        SocioDto.DiaPago = (int)dataReader["Soc_DiaPago"];
                        SocioDto.TelCelular = (string)dataReader["Soc_TelCelular"];
                        SocioDto.TelResidencia = (string)dataReader["Soc_TelResidencia"];
                        SocioDto.Imagen = (string)dataReader["Soc_Imagen"];
                        SocioDto.EsActivo = (bool)dataReader["Soc_Estado"];
                        SocioDto.CodTipoSocio = (int)dataReader["Tso_Codigo"];
                        SocioDto.CodEmpresa = (int)dataReader["Emp_Codigo"];
                        SocioDto.UsuarioCreacion = (string)dataReader["Soc_UsuarioCreacion"];
                        SocioDto.FechaCreacion = (DateTime)dataReader["Soc_FechaCreacion"];
                        SocioDto.UsuarioModificacion = (string)dataReader["Soc_UsuarioModificacion"];
                        SocioDto.FechaModificacion = (DateTime)dataReader["Soc_FechaModificacion"];

                        SocioDtoList.Add(SocioDto);
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
            return SocioDtoList;
        }
        #endregion

        protected override void SaveNew(SocioDTO socDto)
        {
            DbCommand cmd = db.GetStoredProcCommand(SP_SAVENEW);
            try
            {
                BuildParameters(cmd, socDto);
                db.ExecuteNonQuery(cmd);
                socDto.CodSocio = (int)db.GetParameterValue(cmd, "@Soc_Codigo");
            }
            catch
            {
                throw;
            }
        }

        protected override void SaveExisting(SocioDTO socDto)
        {
            DbCommand cmd = db.GetStoredProcCommand(SP_SAVEEXISTING);
            try
            {
                BuildParametersUpdate(cmd, socDto);
                db.ExecuteNonQuery(cmd);
            }
            catch
            {
                throw;
            }
        }

        protected override void Delete(SocioDTO entityDto)
        {
            throw new NotImplementedException();
        }

        #region Support Methods
        private void BuildParameters(DbCommand command, SocioDTO socDto)
        {
            try
            {
                if (socDto.Method == ObjectMethod.New)
                {
                    db.AddOutParameter(command, "@Soc_Codigo", DbType.Int32, 10);
                }
                else if (socDto.Method == ObjectMethod.Delete)
                {
                    db.AddInParameter(command, "@Soc_Codigo", DbType.Int32, socDto.CodEmpresa);
                }
                db.AddInParameter(command, "@Nombre", DbType.String, socDto.Nombre);
                db.AddInParameter(command, "@Apellido1", DbType.String, socDto.Apellido1);
                db.AddInParameter(command, "@Apellido2", DbType.String, socDto.Apellido2);
                db.AddInParameter(command, "@FecNacimiento", DbType.DateTime, socDto.FechaNacimiento);
                db.AddInParameter(command, "@Correo", DbType.String, socDto.Correo);
                db.AddInParameter(command, "@DiaPago", DbType.Int32, socDto.DiaPago);
                db.AddInParameter(command, "@TelCelular", DbType.String, socDto.TelCelular);
                db.AddInParameter(command, "@TelResidencia", DbType.String, socDto.TelResidencia);
                db.AddInParameter(command, "@Imagen", DbType.String, socDto.Imagen);
                db.AddInParameter(command, "@Estado", DbType.Boolean, socDto.EsActivo);
                db.AddInParameter(command, "@Tso_Codigo", DbType.Int32, socDto.CodTipoSocio);
                db.AddInParameter(command, "@Emp_Codigo", DbType.Int32, socDto.CodEmpresa);
                db.AddInParameter(command, "@UsuarioCreacion", DbType.String, socDto.UsuarioCreacion);
                db.AddInParameter(command, "@FechaCreacion", DbType.DateTime, socDto.FechaCreacion);
            }
            catch
            {
                throw;
            }
        }

        private void BuildParametersUpdate(DbCommand command, SocioDTO socDto)
        {
            try
            {
                db.AddInParameter(command, "@Soc_Codigo", DbType.String, socDto.CodSocio);
                db.AddInParameter(command, "@Nombre", DbType.String, socDto.Nombre);
                db.AddInParameter(command, "@Apellido1", DbType.String, socDto.Apellido1);
                db.AddInParameter(command, "@Apellido2", DbType.String, socDto.Apellido2);
                db.AddInParameter(command, "@FecNacimiento", DbType.DateTime, socDto.FechaNacimiento);
                db.AddInParameter(command, "@Correo", DbType.String, socDto.Correo);
                db.AddInParameter(command, "@DiaPago", DbType.Int32, socDto.DiaPago);
                db.AddInParameter(command, "@TelCelular", DbType.String, socDto.TelCelular);
                db.AddInParameter(command, "@TelResidencia", DbType.String, socDto.TelResidencia);
                db.AddInParameter(command, "@Imagen", DbType.String, socDto.Imagen);
                db.AddInParameter(command, "@Estado", DbType.Boolean, socDto.EsActivo);
                db.AddInParameter(command, "@Tso_Codigo", DbType.Int32, socDto.CodTipoSocio);
                db.AddInParameter(command, "@Emp_Codigo", DbType.Int32, socDto.CodEmpresa);
                db.AddInParameter(command, "@UsuarioModificacion", DbType.String, socDto.UsuarioModificacion);
                db.AddInParameter(command, "@FecModificacion", DbType.DateTime, socDto.FechaModificacion);
            }
            catch
            {
                throw;
            }
        }
        #endregion
    }
}
