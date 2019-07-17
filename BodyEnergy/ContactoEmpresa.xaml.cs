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
using MahApps.Metro.Controls;

namespace BodyEnergy
{
    /// <summary>
    /// Interaction logic for ContactoEmpresa.xaml
    /// </summary>
    public partial class ContactoEmpresa : MetroWindow
    {
        #region Load
        public ContactoEmpresa()
        {
            InitializeComponent();
            try
            {
                CargarEmpresa();
                this.txt_Nombre.Focus();
                if (VariablesGlobales.CodContacto == 0)
                {
                    this.btn_Guardar.Visibility = Visibility.Visible;
                    this.btn_Actualizar.Visibility = Visibility.Collapsed;
                    this.btn_Guardar.IsDefault = true;
                    this.chk_Activo.IsChecked = true;
                }
                else
                {
                    this.btn_Actualizar.Visibility = Visibility.Visible;
                    this.btn_Guardar.Visibility = Visibility.Collapsed;
                    this.btn_Actualizar.IsDefault = true;
                    CargarDatos();
                }
            }
            catch
            {
                MessageBox.Show("En este momento la operación no puede ser realizada.", "Climb", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
        #endregion

        #region Metodos
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

        private void Limpiar()
        {
            try
            {
                this.txt_Nombre.Text = string.Empty;
                this.txt_Apellido1.Text = string.Empty;
                this.txt_Apellido2.Text = string.Empty;
                this.txt_telefono1.Text = string.Empty;
                this.txt_Telefono2.Text = string.Empty;
                this.txt_Correo.Text = string.Empty;
                this.chk_Activo.IsChecked = false;
                this.chk_Inactivo.IsChecked = false;
                this.cbo_Empresa.SelectedValue = 0;
            }
            catch
            {
                throw;
            }
        }

        private bool ValidarGuardar()
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
                if (this.txt_telefono1.Text == string.Empty)
                {
                    mensaje += "Debe Ingresar un valor en el campo: Teléfono 1." + "\n";
                    desplegarError = true;
                }
                if (this.chk_Activo.IsChecked == false && this.chk_Inactivo.IsChecked == false)
                {
                    mensaje += "Debe Seleccionar un valor en el campo: Estado." + "\n";
                    desplegarError = true;
                }
                if (Convert.ToInt32(this.cbo_Empresa.SelectedValue) == 0)
                {
                    mensaje += "Debe Seleccionar un valor en el campo: Empresa." + "\n";
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

        private void CargarDatos()
        {
            try
            {
                ContactoEmpresaDTO cDto = new ContactoEmpresaDTO();
                Gym.Service.SoapServiceClient proxy = new Gym.Service.SoapServiceClient();

                cDto = proxy.ObtenerContacto(VariablesGlobales.CodContacto);
                proxy.Close();
                if (cDto == null)
                {
                    MessageBox.Show("No se pudo cargar la información.", "Climb", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    this.txt_Nombre.Text = cDto.Nombre;
                    this.txt_Apellido1.Text = cDto.Apellido1;
                    this.txt_Apellido2.Text = cDto.Apellido2;
                    this.txt_telefono1.Text = cDto.Telefono1;
                    this.txt_Telefono2.Text = cDto.Telefono2;
                    if (cDto.EsActivo == true)
                    {
                        this.chk_Activo.IsChecked = true;
                        this.chk_Inactivo.IsChecked = false;
                    }
                    else
                    {
                        this.chk_Inactivo.IsChecked = true;
                        this.chk_Activo.IsChecked = false;
                    }
                    this.txt_Correo.Text = cDto.Correo;
                    if (cDto.CodEmpresa > 0)
                        this.cbo_Empresa.SelectedValue = cDto.CodEmpresa.ToString();
                }
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
                ContactoEmpresaDTO cxeDto = new ContactoEmpresaDTO();
                Gym.Service.SoapServiceClient proxy = new Gym.Service.SoapServiceClient();

                cxeDto.Method = Common.ObjectMethod.Modify;
                cxeDto.CodContactoEmpresa = VariablesGlobales.CodContacto;
                cxeDto.Nombre = this.txt_Nombre.Text.ToString();
                cxeDto.Apellido1 = this.txt_Apellido1.Text.ToString();
                cxeDto.Apellido2 = this.txt_Apellido2.Text.ToString();
                cxeDto.Telefono1 = this.txt_telefono1.Text.Trim().ToString();
                cxeDto.Telefono2 = this.txt_Telefono2.Text.Trim().ToString();
                cxeDto.Correo = this.txt_Correo.Text.Trim().ToString();
                //Estado del Socio
                if (this.chk_Activo.IsChecked == true)
                {
                    cxeDto.EsActivo = true;
                }
                else
                {
                    cxeDto.EsActivo = false;
                }
                cxeDto.CodEmpresa = Convert.ToInt32(this.cbo_Empresa.SelectedValue.ToString());
                cxeDto.UsuarioModificacion = VariablesGlobales.usuarioBD;
                cxeDto.FechaModificacion = DateTime.Now;

                proxy.SaveContact(cxeDto);
                proxy.Close();
                VariablesGlobales.CodContacto = 0;
                Limpiar();
                MessageBox.Show("La información ha sido ingresada exitosamente", "Climb", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch
            {
                throw;
            }
        }

        private void Guardar()
        {
            try
            {
                ContactoEmpresaDTO cxeDto = new ContactoEmpresaDTO();
                Gym.Service.SoapServiceClient proxy = new Gym.Service.SoapServiceClient();

                cxeDto.Method = Common.ObjectMethod.New;
                cxeDto.Nombre = this.txt_Nombre.Text.ToString();
                cxeDto.Apellido1 = this.txt_Apellido1.Text.ToString();
                cxeDto.Apellido2 = this.txt_Apellido2.Text.ToString();
                cxeDto.Telefono1 = this.txt_telefono1.Text.Trim().ToString();
                cxeDto.Telefono2 = this.txt_Telefono2.Text.Trim().ToString();
                cxeDto.Correo = this.txt_Correo.Text.Trim().ToString();
                //Estado del Socio
                if (this.chk_Activo.IsChecked == true)
                {
                    cxeDto.EsActivo = true;
                }
                else
                {
                    cxeDto.EsActivo = false;
                }
                cxeDto.CodEmpresa = Convert.ToInt32(this.cbo_Empresa.SelectedValue.ToString());
                cxeDto.UsuarioCreacion = VariablesGlobales.usuarioBD;
                cxeDto.FechaCreacion = DateTime.Now;

                proxy.SaveContact(cxeDto);
                proxy.Close();
                Limpiar();
                MessageBox.Show("La información ha sido ingresada exitosamente", "Climb", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region Eventos
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

        private void btn_Limpiar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Limpiar();
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
                VariablesGlobales.CodContacto = 0;
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
                VariablesGlobales.CodContacto = 0;
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
                if (ValidarGuardar())
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
        #endregion

        

        
    }
}
