using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BodyEnergy
{
    public class VariablesGlobales
    {
        
        //Login
        public static string usuario;
        public static string usuarioBD;
        public static string rolDescripcion;
        //Asistencia
        public static int CodSocio = 0;

        //Manejo de errores
        public static string mensajeError = string.Empty;

        //Pantalla de confirmacion de asistencia
        public static bool alDia = false;
        public static bool socioExiste = false;
        public static bool moroso = false;
        public static bool venceDiaSiguiente = false;
        public static bool venceHoy = false;

        //Mensajes de confirmacion de pantalla de asistencia
        public static string mensajeBienvenida = "Bienvenido.";

        //Manejo de socios en el menú 0 = Nuevo, 1 = Editar.... Empresa 0 = No tiene empresa, 1 = tiene empresa
        public static int Socio = 0;
        public static int Empresa = 0;

        //Manejo de imagenes en pantalla de socios
        public static string NombreImagen = string.Empty;
        public static string RutaImagen = string.Empty;
        public static string NombreImagenAnterior = string.Empty;
        public static string RutaImagenAnterior = string.Empty;
        public static bool CargarImagen = false;

        //Busqueda de socios... 0 de menú, 1 de asistencia, 2 de pagos, 3 de edicion
        public static int busquedaSocios = 0;
        public static int CodEmpresa = 0; // 0 nuevo, > 0 editar
        public static int CodContacto = 0;
        public static int CodTransaccion = 0;
    }
}
