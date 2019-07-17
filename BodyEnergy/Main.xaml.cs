using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
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

namespace BodyEnergy
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : MetroWindow
    {
        public Main()
        {
            InitializeComponent();

            //VariablesGlobales.usuario = string.Empty;
            //VariablesGlobales.usuarioBD = string.Empty;
            //VariablesGlobales.rolDescripcion = ConfigurationManager.AppSettings["rolAdmin"].ToUpper().ToString();
            if (VariablesGlobales.rolDescripcion.ToUpper() == ConfigurationManager.AppSettings["rolAdmin"].ToUpper().ToString())
            {
                this.NSoxio.IsEnabled = true;
                this.ESocio.IsEnabled = true;
                this.Pagos.IsEnabled = true;
                this.Empresas.IsEnabled = true;
                Contactos.IsEnabled = true;
                this.BusquedaSocio.IsEnabled = true;
                this.BusquedaPago.IsEnabled = true;
                this.BusquedaEmpresa.IsEnabled = true;
                this.Asistencia.IsEnabled = true;
                this.BusquedaAsistencia.IsEnabled = true;
                this.BusquedaContacto.IsEnabled = true;
            }
            else
            {
                this.NSoxio.IsEnabled = false;
                this.ESocio.IsEnabled = false;
                this.Pagos.IsEnabled = false;
                this.Empresas.IsEnabled = false;
                Contactos.IsEnabled = false;
                this.BusquedaSocio.IsEnabled = false;
                this.BusquedaPago.IsEnabled = false;
                this.BusquedaEmpresa.IsEnabled = false;
                this.Asistencia.IsEnabled = true;
                this.BusquedaAsistencia.IsEnabled = false;
                this.BusquedaContacto.IsEnabled = false;
            }
        }

        private void Asistencia_Click(object sender, RoutedEventArgs e)
        {
            RegistrarAsistencia ra = new RegistrarAsistencia();
            ra.Show();
        }

        private void MetroWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Process proc = Process.GetCurrentProcess();
            proc.Kill();
        }

        private void NSoxio_Click(object sender, RoutedEventArgs e)
        {
            VariablesGlobales.Socio = 0;
            VariablesGlobales.Empresa = 0;
            Socio s = new Socio();
            s.Show();
        }

        private void ESocio_Click(object sender, RoutedEventArgs e)
        {
            VariablesGlobales.Socio = 1;
            VariablesGlobales.Empresa = 0;
            Socio s = new Socio();
            s.Show();
        }

        private void Pagos_Click(object sender, RoutedEventArgs e)
        {
            Transaccion t = new Transaccion();
            t.Show();
        }

        private void Empresas_Click(object sender, RoutedEventArgs e)
        {
            VariablesGlobales.CodEmpresa = 0;
            Empresa emp = new Empresa();
            emp.Show();
        }

        private void Contactos_Click(object sender, RoutedEventArgs e)
        {
            VariablesGlobales.CodContacto = 0;
            ContactoEmpresa ce = new ContactoEmpresa();
            ce.Show();
        }

        private void BusquedaSocio_Click(object sender, RoutedEventArgs e)
        {
            if (VariablesGlobales.rolDescripcion.ToUpper() != ConfigurationManager.AppSettings["rolAdmin"].ToUpper().ToString())
            {
                MessageBox.Show("El acceso es permitido solamente a administradores del sistema.", "Climb", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                VariablesGlobales.busquedaSocios = 0;
                BusquedaSocio b = new BusquedaSocio();
                b.Show();
                //if (VariablesGlobales.busquedaSocios == 1)
                //    this.txt_CodSocio.Text = VariablesGlobales.CodSocio.ToString();
            }

        }

        private void BusquedaPago_Click(object sender, RoutedEventArgs e)
        {
            if (VariablesGlobales.rolDescripcion.ToUpper() != ConfigurationManager.AppSettings["rolAdmin"].ToUpper().ToString())
            {
                MessageBox.Show("El acceso es permitido solamente a administradores del sistema.", "Climb", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                BusquedaTransaccion bt = new BusquedaTransaccion();
                bt.Show();
            }
        }

        private void BusquedaEmpresa_Click(object sender, RoutedEventArgs e)
        {
            BusquedaEmpresa bem = new BusquedaEmpresa();
            bem.Show();
        }

        private void BusquedaContacto_Click(object sender, RoutedEventArgs e)
        {
            BusquedaContactoEmpresa bce = new BusquedaContactoEmpresa();
            bce.Show();
        }

        private void BusquedaAsistencia_Click(object sender, RoutedEventArgs e)
        {
            BusquedaAsistencia ba = new BusquedaAsistencia();
            ba.Show();
        }

        private void CambioUsuario_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                Login l = new Login();
                l.Show();
                this.Hide();

                foreach (Window win in App.Current.Windows)
                {
                    if (win.Name == "AsistenciaW")
                        win.Close(); 
                    if (win.Name == "BAsistenciaW")
                        win.Close();
                    if (win.Name == "BContactoW")
                        win.Close();
                    if (win.Name == "BEmpresaW")
                        win.Close();
                    if (win.Name == "BSocioW")
                        win.Close();
                    if (win.Name == "BSocioAsistW")
                        win.Close();
                    if (win.Name == "BTransaccionW")
                        win.Close();
                    if (win.Name == "ConfirmAsistW")
                        win.Close();
                    if (win.Name == "ContactoEmpresaW")
                        win.Close();
                    if (win.Name == "EmpresaW")
                        win.Close();
                    if (win.Name == "SocioW")
                        win.Close();
                    if (win.Name == "TransaccionW")
                        win.Close();
                }

            }
            catch(Exception ex)
            {
                throw;
            }
            
        }
    }
}
