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
    public partial class SeguridadDAO : BaseDAO<SeguridadDTO>
    {
        #region Constantes
        const string SP_GETALL = "dbo.usp_ObtenerTodosUsuario";
        const string SP_GETUSERSECURITY = "dbo.usp_ObtenerUsuario";
        const string SP_SAVENEW = "dbo.";
        #endregion

        #region Constructores
        public SeguridadDAO() { }
        public SeguridadDAO(string database) : base(database) { }
        #endregion

        #region GetData

        public SeguridadDTO ObtenerUsuario(string pUsuario, string pContrasenia)
        {
            SeguridadDTO segDto = new SeguridadDTO();
            DbCommand command = db.GetStoredProcCommand(SP_GETUSERSECURITY);

            db.AddInParameter(command, "@Usuario", DbType.String, pUsuario);
            db.AddInParameter(command, "@Password", DbType.String, pContrasenia);
            IDataReader dataReader = null;
            try
            {
                dataReader = db.ExecuteReader(command);
                segDto = Fill(dataReader);
            }
            finally
            {
                if (!dataReader.IsClosed)
                    dataReader.Close();
            }
            return segDto;
        }

        public List<SeguridadDTO> ObtenerTodosUsuarios()
        {
            List<SeguridadDTO> list = new List<SeguridadDTO>();
            SeguridadDTO segDto = new SeguridadDTO();
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

        private SeguridadDTO Fill(IDataReader dataReader)
        {
            SeguridadDTO segDto = null;
            try
            {
                if (dataReader.Read())
                {
                    segDto = new SeguridadDTO();
                    segDto.CodUsuario = (int)dataReader["CodUsuario"];
                    //segDto.Usuario = (string)dataReader["Price"];
                    //segDto.Password = (string)dataReader["LandArea"];
                    segDto.Nombre = (string)dataReader["Nombre"];
                    segDto.Apellido1 = (string)dataReader["Apellido1"];
                    segDto.Apellido2 = (string)dataReader["Apellido2"];
                    segDto.RolDescripcion = (string)dataReader["Rol"];
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

            return segDto;
        }

        private List<SeguridadDTO> FillList(IDataReader dataReader)
        {
            List<SeguridadDTO> segDtoList = new List<SeguridadDTO>();
            try
            {
                if (dataReader.FieldCount > 1)
                {
                    while (dataReader.Read())
                    {
                        SeguridadDTO segDto = new SeguridadDTO();
                        segDto.CodUsuario = (int)dataReader["CodUsuario"];
                        //segDto.Usuario = (string)dataReader["Price"];
                        //segDto.Password = (string)dataReader["LandArea"];
                        segDto.Nombre = (string)dataReader["Nombre"];
                        segDto.Apellido1 = (string)dataReader["Apellido1"];
                        segDto.Apellido2 = (string)dataReader["Apellido2"];
                        segDto.RolDescripcion = (string)dataReader["Rol"];
                        segDtoList.Add(segDto);
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
            return segDtoList;
        }
        #endregion


        protected override void SaveNew(SeguridadDTO entityDto)
        {
            throw new NotImplementedException();
        }

        protected override void SaveExisting(SeguridadDTO entityDto)
        {
            throw new NotImplementedException();
        }

        protected override void Delete(SeguridadDTO entityDto)
        {
            throw new NotImplementedException();
        }
    }
}
