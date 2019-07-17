using Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GYM.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISoapService" in both code and config file together.
    [ServiceContract]
    public interface ISoapService
    {
        #region Usuarios
        [OperationContract]
        SeguridadDTO ObtenerUsuario(string pUsuario, string pContrasenia);
        #endregion

        #region Asistencia
        [OperationContract]
        string ObtenerAsistenciasBusqueda(int pCodSocio, string pFechaI, string pFechaF, bool pHoy);

        [OperationContract]
        void BorrarAsistencia(int pCodAsistencia);

        [OperationContract]
        void SaveAttendance(AsistenciaDTO asistDto);
        #endregion

        #region Empresas
        [OperationContract]
        string ObtenerContactoEmpresasBusqueda(string pNombreCompleto, int pCodEmpresa);

        [OperationContract]
        List<EmpresaDTO> ObtenerTodosEmpresa();

        [OperationContract]
        string ObtenerEmpresasBusqueda(string pNombreEmpresa);

        [OperationContract]
        ContactoEmpresaDTO ObtenerContacto(int pCodContacto);

        [OperationContract]
        void SaveContact(ContactoEmpresaDTO cxeDto);

        [OperationContract]
        void SaveEnterprise(EmpresaDTO empDto);

        [OperationContract]
        EmpresaDTO ObtenerEmpresa(int pCodEmpresa);
        #endregion

        #region TipoSocio
        [OperationContract]
        TipoSocioDTO ObtenerTipoSocio(int pCodTipoSocio);

        [OperationContract]
        List<TipoSocioDTO> ObtenerTodosTipoSocio();
        #endregion

        #region Socios
        [OperationContract]
        string ObtenerSociosBusqueda(string pNombreCompleto, int pCodTipoSocio, int pCodEmpresa, string pFecha);

        [OperationContract]
        SocioDTO ObtenerSocio(int pCodSocio);

        [OperationContract]
        FechaVencimientoDTO ObtenerFecha(int pCodSocio);

        [OperationContract]
        FechaVencimientoDTO ObtenerFecVencimiento(int pCodSocio, int pCodCortesia);

        [OperationContract]
        void SaveExpireDate(FechaVencimientoDTO fecDto);

        [OperationContract]
        int SaveSocio(SocioDTO socDto);
        #endregion

        #region Transacciones
        [OperationContract]
        string ObtenerTransaccionesBusqueda(int pCodSocio, int pCodTipoPago, string pFechaI, string pFechaF, string pHoy);

        [OperationContract]
        void BorrarTransaccion(int pCodTransaccion);

        [OperationContract]
        string ObtenerMontoSocio(int pCodSocio);

        [OperationContract]
        TransaccionDTO ObtenerTransaccion(int pCodTransaccion);

        [OperationContract]
        int SaveTransaction(TransaccionDTO tranDto);

        //[OperationContract]
        //void SendInvoice(int pCodTransaction);
        #endregion

        #region TipoPago
        [OperationContract]
        List<TipoPagoDTO> ObtenerTodosTiposPago();
        #endregion

        #region CategoriaPago
        [OperationContract]
        List<CategoriaPagoDTO> ObtenerTodasCatPago();
        #endregion
    }
}
