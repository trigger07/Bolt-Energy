using Common;
using Data.DAO;
using Data.DTO;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GYM.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SoapService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SoapService.svc or SoapService.svc.cs at the Solution Explorer and start debugging.
    public class SoapService : ISoapService
    {
        #region Usuarios
        public SeguridadDTO ObtenerUsuario(string pUsuario, string pContrasenia)
        {
            SeguridadDAO dao = new SeguridadDAO();
            return dao.ObtenerUsuario(pUsuario, pContrasenia);
        }
        #endregion

        #region Asistencia
        public string ObtenerAsistenciasBusqueda(int pCodSocio, string pFechaI, string pFechaF, bool pHoy)
        {
            AsistenciaDAO dao = new AsistenciaDAO();
            return DTOSerializer.Serialize(dao.ObtenerAsistenciasBusqueda(pCodSocio, pFechaI, pFechaF, pHoy)).InnerXml;
        }

        public void BorrarAsistencia(int pCodAsistencia)
        {
            AsistenciaDAO dao = new AsistenciaDAO();
            dao.BorrarAsistencia(pCodAsistencia);
        }

        public void SaveAttendance(AsistenciaDTO asistDto)
        {
            AsistenciaDAO dao = new AsistenciaDAO();
            dao.Save(asistDto);
        }
        #endregion

        #region Empresas
        public string ObtenerContactoEmpresasBusqueda(string pNombreCompleto, int pCodEmpresa)
        {
            ContactoEmpresaDAO dao = new ContactoEmpresaDAO();
            return DTOSerializer.Serialize(dao.ObtenerEmpresasBusqueda(pNombreCompleto, pCodEmpresa)).InnerXml;
        }

        public List<EmpresaDTO> ObtenerTodosEmpresa()
        {
            EmpresaDAO dao = new EmpresaDAO();
            return dao.ObtenerTodosEmpresa();
        }

        public string ObtenerEmpresasBusqueda(string pNombreEmpresa)
        {
            EmpresaDAO dao = new EmpresaDAO();
            return DTOSerializer.Serialize(dao.ObtenerEmpresasBusqueda(pNombreEmpresa)).InnerXml;
        }

        public ContactoEmpresaDTO ObtenerContacto(int pCodContacto)
        {
            ContactoEmpresaDAO dao = new ContactoEmpresaDAO();
            return dao.ObtenerContacto(pCodContacto);
        }

        public void SaveContact(ContactoEmpresaDTO cxeDto)
        {
            ContactoEmpresaDAO dao = new ContactoEmpresaDAO();
            dao.Save(cxeDto);
        }

        public void SaveEnterprise(EmpresaDTO empDto)
        {
            EmpresaDAO dao = new EmpresaDAO();
            dao.Save(empDto);
        }

        public EmpresaDTO ObtenerEmpresa(int pCodEmpresa)
        {
            EmpresaDAO dao = new EmpresaDAO();
            return dao.ObtenerEmpresa(pCodEmpresa);
        }
        #endregion

        #region TipoSocio
        public TipoSocioDTO ObtenerTipoSocio(int pCodTipoSocio)
        {
            TipoSocioDAO dao = new TipoSocioDAO();
            return dao.ObtenerTipoSocio(pCodTipoSocio);
        }

        public List<TipoSocioDTO> ObtenerTodosTipoSocio()
        {
            TipoSocioDAO dao = new TipoSocioDAO();
            return dao.ObtenerTodosTipoSocio();
        }
        #endregion

        #region Socios
        public string ObtenerSociosBusqueda(string pNombreCompleto, int pCodTipoSocio, int pCodEmpresa, string pFecha)
        {
            SocioDAO dao = new SocioDAO();
            return DTOSerializer.Serialize(dao.ObtenerSociosBusqueda(pNombreCompleto, pCodTipoSocio, pCodEmpresa, pFecha)).InnerXml;
        }

        public SocioDTO ObtenerSocio(int pCodSocio)
        {
            SocioDAO dao = new SocioDAO();
            return dao.ObtenerSocio(pCodSocio);
        }

        public FechaVencimientoDTO ObtenerFecha(int pCodSocio)
        {
            FechaVencimientoDAO dao = new FechaVencimientoDAO();
            return dao.ObtenerFecha(pCodSocio);
        }

        public FechaVencimientoDTO ObtenerFecVencimiento(int pCodSocio, int pCodCortesia)
        {
            FechaVencimientoDAO dao = new FechaVencimientoDAO();
            return dao.ObtenerFecVencimiento(pCodSocio, pCodCortesia);
        }

        public void SaveExpireDate(FechaVencimientoDTO fecDto)
        {
            FechaVencimientoDAO dao = new FechaVencimientoDAO();
            dao.Save(fecDto);
        }

        public int SaveSocio(SocioDTO socDto)
        {
            SocioDAO dao = new SocioDAO();
            dao.Save(socDto);
            int id = socDto.CodSocio;
            return id;
        }
        #endregion 

        #region Transacciones
        public string ObtenerTransaccionesBusqueda(int pCodSocio, int pCodTipoPago, string pFechaI, string pFechaF, string pHoy)
        {
            TransaccionDAO dao = new TransaccionDAO();
            return DTOSerializer.Serialize(dao.ObtenerTransaccionesBusqueda(pCodSocio, pCodTipoPago, pFechaI, pFechaF, pHoy)).InnerXml;
        }

        public void BorrarTransaccion(int pCodTransaccion)
        {
            TransaccionDAO dao = new TransaccionDAO();
            dao.BorrarTransaccion(pCodTransaccion);
        }

        public string ObtenerMontoSocio(int pCodSocio)
        {
            TransaccionDAO dao = new TransaccionDAO();
            return DTOSerializer.Serialize(dao.ObtenerMontoSocio(pCodSocio)).InnerXml;
        }

        public TransaccionDTO ObtenerTransaccion(int pCodTransaccion)
        {
            TransaccionDAO dao = new TransaccionDAO();
            return dao.ObtenerTransaccion(pCodTransaccion);
        }

        public int SaveTransaction(TransaccionDTO tranDto)
        {
            TransaccionDAO dao = new TransaccionDAO();
            dao.Save(tranDto);
            int id = tranDto.CodTransaccion;

            if (ConfigurationManager.AppSettings["sendEmail"].ToString() == "1")
            {
                SendInvoice(id);
            }
            return id;
        }

        private void SendInvoice(int pCodTransaction)
        {
            TransaccionDAO dao = new TransaccionDAO();
            var dto = dao.ObtenerTransaccionFactura(pCodTransaction);
            var attach = new Email.Service.Attachment();
            Email.Service.ServiceClient proxy = new Email.Service.ServiceClient();

            string dateInvoice = string.Empty;
            string name = string.Empty;
            string detalle = string.Empty;
            string monto = string.Empty;
            byte[] bytes;

            if (dto.Tables[0].Rows[0]["Tra_FechaTransaccion"].ToString() != null)
                dateInvoice = dto.Tables[0].Rows[0]["Tra_FechaTransaccion"].ToString();

            if (dto.Tables[0].Rows[0]["Nombre_Completo"].ToString() != null)
                name = dto.Tables[0].Rows[0]["Nombre_Completo"].ToString();

            if (dto.Tables[0].Rows[0]["Tra_Detalle"].ToString() != null)
                detalle = dto.Tables[0].Rows[0]["Tra_Detalle"].ToString();

            if (dto.Tables[0].Rows[0]["Tra_Monto"].ToString() != null)
                monto = dto.Tables[0].Rows[0]["Tra_Monto"].ToString();

            if (dto.Tables[0].Rows[0]["Correo"].ToString() != null)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("<div style='width: 80%; margin-left: auto; margin-right: auto;'>");
                sb.Append("<table style='width: 100%; border: none;'><tbody>");
                sb.Append("<tr><td style='width: 59.7188%;'>&nbsp;</td><td style='width: 39.2813%; text-align: right;'><h2 style='color: #5e9ca0;'>FACTURA</h2>");
                sb.Append("<strong>#</strong>&nbsp;" + pCodTransaction.ToString() + "<br /><strong>Fecha:</strong>&nbsp;" + dateInvoice + "</td></tr></tbody></table>");
                sb.Append("<table style='width: 100%; margin-left: auto; margin-right: auto;'><tbody><tr><td><p>&nbsp;<strong>BOLT ENERGY</strong></p>");
                sb.Append("<p>&nbsp;Los Peluche JR S.A.<br />&nbsp;3-101-755538<br />&nbsp;8777-6334<br />&nbsp;200 m Este del KFC Barrio La California, Los Yoses</p></td></tr></tbody></table>");
                sb.Append("<hr /><table style='width: 100%; border: none;'><tbody><tr><td style='width: 65.3854%;'><strong>&nbsp;Cliente:</strong>&nbsp; " + name + "</td>");
                sb.Append("<td style='width: 34.6146%; text-align: right;'><strong>Tipo: </strong>CONTADO</td></tr></tbody></table><br /><br />");
                sb.Append("<table style='width: 100%; border: 1px solid; border-collapse: collapse; border-color: #5e9ca0;'><tbody>");
                sb.Append("<tr style='height: 26px; border: 1px solid; border-color: #5e9ca0;'>");
                sb.Append("<td style='width: 18%; text-align: center; height: 26px; border: 1px solid; border-color: #5e9ca0;'><strong>Cantidad</strong></td>");
                sb.Append("<td style='width: 52%; text-align: center; height: 26px; border: 1px solid; border-color: #5e9ca0;'><strong>Descripci&oacute;n</strong></td>");
                sb.Append("<td style='width: 30%; text-align: center; height: 26px; border: 1px solid; border-color: #5e9ca0;'><strong>Monto</strong></td></tr>");
                sb.Append("<tr style='height: 132px; vertical-align: top; border: 1px solid; border-color: #5e9ca0;'>");
                sb.Append("<td style='width: 18%; text-align: center; height: 132px; border: 1px solid; border-color: #5e9ca0;'><strong>1</strong></td>");
                sb.Append("<td style='width: 52%; height: 132px; border: 1px solid; border-color: #5e9ca0;'>&nbsp;" + detalle + "</td>");
                sb.Append("<td style='width: 30%; text-align: right; height: 132px; border: 1px solid; border-color: #5e9ca0;'>₡ &nbsp;" + monto + "</td>");
                sb.Append("</tr><tr style='height: 18px;'>");
                sb.Append("<td style='width: 70%; text-align: right; height: 18px; border: 1px solid; border-color: #5e9ca0;' colspan='2'><strong>Total:</strong>&nbsp;</td>");
                sb.Append("<td style='width: 30%; text-align: right; height: 18px; border: 1px solid; border-color: #5e9ca0;'><strong>₡ &nbsp;" + monto + "</strong></td>");
                sb.Append("</tr></tbody></table><br />");
                sb.Append("<p>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;");
                sb.Append("&nbsp;Autorizado por la Direcci&oacute;n General de Tributaci&oacute;n Directa</p></div>");

                StringReader sr = new StringReader(sb.ToString());
                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, memoryStream);
                    pdfDoc.Open();

                    htmlparser.Parse(sr);
                    pdfDoc.Close();

                    bytes = memoryStream.ToArray();
                    memoryStream.Close();
                }
                attach.content = Convert.ToBase64String(bytes);
                attach.contentid = null;
                attach.disposition = null;
                attach.filename = "Factura_BoltEnergy_" + pCodTransaction.ToString() + ".pdf";
                attach.type = "application/pdf";

                var list = new List<Email.Service.Attachment>() { attach }.ToArray();
                string content = "Por este medio le brindamos la factura digital. Muchas gracias.";

                proxy.SendAttach("Factura Bolt Energy", dto.Tables[0].Rows[0]["Correo"].ToString(), content, list, "facturacion@bolt-energy.com", "Factura Bolt Energy");
            }
        }

        #endregion

        #region TipoPago
        public List<TipoPagoDTO> ObtenerTodosTiposPago()
        {
            TipoPagoDAO dao = new TipoPagoDAO();
            return dao.ObtenerTodosTiposPago();
        }
        #endregion

        #region CategoriaPago
        public List<CategoriaPagoDTO> ObtenerTodasCatPago()
        {
            CategoriaPagoDAO dao = new CategoriaPagoDAO();
            return dao.ObtenerTodasCatPago();
        }
        #endregion
    }
}
