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
    public partial class EmpresaDAO : BaseDAO<EmpresaDTO>
    {
        #region Constantes
        const string SP_GETALL = "dbo.usp_ObtenerTodosEmpresa";
        const string SP_GETBYID = "dbo.usp_ObtenerEmpresa";
        const string SP_SAVENEW = "dbo.usp_InsertarEmpresa";
        const string SP_SAVEEXISTING = "dbo.usp_ActualizarEmpresa";
        const string SP_GETEMPRESABUSQUEDA = "dbo.usp_ObtenerEmpresaBusqueda";
        #endregion

        #region Constructores
        public EmpresaDAO() { }
        public EmpresaDAO(string database) : base(database) { }
        #endregion

        #region GetData
        public DataSet ObtenerEmpresasBusqueda(string pNombreEmpresa)
        {
            DataSet ds = new DataSet();
            DbCommand command = db.GetStoredProcCommand(SP_GETEMPRESABUSQUEDA);
            db.AddInParameter(command, "@NombreEmpresa", DbType.String, pNombreEmpresa);
            ds = db.ExecuteDataSet(command);

            return ds;
        }

        public EmpresaDTO ObtenerEmpresa(int pCodEmpresa)
        {
            EmpresaDTO empresaDto = new EmpresaDTO();
            DbCommand command = db.GetStoredProcCommand(SP_GETBYID);

            db.AddInParameter(command, "@CodEmpresa", DbType.Int32, pCodEmpresa);
            IDataReader dataReader = null;
            try
            {
                dataReader = db.ExecuteReader(command);
                empresaDto = Fill(dataReader);
            }
            finally
            {
                if (!dataReader.IsClosed)
                    dataReader.Close();
            }
            return empresaDto;
        }

        public List<EmpresaDTO> ObtenerTodosEmpresa()
        {
            List<EmpresaDTO> list = new List<EmpresaDTO>();
            EmpresaDTO empresaDto = new EmpresaDTO();
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

        private EmpresaDTO Fill(IDataReader dataReader)
        {
            EmpresaDTO empresaDto = null;
            try
            {
                if (dataReader.Read())
                {
                    empresaDto = new EmpresaDTO();
                    empresaDto.CodEmpresa = (int)dataReader["Codigo"];
                    empresaDto.NombreEmpresa = (string)dataReader["NombreEmpresa"];
                    empresaDto.Descripcion = (string)dataReader["Descripcion"];
                    empresaDto.Telefono1 = (string)dataReader["Telefono1"];
                    empresaDto.Telefono2 = (string)dataReader["Telefono2"];
                    empresaDto.Correo = (string)dataReader["Correo"];
                    empresaDto.EsActivo = (bool)dataReader["Estado"];
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
            return empresaDto;
        }

        private List<EmpresaDTO> FillList(IDataReader dataReader)
        {
            List<EmpresaDTO> empresaDtoList = new List<EmpresaDTO>();

            EmpresaDTO d = new EmpresaDTO();
            d.CodEmpresa = 0;
            d.NombreEmpresa = "Seleccione";
            empresaDtoList.Add(d);

            try
            {
                if (dataReader.FieldCount > 1)
                {
                    while (dataReader.Read())
                    {
                        EmpresaDTO empresaDto = new EmpresaDTO();
                        empresaDto.CodEmpresa = (int)dataReader["Codigo"];
                        empresaDto.NombreEmpresa = (string)dataReader["NombreEmpresa"];
                        empresaDto.Descripcion = (string)dataReader["Descripcion"];
                        empresaDto.Telefono1 = (string)dataReader["Telefono1"];
                        empresaDto.Telefono2 = (string)dataReader["Telefono2"];
                        empresaDto.Correo = (string)dataReader["Correo"];
                        empresaDto.EsActivo = (bool)dataReader["Estado"];
                        empresaDtoList.Add(empresaDto);
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
            return empresaDtoList;
        }
        #endregion

        #region Insertar
        protected override void SaveNew(EmpresaDTO empDTO)
        {
            DbCommand cmd = db.GetStoredProcCommand(SP_SAVENEW);
            try
            {
                BuildParameters(cmd, empDTO);
                db.ExecuteNonQuery(cmd);
                empDTO.CodEmpresa = (int)db.GetParameterValue(cmd, "@Emp_Codigo");
            }
            catch
            {
                throw;
            }
        }
        #endregion

        protected override void SaveExisting(EmpresaDTO empDto)
        {
            DbCommand cmd = db.GetStoredProcCommand(SP_SAVEEXISTING);
            try
            {
                BuildParametersUpdate(cmd, empDto);
                db.ExecuteNonQuery(cmd);
            }
            catch
            {
                throw;
            }
        }

        protected override void Delete(EmpresaDTO entityDto)
        {
            throw new NotImplementedException();
        }


        #region MetodosSoporte
        private void BuildParameters(DbCommand command, EmpresaDTO  empDto)
        {
            try
            {
                if (empDto.Method == ObjectMethod.New)
                {
                    db.AddOutParameter(command, "@Emp_Codigo", DbType.Int32, 10);
                }
                else if(empDto.Method == ObjectMethod.Delete)
                {
                    db.AddInParameter(command, "@Emp_Codigo", DbType.Int32, empDto.CodEmpresa);
                }
                db.AddInParameter(command, "@NombreEmpresa", DbType.String, empDto.NombreEmpresa);
                db.AddInParameter(command, "@Descripcion", DbType.String, empDto.Descripcion);
                db.AddInParameter(command, "@Telefono1", DbType.String, empDto.Telefono1);
                db.AddInParameter(command, "@Telefono2", DbType.String, empDto.Telefono2);
                db.AddInParameter(command, "@Correo", DbType.String, empDto.Correo);
                db.AddInParameter(command, "@Estado", DbType.Boolean, empDto.EsActivo);
                db.AddInParameter(command, "@UsuarioCreacion", DbType.String, empDto.UsuarioCreacion);
                db.AddInParameter(command, "@FecCreacion", DbType.DateTime, empDto.FechaCreacion);
            }
            catch
            {
                throw;
            }
        }

        private void BuildParametersUpdate(DbCommand command, EmpresaDTO empDto)
        {
            try
            {
                db.AddInParameter(command, "@Emp_Codigo", DbType.Int32, empDto.CodEmpresa);
                db.AddInParameter(command, "@NombreEmpresa", DbType.String, empDto.NombreEmpresa);
                db.AddInParameter(command, "@Descripcion", DbType.String, empDto.Descripcion);
                db.AddInParameter(command, "@Telefono1", DbType.String, empDto.Telefono1);
                db.AddInParameter(command, "@Telefono2", DbType.String, empDto.Telefono2);
                db.AddInParameter(command, "@Correo", DbType.String, empDto.Correo);
                db.AddInParameter(command, "@Estado", DbType.Boolean, empDto.EsActivo);
                db.AddInParameter(command, "@UsuarioModificacion", DbType.String, empDto.UsuarioModificacion);
                db.AddInParameter(command, "@FecModificacion", DbType.DateTime, empDto.FechaModificacion);
            }
            catch
            {
                throw;
            }
        }
        #endregion
    }
}
