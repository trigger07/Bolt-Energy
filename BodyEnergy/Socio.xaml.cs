using System;
using System.Collections.Generic;
using System.IO;
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
using Microsoft.Win32;
using MahApps.Metro.Controls;

namespace BodyEnergy
{
    /// <summary>
    /// Interaction logic for Socio.xaml
    /// </summary>
    public partial class Socio : MetroWindow
    {
        #region Load
        public Socio()
        {
            InitializeComponent();
            CargarTipoSocio();
            CargarEmpresa();
            VariablesGlobales.CargarImagen = false;
            try
            {
                this.lbl_Empresa.Visibility = Visibility.Collapsed;
                this.cbo_Empresa.Visibility = Visibility.Collapsed;
                this.cbo_Empresa.BorderBrush = Brushes.Gray;
                this.chk_Activo.IsChecked = true;
                if (VariablesGlobales.Socio == 0)
                {
                    this.btn_Guardar.Visibility = Visibility.Visible;
                    this.btn_Actualizar.Visibility = Visibility.Collapsed;
                    this.btn_Buscar.Visibility = Visibility.Collapsed;
                    this.txt_CodSocio.BorderBrush = Brushes.Gray;
                    this.btn_Olvido.Visibility = Visibility.Collapsed;
                    this.txt_CodSocio.IsEnabled = false;
                    this.btn_Guardar.IsDefault = true;
                    this.txt_Nombre.Focus();
                }
                else
                {
                    this.btn_Guardar.Visibility = Visibility.Collapsed;
                    this.btn_Actualizar.Visibility = Visibility.Visible;
                    this.btn_Olvido.Visibility = Visibility.Visible;
                    this.txt_CodSocio.BorderBrush = Brushes.DarkRed;
                    this.btn_Buscar.Visibility = Visibility.Visible;
                    this.txt_CodSocio.IsEnabled = true;
                    this.btn_Buscar.IsDefault = true;
                    this.txt_CodSocio.Focus();
                    if (VariablesGlobales.CodSocio > 0)
                    {
                        this.txt_CodSocio.Text = VariablesGlobales.CodSocio.ToString();
                        this.txt_Nombre.Focus();
                        this.BuscarSocio();
                    }
                }
            }
            catch
            {
                MessageBox.Show("En este momento la operación no puede ser realizada.", "Climb", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
        #endregion

        #region Eventos
        private void btn_Buscar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (ValidarBusqueda())
                {
                    BuscarSocio();
                }
                else
                {
                    MessageBox.Show(VariablesGlobales.mensajeError, "Climb", MessageBoxButton.OK, MessageBoxImage.Information);
                    VariablesGlobales.mensajeError = string.Empty;
                }
            }
            catch
            {
                MessageBox.Show("En este momento la operación no puede ser realizada.", "Climb", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void btn_Guardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (ValidarGuardar())
                {
                    Guardar();
                }
                else
                {
                    MessageBox.Show(VariablesGlobales.mensajeError, "Climb", MessageBoxButton.OK, MessageBoxImage.Information);
                    VariablesGlobales.mensajeError = string.Empty;
                }
                
            }
            catch
            {
                MessageBox.Show("En este momento la operación no puede ser realizada.", "Climb", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void chk_Activo_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                if (this.chk_Activo.IsChecked == true)
                {
                    this.chk_Inactivo.IsChecked = false;
                }
            }
            catch
            {
                MessageBox.Show("En este momento la operación no puede ser realizada.", "Climb", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void chk_Inactivo_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                if (this.chk_Inactivo.IsChecked == true)
                {
                    this.chk_Activo.IsChecked = false;
                }
            }
            catch
            {
                MessageBox.Show("En este momento la operación no puede ser realizada.", "Climb", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void btn_Actualizar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (ValidarActualizar())
                {
                    Actualizar();
                }
                else
                {
                    MessageBox.Show(VariablesGlobales.mensajeError, "Climb", MessageBoxButton.OK, MessageBoxImage.Information);
                    VariablesGlobales.mensajeError = string.Empty;
                }
            }
            catch
            {
                MessageBox.Show("En este momento la operación no puede ser realizada.", "Climb", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void btn_Olvido_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                VariablesGlobales.busquedaSocios = 3;
                VariablesGlobales.CodSocio = 0;
                BusquedaSocio b = new BusquedaSocio();
                b.ShowDialog();
                this.txt_CodSocio.Text = VariablesGlobales.CodSocio.ToString();
                this.BuscarSocio();
            }
            catch
            {
                MessageBox.Show("En este momento la operación no puede ser realizada.", "Climb", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void btn_Limpiar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Limpiar();
            }
            catch
            {
                MessageBox.Show("En este momento la operación no puede ser realizada.", "Climb", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void btn_Browse_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CargarImagen();
            }
            catch
            {
                MessageBox.Show("En este momento la operación no puede ser realizada.", "Climb", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void btn_EliminarImagen_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                EliminarImagen();
            }
            catch
            {
                MessageBox.Show("En este momento la operación no puede ser realizada.", "Climb", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void cbo_TipoSocio_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (this.cbo_TipoSocio.SelectedValue != null)
                {
                    if (Convert.ToInt32(this.cbo_TipoSocio.SelectedValue.ToString()) == Convert.ToInt32(ConfigurationManager.AppSettings["SocioConEmpresa"].ToString()))
                    {
                        this.lbl_Empresa.Visibility = Visibility.Visible;
                        this.cbo_Empresa.Visibility = Visibility.Visible;
                        this.cbo_Empresa.BorderBrush = Brushes.DarkRed;
                    }
                    else
                    {
                        this.lbl_Empresa.Visibility = Visibility.Collapsed;
                        this.cbo_Empresa.Visibility = Visibility.Collapsed;
                        this.cbo_Empresa.BorderBrush = Brushes.Gray;
                    }
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

        private void btn_Salir_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Hide();
                VariablesGlobales.Socio = 0;
                VariablesGlobales.CodSocio = 0;
            }
            catch
            {
                MessageBox.Show("En este momento la operación no puede ser realizada.", "Climb", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                this.Hide();
                VariablesGlobales.Socio = 0;
                VariablesGlobales.CodSocio = 0;
            }
            catch
            {
                MessageBox.Show("En este momento la operación no puede ser realizada.", "Climb", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
        #endregion

        #region Metodos
        #region Guardar
        private void Guardar()
        {
            try
            {
                Gym.Service.SoapServiceClient proxy = new Gym.Service.SoapServiceClient();
                SocioDTO socDto = new SocioDTO();

                FechaVencimientoDTO fecDto = new FechaVencimientoDTO();

                socDto.Method = Common.ObjectMethod.New;
                socDto.Nombre = this.txt_Nombre.Text.ToString();
                socDto.Apellido1 = this.txt_Apellido1.Text.ToString();
                socDto.Apellido2 = this.txt_Apellido2.Text.ToString();
                socDto.FechaNacimiento = Convert.ToDateTime(this.dpc_fecNacimiento.Text.ToString());
                socDto.Correo = this.txt_Email.Text.ToString();
                socDto.DiaPago = 0;  //Convert.ToInt32(this.txt_DiaPago.Text.ToString());
                socDto.TelCelular = this.txt_TelCelular.Text.ToString();
                socDto.TelResidencia = this.txt_TelResidencia.Text.ToString();

                //manejo de imagenes
                socDto.Imagen = VariablesGlobales.NombreImagen;
                if (this.txt_Imagen.Text != string.Empty)
                    MoverImagen();

                //Estado del Socio
                if (this.chk_Activo.IsChecked == true)
                {
                    socDto.EsActivo = true;
                }
                else
                {
                    socDto.EsActivo = false;
                }
                socDto.CodTipoSocio = Convert.ToInt32(this.cbo_TipoSocio.SelectedValue.ToString());
                if (this.cbo_Empresa.IsVisible)
                {
                    socDto.CodEmpresa = Convert.ToInt32(this.cbo_Empresa.SelectedValue.ToString());
                }
                else
                {
                    socDto.CodEmpresa = 0;
                }
                socDto.UsuarioCreacion = VariablesGlobales.usuarioBD;
                socDto.FechaCreacion = DateTime.Now;

                int codSocio = proxy.SaveSocio(socDto);

                fecDto.Method = Common.ObjectMethod.New;
                fecDto.FechaVencimiento = DateTime.Now;
                fecDto.Descripcion = string.Empty;
                fecDto.CodSocio = codSocio;
                fecDto.UsuarioCreacion = VariablesGlobales.usuarioBD;
                fecDto.FechaCreacion = DateTime.Now;
                proxy.SaveExpireDate(fecDto);

                proxy.Close();
                this.txt_CodSocio.Text = codSocio.ToString();
                VariablesGlobales.NombreImagen = string.Empty;
                this.btn_Guardar.IsEnabled = false;
                MessageBox.Show("La información ha sido ingresada exitosamente", "Climb", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch
            {
                throw;
            }
        }

        private void Actualizar()
        {
            try
            {
                SocioDTO socDto = new SocioDTO();
                Gym.Service.SoapServiceClient proxy = new Gym.Service.SoapServiceClient();

                string imagenAnterior = string.Empty;

                socDto.Method = Common.ObjectMethod.Modify;
                socDto.CodSocio = Convert.ToInt32(this.txt_CodSocio.Text.Trim().ToString());
                socDto.Nombre = this.txt_Nombre.Text.ToString();
                socDto.Apellido1 = this.txt_Apellido1.Text.ToString();
                socDto.Apellido2 = this.txt_Apellido2.Text.ToString();
                socDto.FechaNacimiento = Convert.ToDateTime(this.dpc_fecNacimiento.Text.ToString());
                socDto.Correo = this.txt_Email.Text.ToString();
                socDto.DiaPago = 0; //Convert.ToInt32(this.txt_DiaPago.Text.ToString());
                socDto.TelCelular = this.txt_TelCelular.Text.ToString();
                socDto.TelResidencia = this.txt_TelResidencia.Text.ToString();


                socDto.Imagen = VariablesGlobales.NombreImagen;
                imagenAnterior = VariablesGlobales.RutaImagenAnterior + VariablesGlobales.NombreImagenAnterior;
                if (VariablesGlobales.CargarImagen == true)
                    ActualizarImagen(imagenAnterior);


                //Estado del Socio
                if (this.chk_Activo.IsChecked == true)
                {
                    socDto.EsActivo = true;
                }
                else
                {
                    socDto.EsActivo = false;
                }
                socDto.CodTipoSocio = Convert.ToInt32(this.cbo_TipoSocio.SelectedValue.ToString());
                if (this.cbo_Empresa.IsVisible)
                {
                    socDto.CodEmpresa = Convert.ToInt32(this.cbo_Empresa.SelectedValue.ToString());
                }
                else
                {
                    socDto.CodEmpresa = 0;
                }
                socDto.UsuarioModificacion = VariablesGlobales.usuarioBD;
                socDto.FechaModificacion = DateTime.Now;

                proxy.SaveSocio(socDto);
                this.btn_Actualizar.IsEnabled = false;
                VariablesGlobales.NombreImagen = string.Empty;
                MessageBox.Show("La información ha sido ingresada exitosamente", "Climb", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch
            {
                throw;
            }
        }
        #endregion
        #region Cargas
        private void CargarTipoSocio()
        {
            try
            {
                Gym.Service.SoapServiceClient proxy = new Gym.Service.SoapServiceClient();
                this.cbo_TipoSocio.ItemsSource = proxy.ObtenerTodosTipoSocio();
                this.cbo_TipoSocio.DisplayMemberPath = "Descripcion";
                this.cbo_TipoSocio.SelectedValuePath = "CodTipoSocio";
                this.cbo_TipoSocio.SelectedValue = 0;

                proxy.Close();
            }
            catch
            {
                throw;
            }
        }

        private void CargarEmpresa()
        {
            try
            {
                Gym.Service.SoapServiceClient proxy = new Gym.Service.SoapServiceClient();
                this.cbo_Empresa.ItemsSource = proxy.ObtenerTodosEmpresa();
                this.cbo_Empresa.DisplayMemberPath = "NombreEmpresa";
                this.cbo_Empresa.SelectedValuePath = "CodEmpresa";
                this.cbo_Empresa.SelectedValue = 0;

                proxy.Close();
            }
            catch
            {
                throw;
            }
        }
        #endregion
        #region BuscarSocio
        private void BuscarSocio()
        {
            try
            {
                Gym.Service.SoapServiceClient proxy = new Gym.Service.SoapServiceClient();
                SocioDTO sDto = new SocioDTO();

                VariablesGlobales.NombreImagenAnterior = string.Empty;
                VariablesGlobales.RutaImagenAnterior = string.Empty;
                string rutaImagen = string.Empty;
                rutaImagen = ConfigurationManager.AppSettings["RutaImagen"].ToString();

                sDto = proxy.ObtenerSocio(Convert.ToInt32(this.txt_CodSocio.Text.Trim().ToString()));
                if (sDto == null)
                {
                    MessageBox.Show("No se pudo cargar la información.", "Climb", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    this.txt_Nombre.Text = sDto.Nombre;
                    this.txt_Apellido1.Text = sDto.Apellido1;
                    this.txt_Apellido2.Text = sDto.Apellido2;
                    //this.txt_DiaPago.Text = sDto.DiaPago.ToString();
                    this.txt_Email.Text = sDto.Correo;
                    this.txt_TelCelular.Text = sDto.TelCelular;
                    this.txt_TelResidencia.Text = sDto.TelResidencia;
                    this.cbo_TipoSocio.SelectedValue = sDto.CodTipoSocio.ToString();

                    if (sDto.Imagen != String.Empty)
                    {
                        this.txt_Imagen.Text = sDto.Imagen;
                        if (File.Exists(rutaImagen + sDto.Imagen))
                            this.img_Socio.Source = new BitmapImage(new Uri(rutaImagen + sDto.Imagen));
                        else
                        {
                            this.img_Socio.Source = null;
                        }
                        this.img_Socio.Stretch = Stretch.Uniform;
                        VariablesGlobales.RutaImagenAnterior = rutaImagen;
                        VariablesGlobales.NombreImagenAnterior = sDto.Imagen;
                        VariablesGlobales.NombreImagen = sDto.Imagen;
                    }
                    else
                    {
                        this.txt_Imagen.Text = string.Empty;
                        this.img_Socio.Source = null;
                        VariablesGlobales.RutaImagenAnterior = string.Empty;
                        VariablesGlobales.NombreImagenAnterior = string.Empty;
                    }

                    if (sDto.EsActivo == true)
                    {
                        this.chk_Activo.IsChecked = true;
                        this.chk_Inactivo.IsChecked = false;
                    }
                    else
                    {
                        this.chk_Inactivo.IsChecked = true;
                        this.chk_Activo.IsChecked = false;
                    }
                    this.dpc_fecNacimiento.Text = sDto.FechaNacimiento.ToShortDateString();
                    if (sDto.CodTipoSocio == Convert.ToInt32(ConfigurationManager.AppSettings["SocioConEmpresa"].ToString()))
                    {
                        this.lbl_Empresa.Visibility = Visibility.Visible;
                        this.cbo_Empresa.Visibility = Visibility.Visible;
                        this.cbo_Empresa.BorderBrush = Brushes.DarkRed;
                        this.cbo_Empresa.SelectedValue = sDto.CodEmpresa.ToString();
                    }
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion
        #region Validaciones
        public bool ValidarBusqueda()
        {
            string mensaje = string.Empty;
            mensaje = "Se presentaron los siguientes errores: " + "\n";
            bool desplegarError = false;
            try
            {
                if (this.txt_CodSocio.Text == string.Empty)
                {
                    mensaje += "Debe Ingresar un valor en el campo: Número de Socio." + "\n";
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

        public bool ValidarGuardar()
        {
            string mensaje = string.Empty;
            mensaje = "Se presentaron los siguientes errores: " + "\n";
            bool desplegarError = false;
            try
            {
                if (this.txt_Nombre.Text == string.Empty)
                {
                    mensaje += "Debe Ingresar un valor en el campo: Nombre." + "\n";
                    desplegarError = true;
                }
                if (this.txt_Apellido1.Text == string.Empty)
                {
                    mensaje += "Debe Ingresar un valor en el campo: Primer Apellido." + "\n";
                    desplegarError = true;
                }
                //if (this.txt_DiaPago.Text == string.Empty)
                //{
                //    mensaje += "Debe Ingresar un valor en el campo: Día de Pago." + "\n";
                //    desplegarError = true;
                //}
                if (Convert.ToInt32(this.cbo_TipoSocio.SelectedValue) == 0)
                {
                    mensaje += "Debe Seleccionar un valor en el campo: Tipo de Socio." + "\n";
                    desplegarError = true;
                }
                //if (this.txt_Imagen.Text == string.Empty)
                //{
                //    mensaje += "Debe Ingresar un valor en el campo: Imagen." + "\n";
                //    desplegarError = true;
                //}
                if (this.chk_Activo.IsChecked == false && this.chk_Inactivo.IsChecked == false)
                {
                    mensaje += "Debe Seleccionar un valor en el campo: Estado." + "\n";
                    desplegarError = true;
                }

                if (this.dpc_fecNacimiento.Text == string.Empty)
                {
                    mensaje += "Debe Seleccionar un valor en el campo: Fecha de Nacimiento." + "\n";
                    desplegarError = true;
                }
                if (this.cbo_Empresa.IsVisible)
                {
                    if (Convert.ToInt32(this.cbo_Empresa.SelectedValue) == 0)
                    {
                    mensaje += "Debe Seleccionar un valor en el campo: Empresa." + "\n";
                    desplegarError = true;
                    }
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

        public bool ValidarActualizar()
        {
            string mensaje = string.Empty;
            mensaje = "Se presentaron los siguientes errores: " + "\n";
            bool desplegarError = false;
            try
            {
                if (this.txt_Nombre.Text == string.Empty)
                {
                    mensaje += "Debe Ingresar un valor en el campo: Nombre." + "\n";
                    desplegarError = true;
                }
                if (this.txt_Apellido1.Text == string.Empty)
                {
                    mensaje += "Debe Ingresar un valor en el campo: Primer Apellido." + "\n";
                    desplegarError = true;
                }
                //if (this.txt_DiaPago.Text == string.Empty)
                //{
                //    mensaje += "Debe Ingresar un valor en el campo: Día de Pago." + "\n";
                //    desplegarError = true;
                //}
                if (Convert.ToInt32(this.cbo_TipoSocio.SelectedValue) == 0)
                {
                    mensaje += "Debe Seleccionar un valor en el campo: Tipo de Socio." + "\n";
                    desplegarError = true;
                }
                //if (this.txt_Imagen.Text == string.Empty)
                //{
                //    mensaje += "Debe Ingresar un valor en el campo: Imagen." + "\n";
                //    desplegarError = true;
                //}
                if (this.chk_Activo.IsChecked == false && this.chk_Inactivo.IsChecked == false)
                {
                    mensaje += "Debe Seleccionar un valor en el campo: Estado." + "\n";
                    desplegarError = true;
                }
                if (this.dpc_fecNacimiento.Text == string.Empty)
                {
                    mensaje += "Debe Seleccionar un valor en el campo: Fecha de Nacimiento." + "\n";
                    desplegarError = true;
                }
                if (this.cbo_Empresa.IsVisible)
                {
                    if (Convert.ToInt32(this.cbo_Empresa.SelectedValue) == 0)
                    {
                        mensaje += "Debe Seleccionar un valor en el campo: Empresa." + "\n";
                        desplegarError = true;
                    }
                }
                if (this.txt_CodSocio.Text == string.Empty)
                {
                    mensaje += "Debe Seleccionar un valor en el campo: Número de Socio." + "\n";
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
        #region Limpiar
        private void Limpiar()
        {
            try
            {
                this.txt_Nombre.Text = string.Empty;
                this.txt_Apellido1.Text = string.Empty;
                this.txt_Apellido2.Text = string.Empty;
                //this.txt_DiaPago.Text = string.Empty;
                this.txt_Email.Text = string.Empty;
                this.txt_TelCelular.Text = string.Empty;
                this.txt_TelResidencia.Text = string.Empty;
                this.cbo_TipoSocio.SelectedValue = 0;
                this.txt_Imagen.Text = string.Empty;
                this.chk_Activo.IsChecked = false;
                this.chk_Inactivo.IsChecked = false;
                this.dpc_fecNacimiento.Text = string.Empty;
                this.cbo_Empresa.SelectedValue = 0;
                this.txt_CodSocio.Text = string.Empty;
                EliminarImagen();
                this.btn_Guardar.IsEnabled = true;
                this.btn_Actualizar.IsEnabled = true;
            }
            catch
            {
                throw;
            }
        }
        #endregion
        #region Imagen
        private void CargarImagen()
        {
            try
            {
                VariablesGlobales.CargarImagen = false;
                string ruta = string.Empty;
                string archivo = string.Empty;
                string destinoTemporal = string.Empty;
                VariablesGlobales.NombreImagen = string.Empty;
                VariablesGlobales.RutaImagen = string.Empty;

                OpenFileDialog ofd = new OpenFileDialog();
                ofd.InitialDirectory = "C:";
                ofd.Filter = "JPG|*.jpg|GIF|*.gif|PNG|*.png|BMP|*.bmp";

                Nullable<bool> result = ofd.ShowDialog();
                if (result == true)
                {
                    ruta = ofd.FileName;
                    archivo = ofd.SafeFileName;
                    this.txt_Imagen.Text = ruta;

                    VariablesGlobales.RutaImagen = ruta;
                    VariablesGlobales.NombreImagen = archivo;
                    VariablesGlobales.CargarImagen = true;
                    this.img_Socio.Source = new BitmapImage(new Uri(ruta));
                    this.img_Socio.Stretch = Stretch.Uniform;          
                }

            }
            catch
            {
                throw;
            }
        }

        private void EliminarImagen()
        {
            try
            {
                this.txt_Imagen.Text = string.Empty;
                VariablesGlobales.RutaImagen = string.Empty;
                VariablesGlobales.NombreImagen = string.Empty;
                this.img_Socio.Source = null;
            }
            catch
            {
                throw;
            }
        }

        private void MoverImagen()
        {
            try
            {
                string rutaImagen = string.Empty;
                string rutaTemp = string.Empty;
                string nombreImagen = string.Empty;

                nombreImagen = VariablesGlobales.NombreImagen;
                rutaTemp = VariablesGlobales.RutaImagen;
                rutaImagen = ConfigurationManager.AppSettings["RutaImagen"].ToString() + nombreImagen;

                if (System.IO.File.Exists(rutaImagen))
                    System.IO.File.Delete(rutaImagen);
                System.IO.File.Copy(rutaTemp, rutaImagen, true);
                VariablesGlobales.NombreImagen = string.Empty;
                VariablesGlobales.RutaImagen = string.Empty;
            }
            catch
            {
                throw;
            }
        }

        private void ActualizarImagen(string pImagenAnterior)
        {
            try
            {
                string rutaImagen = string.Empty;
                string rutaTemp = string.Empty;
                string nombreImagen = string.Empty;

                nombreImagen = VariablesGlobales.NombreImagen;
                rutaTemp = VariablesGlobales.RutaImagen;
                rutaImagen = ConfigurationManager.AppSettings["RutaImagen"].ToString() + nombreImagen;

                //if (System.IO.File.Exists(pImagenAnterior))
                //    System.IO.File.Delete(pImagenAnterior);
               
                if (System.IO.File.Exists(rutaImagen))
                    System.IO.File.Delete(rutaImagen);
                System.IO.File.Copy(rutaTemp, rutaImagen);
                VariablesGlobales.NombreImagen = string.Empty;
                VariablesGlobales.RutaImagen = string.Empty;
            }
            catch
            {
                throw;
            }
        }
        #endregion
        #endregion
    }
}
