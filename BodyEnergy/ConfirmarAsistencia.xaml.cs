using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using Data.DTO;
using System.Configuration;
using System.Data;
using System.IO;
using MahApps.Metro.Controls;
using Common;

namespace BodyEnergy
{
    /// <summary>
    /// Interaction logic for ConfirmarAsistencia.xaml
    /// </summary>
    public partial class ConfirmarAsistencia : MetroWindow
    {
        #region Load
        public ConfirmarAsistencia()
        {
            InitializeComponent();
            try
            {
                InicioComponentes();
                CargarSocio();
                this.btn_Cerrar.IsDefault = true;
            }
            catch
            {
                MessageBox.Show("En este momento la operación no puede ser realizada.", "Climb", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            
        }
        #endregion

        #region Metodos
        private void InicioComponentes()
        {
            try
            {
                this.AldiaVisible(false);
                this.VenceHoy(false);
                this.VenceManana(false);
                this.Moroso(false);

                if (VariablesGlobales.alDia)
                {
                    this.lbl_MensajeBienvenida.Content = VariablesGlobales.mensajeBienvenida;
                    this.btn_Cerrar.IsDefault = true;

                    this.AldiaVisible(true);
                    this.VenceHoy(false);
                    this.VenceManana(false);
                    this.Moroso(false);
                }
                else if (VariablesGlobales.venceHoy)
                {
                    this.lbl_MensajeBienvenida.Content = VariablesGlobales.mensajeBienvenida;

                    this.AldiaVisible(false);
                    this.VenceHoy(true);
                    this.VenceManana(false);
                    this.Moroso(false);
                }
                else if (VariablesGlobales.venceDiaSiguiente)
                {
                    this.lbl_MensajeBienvenida.Content = VariablesGlobales.mensajeBienvenida;

                    this.AldiaVisible(false);
                    this.VenceHoy(false);
                    this.VenceManana(true);
                    this.Moroso(false);
                }
                else if (VariablesGlobales.moroso)
                {
                   
                    this.lbl_MensajeBienvenida.Content = VariablesGlobales.mensajeBienvenida;

                    this.AldiaVisible(false);
                    this.VenceHoy(false);
                    this.VenceManana(false);
                    this.Moroso(true);
                }

                VariablesGlobales.alDia = false;
                VariablesGlobales.moroso = false;
                VariablesGlobales.venceDiaSiguiente = false;
                VariablesGlobales.venceHoy = false;
            }
            catch
            {
                throw;
            }
        }

        private void CargarSocio()
        {
            try
            {
                Gym.Service.SoapServiceClient proxy = new Gym.Service.SoapServiceClient();
               
                SocioDTO sDto = new SocioDTO();
                FechaVencimientoDTO fDto = new FechaVencimientoDTO();

                DataSet ds = new DataSet();
                DataTable dt = new DataTable();

                string rutaImagen = string.Empty;
                rutaImagen = ConfigurationManager.AppSettings["RutaImagen"].ToString();

                ds = (DataSet)DTOSerializer.Deserialize(proxy.ObtenerMontoSocio(Convert.ToInt32(VariablesGlobales.CodSocio)), typeof(DataSet));
                sDto = proxy.ObtenerSocio(Convert.ToInt32(VariablesGlobales.CodSocio));
                fDto = proxy.ObtenerFecha(Convert.ToInt32(VariablesGlobales.CodSocio));

                proxy.Close();
                dt = ds.Tables[0];
                string monto = string.Empty;

                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["Tra_Monto"] != null)
                    {
                        monto = dt.Rows[0]["Tra_Monto"].ToString();
                        monto = monto.Substring(0, 2);
                        this.lbl_Monto.Visibility = Visibility.Collapsed;
                    }
                    else
                        this.lbl_Monto.Visibility = Visibility.Collapsed;
                }
                if (sDto == null || fDto == null)
                {
                    MessageBox.Show("No se pudo cargar la información de pago.", "Climb", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    if (sDto.Imagen != string.Empty)
                    {
                        if (File.Exists(rutaImagen + sDto.Imagen))
                            this.img_socio.Source = new BitmapImage(new Uri(rutaImagen + sDto.Imagen));
                        else
                        {
                            this.img_socio.Source = null;
                        }
                        //this.img_socio.Source = new BitmapImage(new Uri(rutaImagen + sDto.Imagen));
                    }
                    else
                    {
                        this.img_socio.Source = null;
                    }
                    this.lbl_NombreSocio.Content = sDto.CodSocio.ToString() + "-" + sDto.Nombre + " " + sDto.Apellido1 + " " + sDto.Apellido2 + " - Fecha: " + fDto.FechaVencimiento.ToString("dd/MMMM/yyyy");
                    //this.lbl_NombreSocio.Content = sDto.Nombre + " " + sDto.Apellido1 + " " + sDto.Apellido2 + " (" + sDto.CodSocio.ToString() + ")";
                    this.lbl_DiaPago.Content = "(D:" + fDto.Dia.ToString() + ")";
                    this.lbl_Monto.Content = "(M:" + monto + ")";
                }
            }
            catch
            {
                throw;
            }
        }

        private void AldiaVisible(bool visible)
        {
            if (visible)
                this.lbl_AlDia.Visibility = Visibility.Visible;
            else
                this.lbl_AlDia.Visibility = Visibility.Collapsed;
        }

        private void VenceHoy(bool visible)
        {
            if (visible)
            {
                this.lbl_VenceHoy1.Visibility = Visibility.Visible;
                this.lbl_VenceHoy2.Visibility = Visibility.Visible;
                this.lbl_VenceHoy3.Visibility = Visibility.Visible;
            }
            else
            {
                this.lbl_VenceHoy1.Visibility = Visibility.Collapsed;
                this.lbl_VenceHoy2.Visibility = Visibility.Collapsed;
                this.lbl_VenceHoy3.Visibility = Visibility.Collapsed;
            }
        }

        private void VenceManana(bool visible)
        {
            if (visible)
            {
                this.lbl_manana1.Visibility = Visibility.Visible;
                this.lbl_manana2.Visibility = Visibility.Visible;
                this.lbl_manana3.Visibility = Visibility.Visible;
            }
            else
            {
                this.lbl_manana1.Visibility = Visibility.Collapsed;
                this.lbl_manana2.Visibility = Visibility.Collapsed;
                this.lbl_manana3.Visibility = Visibility.Collapsed;
            }
        }

        private void Moroso(bool visible)
        {
            if (visible)
            {
                this.lbl_Moroso1.Visibility = Visibility.Visible;
                this.lbl_Moroso2.Visibility = Visibility.Visible;
                this.lbl_Moroso3.Visibility = Visibility.Visible;
            }
            else
            {
                this.lbl_Moroso1.Visibility = Visibility.Collapsed;
                this.lbl_Moroso2.Visibility = Visibility.Collapsed;
                this.lbl_Moroso3.Visibility = Visibility.Collapsed;
            }
        }
        #endregion

        #region Eventos
        private void btn_Cerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            VariablesGlobales.CodSocio = 0;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            VariablesGlobales.CodSocio = 0;   
        }
        #endregion

       
    }
}
