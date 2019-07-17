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
using MahApps.Metro.Controls;

namespace BodyEnergy
{
    /// <summary>
    /// Interaction logic for Empresa.xaml
    /// </summary>
    public partial class Empresa : MetroWindow
    {
        #region Load
        public Empresa()
        {
            InitializeComponent();
            this.txt_Nombre.Focus();
            if (VariablesGlobales.CodEmpresa == 0)
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
        #endregion

        #region Metodos
        private void Guardar()
        {
            try
            {
                EmpresaDTO empDTO = new EmpresaDTO();
                empDTO.Method = Common.ObjectMethod.New;
                empDTO.NombreEmpresa = this.txt_Nombre.Text;
                empDTO.Descripcion = this.txt_Descripcion.Text;
                empDTO.Telefono1 = this.txt_Telefono1.Text.Trim().ToString();
                empDTO.Telefono2 = this.txt_Fax.Text.Trim().ToString();
                empDTO.Correo = this.txt_Correo.Text.Trim().ToString();
                if (this.chk_Activo.IsChecked == true)
                {
                    empDTO.EsActivo = true;
                }
                else
                {
                    empDTO.EsActivo = false;
                }
                empDTO.UsuarioCreacion = VariablesGlobales.usuarioBD; 
                empDTO.FechaCreacion = DateTime.Now;

                Gym.Service.SoapServiceClient proxy = new Gym.Service.SoapServiceClient();

                proxy.SaveEnterprise(empDTO);
                proxy.Close();

                MessageBox.Show("La información ha sido ingresada exitosamente", "Climb", MessageBoxButton.OK, MessageBoxImage.Information);
                Limpiar();
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
                EmpresaDTO eDto = new EmpresaDTO();
                Gym.Service.SoapServiceClient proxy = new Gym.Service.SoapServiceClient();

                eDto.Method = Common.ObjectMethod.Modify;
                eDto.CodEmpresa = VariablesGlobales.CodEmpresa;
                eDto.NombreEmpresa = this.txt_Nombre.Text;
                eDto.Descripcion = this.txt_Descripcion.Text;
                eDto.Telefono1 = this.txt_Telefono1.Text.Trim().ToString();
                eDto.Telefono2 = this.txt_Fax.Text.Trim().ToString();
                eDto.Correo = this.txt_Correo.Text.Trim().ToString();
                if (this.chk_Activo.IsChecked == true)
                {
                    eDto.EsActivo = true;
                }
                else
                {
                    eDto.EsActivo = false;
                }
                eDto.UsuarioModificacion = VariablesGlobales.usuarioBD;
                eDto.FechaModificacion = DateTime.Now;

                proxy.SaveEnterprise(eDto);
                proxy.Close();

                VariablesGlobales.CodEmpresa = 0;
                Limpiar();
                MessageBox.Show("La información ha sido ingresada exitosamente", "Climb", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch
            {
                throw;
            }
        }

        private void CargarDatos()
        {
            try
            {
                EmpresaDTO eDto = new EmpresaDTO();
                Gym.Service.SoapServiceClient proxy = new Gym.Service.SoapServiceClient();

                eDto = proxy.ObtenerEmpresa(VariablesGlobales.CodEmpresa);
                proxy.Close();
                if (eDto == null)
                {
                    MessageBox.Show("No se pudo cargar la información.", "Climb", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    this.txt_Nombre.Text = eDto.NombreEmpresa;
                    this.txt_Descripcion.Text = eDto.Descripcion;
                    this.txt_Telefono1.Text = eDto.Telefono1;
                    this.txt_Fax.Text = eDto.Telefono2;
                    this.txt_Correo.Text = eDto.Correo;
                    if (eDto.EsActivo == true)
                    {
                        this.chk_Activo.IsChecked = true;
                        this.chk_Inactivo.IsChecked = false;
                    }
                    else
                    {
                        this.chk_Inactivo.IsChecked = true;
                        this.chk_Activo.IsChecked = false;
                    }

                }
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
                this.txt_Descripcion.Text = string.Empty;
                this.txt_Telefono1.Text = string.Empty;
                this.txt_Fax.Text = string.Empty;
                this.txt_Correo.Text = string.Empty;
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
                if (this.txt_Nombre.Text == string.Empty)
                {
                    mensaje += "Debe Ingresar un valor en el campo: Nombre." + "\n";
                    desplegarError = true;
                }
                if (this.txt_Telefono1.Text == string.Empty)
                {
                    mensaje += "Debe Ingresar un valor en el campo: Teléfono." + "\n";
                    desplegarError = true;
                }
                if (this.chk_Activo.IsChecked == false && this.chk_Inactivo.IsChecked == false)
                {
                    mensaje += "Debe Seleccionar un valor en el campo: Estado." + "\n";
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

        #region Eventos
        private void btn_Guardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Validar())
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

        private void btn_Actualizar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Validar())
                {
                    this.Actualizar();
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
                VariablesGlobales.CodEmpresa = 0;
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

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                this.Hide();
                VariablesGlobales.CodEmpresa = 0;
            }
            catch
            {
                MessageBox.Show("En este momento la operación no puede ser realizada.", "Climb", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        #endregion
    }
}
