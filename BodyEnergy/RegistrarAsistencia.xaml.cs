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
using System.Diagnostics;
using MahApps.Metro.Controls;

namespace BodyEnergy
{
    /// <summary>
    /// Interaction logic for RegistrarAsistencia.xaml
    /// </summary>
    public partial class RegistrarAsistencia : MetroWindow
    {
        public RegistrarAsistencia()
        {
            InitializeComponent();

            this.txt_CodSocio.Focus();
            this.BtnIr.IsDefault = true;

            VariablesGlobales.usuario = string.Empty;
            VariablesGlobales.usuarioBD = string.Empty;
            
            this.lbl_NombreUsuarioBD.Content = VariablesGlobales.usuario;
        }

        #region Metodos
        public void VerificarMorosidad()
        {
            try
            {
                VariablesGlobales.CodSocio = 0;
                Gym.Service.SoapServiceClient proxy = new Gym.Service.SoapServiceClient();
                FechaVencimientoDTO fecDto = new FechaVencimientoDTO();

                VariablesGlobales.alDia = false;
                VariablesGlobales.moroso = false;
                VariablesGlobales.venceDiaSiguiente = false;
                VariablesGlobales.venceHoy = false;

                fecDto = proxy.ObtenerFecVencimiento(Convert.ToInt32(this.txt_CodSocio.Text.Trim()), Convert.ToInt32(ConfigurationManager.AppSettings["SocioCortesia"].ToString()));
                proxy.Close();
                if (fecDto == null)
                {
                    MessageBox.Show("En este momento la operación no puede ser realizada.", "Climb", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
                else
                {


                    switch (fecDto.CodRetorno)
                    {
                        //Al dia
                        case 0:
                            VariablesGlobales.CodSocio = Convert.ToInt32(this.txt_CodSocio.Text.Trim().ToString());
                            VariablesGlobales.alDia = true;
                            RegistroAsistencia();
                            ConfirmarAsistencia asist = new ConfirmarAsistencia();
                            this.IsEnabled = false;
                            asist.Owner = this;
                            asist.ShowDialog();
                            this.IsEnabled = true;
                            this.txt_CodSocio.Focus();
                            break;

                        //No existe socio
                        case 1:
                            VariablesGlobales.CodSocio = 0;
                            MessageBox.Show("El número de socio ingresado no existe en nuestros registros.", "Climb", MessageBoxButton.OK, MessageBoxImage.Information);
                            this.txt_CodSocio.Focus();
                            break;

                        //Moroso
                        case 2:
                            VariablesGlobales.CodSocio = Convert.ToInt32(this.txt_CodSocio.Text.Trim().ToString());
                            VariablesGlobales.moroso = true;
                            RegistroAsistencia();
                            ConfirmarAsistencia asist2 = new ConfirmarAsistencia();
                            this.IsEnabled = false;
                            asist2.Owner = this;
                            asist2.ShowDialog();
                            this.IsEnabled = true;
                            this.txt_CodSocio.Focus();
                            break;

                        //Vence al dia siguiente
                        case 3:
                            VariablesGlobales.CodSocio = Convert.ToInt32(this.txt_CodSocio.Text.Trim().ToString());
                            VariablesGlobales.venceDiaSiguiente = true;
                            RegistroAsistencia();
                            ConfirmarAsistencia asist3 = new ConfirmarAsistencia();
                            this.IsEnabled = false;
                            asist3.Owner = this;
                            asist3.ShowDialog();
                            this.IsEnabled = true;
                            this.txt_CodSocio.Focus();
                            break;

                        //Vence el dia de hoy
                        case 4:
                            VariablesGlobales.CodSocio = Convert.ToInt32(this.txt_CodSocio.Text.Trim().ToString());
                            VariablesGlobales.venceHoy = true;
                            RegistroAsistencia();
                            ConfirmarAsistencia asist4 = new ConfirmarAsistencia();
                            this.IsEnabled = false;
                            asist4.Owner = this;
                            asist4.ShowDialog();
                            this.IsEnabled = true;
                            this.txt_CodSocio.Focus();
                            break;
                    }

                    #region comentado
                    //if (fecDto.CodRetorno == 0)
                    //{
                    //    //Al dia
                    //}
                    //else if (fecDto.CodRetorno == 1)
                    //{
                    //    //Socio no existe
                    //}
                    //else if (fecDto.CodRetorno == 2)
                    //{
                    //    //Socio Moroso
                    //}
                    //else if (fecDto.CodRetorno == 3)
                    //{
                    //    //Vence al dia siguiente
                    //}
                    //else if (fecDto.CodRetorno == 4)
                    //{
                    //    //Vence el dia de hoy
                    //}
                    #endregion
                }
            }
            catch
            {
                throw;
            }
        }

        public void RegistroAsistencia()
        {
            try
            {
                AsistenciaDTO asistDto = new AsistenciaDTO();
                asistDto.Method = Common.ObjectMethod.New;
                asistDto.Descripcion = string.Empty;
                asistDto.FechaAsistencia = DateTime.Now;
                asistDto.EsActivo = true;
                asistDto.CodSocio = VariablesGlobales.CodSocio;
                asistDto.UsuarioCreacion = VariablesGlobales.usuarioBD;
                asistDto.FechaCreacion = DateTime.Now;

                Gym.Service.SoapServiceClient proxy = new Gym.Service.SoapServiceClient();
                proxy.SaveAttendance(asistDto);

                proxy.Close();
            }
            catch
            {
                throw;
            }
        }

        public void Limpiar()
        {
            try
            {
                this.txt_CodSocio.Text = string.Empty;
            }
            catch
            {
                throw;
            }
        }

        public bool Validar()
        {
            string mensaje = string.Empty;
            mensaje = "Se presentaron los siguientes errores: " + "\n";
            bool desplegarError = false;
            try
            {
                if (this.txt_CodSocio.Text == string.Empty)
                {
                    mensaje += "Debe Ingresar su Número de Socio." + "\n";
                    desplegarError = true;
                }
                if (desplegarError)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                VariablesGlobales.mensajeError = mensaje;
            }
        }
        #endregion

        private void BtnBusqueda_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                VariablesGlobales.busquedaSocios = 1;
                VariablesGlobales.CodSocio = 0;
                BusquedaSocioAsistencia b = new BusquedaSocioAsistencia();
                RegistrarAsistencia p = this;
                p.IsEnabled = false;
                b.Owner = this;
                b.ShowDialog();
                this.txt_CodSocio.Text = VariablesGlobales.CodSocio.ToString();
                p.IsEnabled = true;
            }
            catch
            {
                MessageBox.Show("En este momento la operación no puede ser realizada.", "Climb", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void BtnIr_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Validar())
                {
                    VariablesGlobales.CodSocio = 0;
                    this.VerificarMorosidad();
                    //if (VariablesGlobales.CodSocio > 0)
                    //{
                    //    RegistrarAsistencia();
                    //}
                    this.Limpiar();
                }
                else
                {
                    MessageBox.Show(VariablesGlobales.mensajeError, "Climb", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    VariablesGlobales.mensajeError = string.Empty;
                }

            }
            catch
            {
                MessageBox.Show("En este momento la operación no puede ser realizada.", "Climb", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void txt_CodSocio_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9 || e.Key == Key.Enter)
                    e.Handled = false;
                else
                    e.Handled = true;
            }
            catch
            {
                MessageBox.Show("En este momento la operación no puede ser realizada.", "Climb", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
    }
}
