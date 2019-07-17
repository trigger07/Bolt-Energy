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
    /// Interaction logic for BusquedaAsistencia.xaml
    /// </summary>
    public partial class BusquedaAsistencia : MetroWindow
    {
        object misValue = System.Reflection.Missing.Value;
        #region Load
        public BusquedaAsistencia()
        {
            InitializeComponent();
            this.txt_socio.Focus();
            this.btn_Buscar.IsDefault = true;
            this.pnl_Montos.Visibility = Visibility.Collapsed;
        }
        #endregion

        #region Metodos
        private void CargarGrid()
        {
            try
            {
                Gym.Service.SoapServiceClient proxy = new Gym.Service.SoapServiceClient();

                this.gdv_Asistencia.DataContext = null;
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();

                int codSocio = 0;
                bool hoy = false;

                if (this.txt_socio.Text == string.Empty)
                    codSocio = 0;
                else
                    codSocio = Convert.ToInt32(this.txt_socio.Text.Trim().ToString());

                if (chk_hoy.IsChecked == true)
                    hoy = true;
                else
                    hoy = false;

                ds = (DataSet)DTOSerializer.Deserialize(proxy.ObtenerAsistenciasBusqueda(codSocio, this.dcp_FechaInicio.Text.ToString(), this.dcp_FechaFinal.Text.ToString(), hoy), typeof(DataSet));
                proxy.Close();
                dt = ds.Tables[0];
                if (dt.Rows.Count == 0)
                {
                    this.pnl_Montos.Visibility = Visibility.Collapsed;
                    MessageBox.Show("No se encontraron registros.", "Climb", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    int contador = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        contador = contador + 1;
                    }
                    this.gdv_Asistencia.DataContext = dt;
                    this.pnl_Montos.Visibility = Visibility.Visible;
                    this.txt_Asistencia.Text = contador.ToString();
                }
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
                if (this.dcp_FechaInicio.Text != string.Empty && this.dcp_FechaFinal.Text == string.Empty)
                {
                    mensaje += "Debe Ingresar la Fecha Final." + "\n";
                    desplegarError = true;
                }
                if (this.dcp_FechaInicio.Text == string.Empty && this.dcp_FechaFinal.Text != string.Empty)
                {
                    mensaje += "Debe Ingresar la Fecha Inicial." + "\n";
                    desplegarError = true;
                }
                if (this.dcp_FechaInicio.Text != string.Empty && this.dcp_FechaFinal.Text != string.Empty)
                {
                    if (Convert.ToDateTime(dcp_FechaInicio.Text.ToString()) > Convert.ToDateTime(dcp_FechaFinal.Text.ToString()))
                    {
                        mensaje += "La Fecha Inicial no puede ser mayor que la Fecha Final." + "\n";
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

        private DataTable Grid()
        {
            try
            {
                Gym.Service.SoapServiceClient proxy = new Gym.Service.SoapServiceClient();
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();

                int codSocio = 0;
                bool hoy = false;

                if (this.txt_socio.Text == string.Empty)
                    codSocio = 0;
                else
                    codSocio = Convert.ToInt32(this.txt_socio.Text.Trim().ToString());

                if (chk_hoy.IsChecked == true)
                    hoy = true;
                else
                    hoy = false;

                ds = (DataSet)DTOSerializer.Deserialize(proxy.ObtenerAsistenciasBusqueda(codSocio, this.dcp_FechaInicio.Text.ToString(), this.dcp_FechaFinal.Text.ToString(), hoy), typeof(DataSet));
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
                    MessageBox.Show("No se encontraron registros.", "Climb", MessageBoxButton.OK, MessageBoxImage.Information);
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

                    wb.Close(true, ConfigurationManager.AppSettings["RutaExcel"] + "Reporte_Asistencia_" + fecha, misValue);
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
                if (Validar())
                {
                    CargarGrid();
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

        private void btn_Exportar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Validar())
                {
                    Exportar();
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

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
               
            }
            catch
            {
                MessageBox.Show("En este momento la operación no puede ser realizada.", "Climb", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void txt_socio_KeyDown(object sender, KeyEventArgs e)
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

        private void btn_Eliminar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Gym.Service.SoapServiceClient proxy = new Gym.Service.SoapServiceClient();
                DataRowView row = this.gdv_Asistencia.SelectedItem as DataRowView;
                if (row != null)
                {
                    if (VariablesGlobales.rolDescripcion.ToUpper() != ConfigurationManager.AppSettings["rolAdmin"].ToUpper().ToString())
                    {
                        MessageBox.Show("Solamente los administradores pueden eliminar registros.", "Climb", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    }
                    else
                    {
                        
                        proxy.BorrarAsistencia(Convert.ToInt32(row["Codigo"].ToString()));
                        proxy.Close();

                        CargarGrid();
                        MessageBox.Show("El registro ha sido eliminado.", "Climb", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
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
