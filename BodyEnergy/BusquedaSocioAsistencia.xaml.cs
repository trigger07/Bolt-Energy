using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Data;
using System.Data.Common;
using Data.DTO;
using System.Configuration;
using Microsoft.Win32;
using MahApps.Metro.Controls;
using Common;

namespace BodyEnergy
{
    /// <summary>
    /// Interaction logic for BusquedaSocioAsistencia.xaml
    /// </summary>
    public partial class BusquedaSocioAsistencia : MetroWindow
    {
        public BusquedaSocioAsistencia()
        {
            InitializeComponent();
            try
            {
                this.txt_NombreCompleto.Focus();
                this.btn_Buscar.IsDefault = true;
            }
            catch
            {
                MessageBox.Show("En este momento la operación no puede ser realizada.", "Climb", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void btn_Buscar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CargarGrid();
            }
            catch
            {
                MessageBox.Show("En este momento la operación no puede ser realizada.", "Climb", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void gdv_Socios_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {

                DataRowView row1 = gdv_Socios.SelectedItem as DataRowView;
                if (row1 != null)
                {
                    VariablesGlobales.CodSocio = Convert.ToInt32(row1["Numero_Socio"].ToString());
                    this.Hide();
                }

            }
            catch
            {
                MessageBox.Show("En este momento la operación no puede ser realizada.", "Climb", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void CargarGrid()
        {
            try
            {
                this.gdv_Socios.DataContext = null;
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                Gym.Service.SoapServiceClient proxy = new Gym.Service.SoapServiceClient();

                string nombreCompleto = string.Empty;
                int codTipoSocio = 0;
                int codEmpresa = 0;


                nombreCompleto = this.txt_NombreCompleto.Text.ToString();

                ds = (DataSet)DTOSerializer.Deserialize(proxy.ObtenerSociosBusqueda(nombreCompleto, codTipoSocio, codEmpresa, ""), typeof(DataSet));

                dt = ds.Tables[0];
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron registros.", "Climb", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    this.gdv_Socios.DataContext = dt;
                    if (VariablesGlobales.busquedaSocios > 0)
                        this.gdv_Socios.RowDetailsVisibilityMode = DataGridRowDetailsVisibilityMode.Collapsed;
                    else
                        this.gdv_Socios.RowDetailsVisibilityMode = DataGridRowDetailsVisibilityMode.VisibleWhenSelected;
                }
            }
            catch
            {
                throw;
            }
        }

        private void txt_NombreCompleto_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (txt_NombreCompleto.Text.Count() >= 3)
                {
                    CargarGrid();
                }
            }
            catch
            {
                MessageBox.Show("En este momento la operación no puede ser realizada.", "Climb", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
    }
}
