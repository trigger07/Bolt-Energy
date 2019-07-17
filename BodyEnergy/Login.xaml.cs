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
using System.Diagnostics;
using MahApps.Metro.Controls;

namespace BodyEnergy
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : MetroWindow
    {
        #region Load
        public Login()
        {
            InitializeComponent();
            this.txt_Usuario.Focus();
            //this.btn_Ingresar.IsDefault = true;
        }
        #endregion

        #region Eventos
        private void btn_Ingresar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Validar())
                {
                    Verificar();                 
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

        #region Metodos
        private void Verificar()
        {
            try
            {
                VariablesGlobales.usuarioBD = string.Empty;
                VariablesGlobales.usuario = string.Empty;
                VariablesGlobales.rolDescripcion = string.Empty;

                Gym.Service.SoapServiceClient proxy = new Gym.Service.SoapServiceClient();
                SeguridadDTO dto = new SeguridadDTO();

                dto = proxy.ObtenerUsuario(this.txt_Usuario.Text.Trim().ToLower(), this.txt_Contrasenia.Password.Trim());
                proxy.Close();

                if (dto == null)
                {
                    MessageBox.Show("El Usuario y la Contraseña no coinciden.", "Climb", MessageBoxButton.OK, MessageBoxImage.Information);
                    Limpiar();
                }
                else
                {
                    VariablesGlobales.usuario = dto.Nombre + ' ' + dto.Apellido1 + ' ' + dto.Apellido2;
                    VariablesGlobales.usuarioBD = this.txt_Usuario.Text.Trim().ToLower();
                    VariablesGlobales.rolDescripcion = dto.RolDescripcion.ToString();

                    this.Hide();
                    Main prop = new Main();
                    prop.Show();
                }
                
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
                this.txt_Usuario.Text = string.Empty;
                this.txt_Contrasenia.Password = string.Empty;
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
                if (this.txt_Usuario.Text == string.Empty)
                {
                    mensaje += "Debe Ingresar un valor en el campo: Usuario." + "\n";
                    desplegarError = true;
                }
                if (this.txt_Contrasenia.Password == string.Empty)
                {
                    mensaje += "Debe Ingresar un valor en el campo: Contraseña." + "\n";
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
                VariablesGlobales.mensajeError =  mensaje;
            }
        }
        #endregion

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Process proc = Process.GetCurrentProcess();
            //proc.Close();
            proc.Kill();
            //proc.WaitForExit();
        }

        private void txt_Usuario_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                try
                {
                    if (Validar())
                    {
                        Verificar();
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
        }

        private void txt_Contrasenia_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key == Key.Return)
                {
                    if (Validar())
                    {
                        Verificar();
                    }
                    else
                    {
                        MessageBox.Show(VariablesGlobales.mensajeError, "Climb", MessageBoxButton.OK, MessageBoxImage.Information);
                        VariablesGlobales.mensajeError = string.Empty;
                    }
                }
                    
            }
            catch
            {
                MessageBox.Show("En este momento la operación no puede ser realizada.", "Climb", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
    }
}
