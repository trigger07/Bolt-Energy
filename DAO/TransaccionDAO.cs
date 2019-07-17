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
    public partial class TransaccionDAO : BaseDAO<TransaccionDTO>
    {
        #region Constantes
        const string SP_GETALL = "dbo.usp_ObtenerTodosTransaccion";
        const string SP_GETBYID = "dbo.usp_ObtenerTransaccion";
        const string SP_SAVENEW = "dbo.usp_InsertarTransaccion";
        const string SP_SAVEEXISTING = "dbo.usp_ActualizarTransaccion";
        const string SP_GETSEARCH = "dbo.usp_ObtenerTransaccionesBusqueda";
        const string SP_GETMONTOSOCIO = "dbo.usp_ObtenerMontoSocio";
        const string DELETE = "dbo.usp_BorrarTransaccion"; 
        const string SP_GETTRANSACCIONFACTURA = "dbo.usp_ObtenerTransaccionFactura";
        #endregion

        #region Constructores
        public TransaccionDAO() { }
        public TransaccionDAO(string database) : base(database) { }
        #endregion

        #region GetData
        public void BorrarTransaccion(int pCodTransaccion)
        {
            DbCommand cmd = db.GetStoredProcCommand(DELETE);
            try
            {
                db.AddInParameter(cmd, "@CodTransaccion", DbType.Int32, pCodTransaccion);
                db.ExecuteNonQuery(cmd);
            }
            catch
            {
                throw;
            }
        }

        public TransaccionDTO ObtenerTransaccion(int pCodTransaccion)
        {
            TransaccionDTO tranDto = new TransaccionDTO();
            DbCommand command = db.GetStoredProcCommand(SP_GETBYID);

            db.AddInParameter(command, "@CodTransaccion", DbType.Int32, pCodTransaccion);
            IDataReader dataReader = null;
            try
            {
                dataReader = db.ExecuteReader(command);
                tranDto = Fill(dataReader);
            }
            finally
            {
                if (!dataReader.IsClosed)
                    dataReader.Close();
            }
            return tranDto;
        }

        public List<TransaccionDTO> ObtenerTodosSocio()
        {
            List<TransaccionDTO> list = new List<TransaccionDTO>();
            TransaccionDTO SocioDto = new TransaccionDTO();
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

        public DataSet ObtenerTransaccionesBusqueda(int pCodSocio, int pCodTipoPago, string pFechaI, string pFechaF, string pHoy)
        {
            DataSet ds = new DataSet();
            DbCommand command = db.GetStoredProcCommand(SP_GETSEARCH);
            db.AddInParameter(command, "@CodSocio", DbType.Int32, pCodSocio);
            db.AddInParameter(command, "@CodTipoPago", DbType.Int32, pCodTipoPago);
            db.AddInParameter(command, "@FechaInicio", DbType.String, pFechaI);
            db.AddInParameter(command, "@FechaFinal", DbType.String, pFechaF);
            db.AddInParameter(command, "@Hoy", DbType.String, pHoy);
            ds = db.ExecuteDataSet(command);

            return ds;
        }

        public DataSet ObtenerMontoSocio(int pCodSocio)
        {
            DataSet ds = new DataSet();
            DbCommand command = db.GetStoredProcCommand(SP_GETMONTOSOCIO);
            db.AddInParameter(command, "@CodSocio", DbType.Int32, pCodSocio);
            ds = db.ExecuteDataSet(command);
            return ds;

        }

        public DataSet ObtenerTransaccionFactura(int pCodTransaccion)
        {
            DataSet ds = new DataSet();
            DbCommand command = db.GetStoredProcCommand(SP_GETTRANSACCIONFACTURA);
            db.AddInParameter(command, "@CodTransaccion", DbType.Int32, pCodTransaccion);
            ds = db.ExecuteDataSet(command);
            return ds;

        }

        private TransaccionDTO Fill(IDataReader dataReader)
        {
            TransaccionDTO traDto = null;
            try
            {
                if (dataReader.Read())
                {
                    traDto = new TransaccionDTO();
                    traDto.CodTransaccion = (int)dataReader["Tra_Codigo"];
                    traDto.Descripcion = (string)dataReader["Tra_Descripcion"];
                    traDto.Detalle = (string)dataReader["Tra_Detalle"];
                    traDto.Monto = (decimal)dataReader["Tra_Monto"];
                    traDto.FechaTransaccion = (DateTime)dataReader["Tra_FechaTransaccion"];
                    traDto.EsActivo = (bool)dataReader["Tra_Estado"];
                    traDto.CodTipoPago = (int)dataReader["Tpa_Codigo"];
                    traDto.CodSocio = (int)dataReader["Soc_Codigo"];
                    traDto.NumComprobante = (string)dataReader["Tra_NumComprobante"];
                    traDto.NumReciboGym = (string)dataReader["Tra_NumReciboGym"];
                    traDto.UsuarioCreacion = (string)dataReader["Tra_UsuarioCreacion"];
                    traDto.FechaCreacion = (DateTime)dataReader["Tra_FechaCreacion"];
                    traDto.UsuarioModificacion = (string)dataReader["Tra_UsuarioModificacion"];
                    traDto.FechaModificacion = (DateTime)dataReader["Tra_FechaModificacion"];
                    traDto.CodCatPago = (int)dataReader["Cap_Codigo"];
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
            return traDto;
        }

        private List<TransaccionDTO> FillList(IDataReader dataReader)
        {
            List<TransaccionDTO> tranDtoList = new List<TransaccionDTO>();
            try
            {
                if (dataReader.FieldCount > 1)
                {
                    while (dataReader.Read())
                    {
                        TransaccionDTO traDto = new TransaccionDTO();
                        traDto.CodTransaccion = (int)dataReader["Tra_Codigo"];
                        traDto.Descripcion = (string)dataReader["Tra_Descripcion"];
                        traDto.Detalle = (string)dataReader["Tra_Detalle"];
                        traDto.Monto = (decimal)dataReader["Tra_Monto"];
                        traDto.FechaTransaccion = (DateTime)dataReader["Tra_FechaTransaccion"];
                        traDto.EsActivo = (bool)dataReader["Tra_Estado"];
                        traDto.CodTipoPago = (int)dataReader["Tpa_Codigo"];
                        traDto.CodSocio = (int)dataReader["Soc_Codigo"];
                        traDto.NumComprobante = (string)dataReader["Tra_NumComprobante"];
                        traDto.NumReciboGym = (string)dataReader["Tra_NumReciboGym"];
                        traDto.UsuarioCreacion = (string)dataReader["Tra_UsuarioCreacion"];
                        traDto.FechaCreacion = (DateTime)dataReader["Tra_FechaCreacion"];
                        traDto.UsuarioModificacion = (string)dataReader["Tra_UsuarioModificacion"];
                        traDto.FechaModificacion = (DateTime)dataReader["Tra_FechaModificacion"];
                        traDto.CodCatPago = (int)dataReader["Cap_Codigo"];

                        tranDtoList.Add(traDto);
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
            return tranDtoList;
        }
        #endregion

        protected override void SaveNew(TransaccionDTO tranDto)
        {
            DbCommand cmd = db.GetStoredProcCommand(SP_SAVENEW);
            try
            {
                BuildParameters(cmd, tranDto);
                db.ExecuteNonQuery(cmd);
                tranDto.CodTransaccion = (int)db.GetParameterValue(cmd, "@Tra_Codigo");
            }
            catch
            {
                throw;
            }
        }

        protected override void SaveExisting(TransaccionDTO tranDto)
        {
            DbCommand cmd = db.GetStoredProcCommand(SP_SAVEEXISTING);
            try
            {
                BuildParametersUpdate(cmd, tranDto);
                db.ExecuteNonQuery(cmd);
            }
            catch
            {
                throw;
            }
        }

        protected override void Delete(TransaccionDTO entityDto)
        {
            throw new NotImplementedException();
        }

        #region SupportMethods
        private void BuildParameters(DbCommand command, TransaccionDTO tranDto)
        {
            try
            {
                if (tranDto.Method == ObjectMethod.New)
                {
                    db.AddOutParameter(command, "@Tra_Codigo", DbType.Int32, 15);
                }
                db.AddInParameter(command, "@Descripcion", DbType.String, tranDto.Descripcion);
                db.AddInParameter(command, "@Detalle", DbType.String, tranDto.Detalle);
                db.AddInParameter(command, "@Monto", DbType.Decimal, tranDto.Monto);
                db.AddInParameter(command, "@FecTransaccion", DbType.DateTime, tranDto.FechaTransaccion);
                db.AddInParameter(command, "@Estado", DbType.Boolean, tranDto.EsActivo);
                db.AddInParameter(command, "@Tpa_Codigo", DbType.Int32, tranDto.CodTipoPago);
                db.AddInParameter(command, "@Soc_Codigo", DbType.Int32, tranDto.CodSocio);
                db.AddInParameter(command, "@NumComprobante", DbType.String, tranDto.NumComprobante);
                db.AddInParameter(command, "@NumReciboGym", DbType.String, tranDto.NumReciboGym);
                db.AddInParameter(command, "@UsuarioCreacion", DbType.String, tranDto.UsuarioCreacion);
                db.AddInParameter(command, "@FechaCreacion", DbType.DateTime, tranDto.FechaCreacion);
                db.AddInParameter(command, "@Cap_Codigo", DbType.Int32, tranDto.CodCatPago);
            }
            catch
            {
                throw;
            }
        }

        private void BuildParametersUpdate(DbCommand command, TransaccionDTO tranDto)
        {
            try
            {
                db.AddInParameter(command, "@CodTransaccion", DbType.String, tranDto.CodTransaccion);
                db.AddInParameter(command, "@Descripcion", DbType.String, tranDto.Descripcion);
                db.AddInParameter(command, "@Detalle", DbType.String, tranDto.Detalle);
                db.AddInParameter(command, "@Monto", DbType.Decimal, tranDto.Monto);
                db.AddInParameter(command, "@FecTransaccion", DbType.DateTime, tranDto.FechaTransaccion);
                db.AddInParameter(command, "@Estado", DbType.Boolean, tranDto.EsActivo);
                db.AddInParameter(command, "@Tpa_Codigo", DbType.Int32, tranDto.CodTipoPago);
                db.AddInParameter(command, "@Soc_Codigo", DbType.Int32, tranDto.CodSocio);
                db.AddInParameter(command, "@NumComprobante", DbType.String, tranDto.NumComprobante);
                db.AddInParameter(command, "@NumReciboGym", DbType.String, tranDto.NumReciboGym);
                db.AddInParameter(command, "@UsuarioModificacion", DbType.String, tranDto.UsuarioModificacion);
                db.AddInParameter(command, "@FecModificacion", DbType.DateTime, tranDto.FechaModificacion);
                db.AddInParameter(command, "@Cap_Codigo", DbType.Int32, tranDto.CodCatPago);
            }
            catch
            {
                throw;
            }
        }
        #endregion
    }
}
