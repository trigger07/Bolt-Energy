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
    /// Interaction logic for BusquedaEmpresa.xaml
    /// </summary>
    public partial class BusquedaEmpresa : MetroWindow
    {
        object misValue = System.Reflection.Missing.Value;
        #region Load
        public BusquedaEmpresa()
        {
            InitializeComponent();
            this.txt_Empresa.Focus();
            this.btn_Buscar.IsDefault = true;
        }
        #endregion

        #region Metodos
        private void CargarGrid()
        {
            try
            {
                this.gdv_Empresas.DataContext = null;
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                Gym.Service.SoapServiceClient proxy = new Gym.Service.SoapServiceClient();

                ds = (DataSet)DTOSerializer.Deserialize(proxy.ObtenerEmpresasBusqueda(this.txt_Empresa.Text.ToString()), typeof(DataSet));
                proxy.Close();

                dt = ds.Tables[0];
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron registros.", "Climb", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                    this.gdv_Empresas.DataContext = dt;
            }
            catch
            {
                throw;
            }
        }

        private DataTable Grid()
        {
            try
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                Gym.Service.SoapServiceClient proxy = new Gym.Service.SoapServiceClient();

                ds = (DataSet)DTOSerializer.Deserialize(proxy.ObtenerEmpresasBusqueda(this.txt_Empresa.Text.ToString()), typeof(DataSet));
                proxy.Close();
                dt = ds.Tables[0];

                return dt;
            }
            catch
            {
                throw;
            }
        }

        private void Exportar()
        {
            Microsoft.Office.Interop.Excel.Application app = null;
            Microsoft.Office.Interop.Excel.Workbook wb = null;
            Microsoft.Office.Interop.Excel.Worksheet ws = null;
            try
            {
                DataTable dt = new DataTable();
                dt = Grid();

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron registros.", "Climb", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    app = new Microsoft.Office.Interop.Excel.Application();
                    wb = app.Workbooks.Add(misValue);
                    ws = app.ActiveWorkbook.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;

                    Microsoft.Office.Interop.Excel.Range range;
                    range = ws.get_Range("A2", misValue);
                    range = range.get_Resize(dt.Rows.Count, dt.Columns.Count);

                    Microsoft.Office.Interop.Excel.Range columnNameRange;
                    columnNameRange = ws.get_Range("A1", misValue);
                    columnNameRange = columnNameRange.get_Resize(1, dt.Columns.Count);

                    string[] columNames = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        columNames[i] = dt.Columns[i].ColumnName;
                    }
                    columnNameRange.set_Value(misValue, columNames);

                    string[,] arr = new string[dt.Rows.Count, dt.Columns.Count];
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            arr[i, j] = dt.Rows[i][j].ToString();
                        }
                    }
                    range.set_Value(misValue, arr);
                    string anio = string.Empty;
                    string mes = string.Empty;
                    string dia = string.Empty;
                    string fecha = string.Empty;
                    anio = DateTime.Now.Year.ToString();
                    mes = DateTime.Now.Month.ToString();
                    dia = DateTime.Now.Day.ToString();
                    fecha = dia + "-" + mes + "-" + anio;

                    wb.Close(true, ConfigurationManager.AppSettings["RutaExcel"] + "Reporte_Empresas_" + fecha, misValue);
                    MessageBox.Show("El archivo ha sido creado exitosamente", "Climb", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                if (app != null)
                {
                    app.UserControl = false;
                    app.Quit();
                    app = null;
                }
            }
        }
        #endregion

        #region Eventos
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

        private void gdv_Empresas_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DataRowView row = this.gdv_Empresas.SelectedItem as DataRowView;
                if (row != null)
                {
                    VariablesGlobales.CodEmpresa = Convert.ToInt32(row["Codigo"].ToString());
                    Empresa emp = new Empresa();
                    emp.Show();
                    this.Hide();
                }
                
            }
            catch
            {
                MessageBox.Show("En este momento la operación no puede ser realizada.", "Climb", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void btn_Exportar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Exportar();
            }
            catch
            {
                MessageBox.Show("En este momento la operación no puede ser realizada.", "Climb", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
        #endregion  

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            try
            {
                VariablesGlobales.CodEmpresa = 0;
            }
            catch
            {
                MessageBox.Show("En este momento la operación no puede ser realizada.", "Climb", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

    }
}
