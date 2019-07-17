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
    public class ContactoEmpresaDAO : BaseDAO<ContactoEmpresaDTO>
    {
        #region Constantes
        const string SP_GETALL = "dbo.usp_ObtenerTodosContactoXEmpresa";
        const string SP_GETBYID = "dbo.usp_ObtenerContactoXEmpresa";
        const string SP_SAVENEW = "dbo.usp_InsertarContactoEmpresa";
        const string SP_SAVEEXISTING = "dbo.usp_ActualizarContactoEmpresa";
        const string SP_GETCONTACTOBUSQUEDA = "dbo.usp_ObtenerContactoEmpresaBusqueda";
        #endregion

        #region Constructores
        public ContactoEmpresaDAO() { }
        public ContactoEmpresaDAO(string database) : base(database) { }
        #endregion

        #region GetData
        public DataSet ObtenerEmpresasBusqueda(string pNombreCompleto, int pCodEmpresa)
        {
            DataSet ds = new DataSet();
            DbCommand command = db.GetStoredProcCommand(SP_GETCONTACTOBUSQUEDA);
            db.AddInParameter(command, "@NombreCompleto", DbType.String, pNombreCompleto);
            db.AddInParameter(command, "@CodEmpresa", DbType.Int32, pCodEmpresa);
            ds = db.ExecuteDataSet(command);

            return ds;
        }

        public ContactoEmpresaDTO ObtenerContacto(int pCodContacto)
        {
            ContactoEmpresaDTO cxeDto = new ContactoEmpresaDTO();
            DbCommand command = db.GetStoredProcCommand(SP_GETBYID);

            db.AddInParameter(command, "@CodContacto", DbType.Int32, pCodContacto);
            IDataReader dataReader = null;
            try
            {
                dataReader = db.ExecuteReader(command);
                cxeDto = Fill(dataReader);
            }
            finally
            {
                if (!dataReader.IsClosed)
                    dataReader.Close();
            }
            return cxeDto;
        }

        public List<ContactoEmpresaDTO> ObtenerTodosContacto()
        {
            List<ContactoEmpresaDTO> list = new List<ContactoEmpresaDTO>();
            ContactoEmpresaDTO cxeDto = new ContactoEmpresaDTO();
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

        private ContactoEmpresaDTO Fill(IDataReader dataReader)
        {
            ContactoEmpresaDTO cxeDto = null;
            try
            {
                if (dataReader.Read())
                {
                    cxeDto = new ContactoEmpresaDTO();
                    cxeDto.CodContactoEmpresa = (int)dataReader["Cem_Codigo"];
                    cxeDto.Nombre = (string)dataReader["Cem_Nombre"];
                    cxeDto.Apellido1 = (string)dataReader["Cem_Apellido1"];
                    cxeDto.Apellido2 = (string)dataReader["Cem_Apellido2"];
                    cxeDto.Telefono1 = (string)dataReader["Cem_Telefono1"];
                    cxeDto.Telefono2 = (string)dataReader["Cem_Telefono2"];
                    cxeDto.Correo = (string)dataReader["Cem_Correo"];
                    cxeDto.EsActivo = (bool)dataReader["Cem_Estado"];
                    cxeDto.CodEmpresa = (int)dataReader["Emp_Codigo"];
                    cxeDto.UsuarioCreacion = (string)dataReader["Cem_UsuarioCreacion"];
                    cxeDto.FechaCreacion = (DateTime)dataReader["Cem_FechaCreacion"];
                    cxeDto.UsuarioModificacion = (string)dataReader["Cem_UsuarioModificacion"];
                    cxeDto.FechaModificacion = (DateTime)dataReader["Cem_FechaModificacion"];
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
            return cxeDto;
        }

        private List<ContactoEmpresaDTO> FillList(IDataReader dataReader)
        {
            List<ContactoEmpresaDTO> cxeDtoList = new List<ContactoEmpresaDTO>();
            try
            {
                if (dataReader.FieldCount > 1)
                {
                    while (dataReader.Read())
                    {
                        ContactoEmpresaDTO cxeDto = new ContactoEmpresaDTO();
                        cxeDto.CodContactoEmpresa = (int)dataReader["Cem_Codigo"];
                        cxeDto.Nombre = (string)dataReader["Cem_Nombre"];
                        cxeDto.Apellido1 = (string)dataReader["Cem_Apellido1"];
                        cxeDto.Apellido2 = (string)dataReader["Cem_Apellido2"];
                        cxeDto.Telefono1 = (string)dataReader["Cem_Telefono1"];
                        cxeDto.Telefono2 = (string)dataReader["Cem_Telefono2"];
                        cxeDto.Correo = (string)dataReader["Cem_Correo"];
                        cxeDto.EsActivo = (bool)dataReader["Cem_Estado"];
                        cxeDto.CodEmpresa = (int)dataReader["Emp_Codigo"];
                        cxeDto.UsuarioCreacion = (string)dataReader["Cem_UsuarioCreacion"];
                        cxeDto.FechaCreacion = (DateTime)dataReader["Cem_FechaCreacion"];
                        cxeDto.UsuarioModificacion = (string)dataReader["Cem_UsuarioModificacion"];
                        cxeDto.FechaModificacion = (DateTime)dataReader["Cem_FechaModificacion"];

                        cxeDtoList.Add(cxeDto);
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
            return cxeDtoList;
        }
        #endregion

        #region Save
        protected override void SaveNew(ContactoEmpresaDTO cxeDto)
        {
            DbCommand cmd = db.GetStoredProcCommand(SP_SAVENEW);
            try
            {
                BuildParameters(cmd, cxeDto);
                db.ExecuteNonQuery(cmd);
                //cxeDto.CodContactoEmpresa = (int)db.GetParameterValue(cmd, "@CodContacto");
            }
            catch
            {
                throw;
            }
        }

        protected override void SaveExisting(ContactoEmpresaDTO cxeDto)
        {
            DbCommand cmd = db.GetStoredProcCommand(SP_SAVEEXISTING);
            try
            {
                BuildParametersUpdate(cmd, cxeDto);
                db.ExecuteNonQuery(cmd);
            }
            catch
            {
                throw;
            }
        }

        protected override void Delete(ContactoEmpresaDTO entityDto)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region SupportMethods
        private void BuildParameters(DbCommand command, ContactoEmpresaDTO cxeDto)
        {
            try
            {
                //if (cxeDto.Method == ObjectMethod.New)
                //{
                //    db.AddOutParameter(command, "@Soc_Codigo", DbType.Int32, 10);
                //}
                //else if (cxeDto.Method == ObjectMethod.Delete)
                //{
                //    db.AddInParameter(command, "@Soc_Codigo", DbType.Int32, cxeDto.CodEmpresa);
                //}
                db.AddInParameter(command, "@Nombre", DbType.String, cxeDto.Nombre);
                db.AddInParameter(command, "@Apellido1", DbType.String, cxeDto.Apellido1);
                db.AddInParameter(command, "@Apellido2", DbType.String, cxeDto.Apellido2);
                db.AddInParameter(command, "@Telefono1", DbType.String, cxeDto.Telefono1);
                db.AddInParameter(command, "@Telefono2", DbType.String, cxeDto.Telefono2);
                db.AddInParameter(command, "@Correo", DbType.String, cxeDto.Correo);
                db.AddInParameter(command, "@Estado", DbType.Boolean, cxeDto.EsActivo);
                db.AddInParameter(command, "@Emp_Codigo", DbType.Int32, cxeDto.CodEmpresa);
                db.AddInParameter(command, "@UsuarioCreacion", DbType.String, cxeDto.UsuarioCreacion);
                db.AddInParameter(command, "@FecCreacion", DbType.DateTime, cxeDto.FechaCreacion);
            }
            catch
            {
                throw;
            }
        }

        private void BuildParametersUpdate(DbCommand command, ContactoEmpresaDTO cxeDto)
        {
            try
            {
                db.AddInParameter(command, "@Cem_Codigo", DbType.Int32, cxeDto.CodContactoEmpresa);
                db.AddInParameter(command, "@Nombre", DbType.String, cxeDto.Nombre);
                db.AddInParameter(command, "@Apellido1", DbType.String, cxeDto.Apellido1);
                db.AddInParameter(command, "@Apellido2", DbType.String, cxeDto.Apellido2);
                db.AddInParameter(command, "@Telefono1", DbType.String, cxeDto.Telefono1);
                db.AddInParameter(command, "@Telefono2", DbType.String, cxeDto.Telefono2);
                db.AddInParameter(command, "@Correo", DbType.String, cxeDto.Correo);
                db.AddInParameter(command, "@Estado", DbType.Boolean, cxeDto.EsActivo);
                db.AddInParameter(command, "@Emp_Codigo", DbType.Int32, cxeDto.CodEmpresa);
                db.AddInParameter(command, "@UsuarioModificacion", DbType.String, cxeDto.UsuarioModificacion);
                db.AddInParameter(command, "@FecModificacion", DbType.DateTime, cxeDto.FechaModificacion);
            }
            catch
            {
                throw;
            }
        }
        #endregion  
    }
}
