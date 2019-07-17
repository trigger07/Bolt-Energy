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
    /// Interaction logic for BusquedaSocio.xaml
    /// </summary>
    public partial class BusquedaSocio : MetroWindow
    {
        object misValue = System.Reflection.Missing.Value;
        #region Load
        public BusquedaSocio()
        {
            InitializeComponent();
            try
            {
                this.CargarEmpresa();
                this.CargarTipoSocio();
                //this.CargarGrid();
                this.txt_NombreCompleto.Focus();
                this.btn_Buscar.IsDefault = true;
            }
            catch
            {
                MessageBox.Show("En este momento la operación no puede ser realizada.", "Climb", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
        #endregion

        #region Metodos
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

        private DataTable Grid()
        {
            try
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                Gym.Service.SoapServiceClient proxy = new Gym.Service.SoapServiceClient();

                string nombreCompleto = string.Empty;
                int codTipoSocio = 0;
                int codEmpresa = 0;


                nombreCompleto = this.txt_NombreCompleto.Text.ToString();

                codTipoSocio = Convert.ToInt32(this.cbo_TipoSocio.SelectedValue.ToString());
                codEmpresa = Convert.ToInt32(this.cbo_Empresa.SelectedValue.ToString());

                ds = (DataSet)DTOSerializer.Deserialize(proxy.ObtenerSociosBusqueda(nombreCompleto, codTipoSocio, codEmpresa, this.dcp_Fecha.Text.ToString()), typeof(DataSet));

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

                    wb.Close(true, ConfigurationManager.AppSettings["RutaExcel"] + "Reporte_Socios_" + fecha, misValue);
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

                codTipoSocio = Convert.ToInt32(this.cbo_TipoSocio.SelectedValue.ToString());
                codEmpresa = Convert.ToInt32(this.cbo_Empresa.SelectedValue.ToString());

                ds = (DataSet)DTOSerializer.Deserialize(proxy.ObtenerSociosBusqueda(nombreCompleto, codTipoSocio, codEmpresa, this.dcp_Fecha.Text.ToString()), typeof(DataSet));
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
        #endregion
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

        private void gdv_Socios_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                
                switch (VariablesGlobales.busquedaSocios)
                {
                    case 0:
                        VariablesGlobales.Socio = 0;
                        VariablesGlobales.CodSocio = 0;
                        DataRowView row = gdv_Socios.SelectedItem as DataRowView;
                        if (row != null)
                        {
                            VariablesGlobales.Socio = Convert.ToInt32(row["Numero_Socio"].ToString());
                            VariablesGlobales.CodSocio = Convert.ToInt32(row["Numero_Socio"].ToString());
                            Socio s = new Socio();
                            s.Show();
                            this.Hide();
                        }
                        break;
                    case 1:
                        DataRowView row1 = gdv_Socios.SelectedItem as DataRowView;
                        if (row1 != null)
                        {
                            VariablesGlobales.CodSocio = Convert.ToInt32(row1["Numero_Socio"].ToString());
                            this.Hide();
                        }   
                        break;
                    case 2:
                        DataRowView row2 = gdv_Socios.SelectedItem as DataRowView;
                        if (row2 != null)
                        {
                            VariablesGlobales.CodSocio = Convert.ToInt32(row2["Numero_Socio"].ToString());
                            this.Hide();
                        } 
                        break;
                    case 3:
                        DataRowView row3 = gdv_Socios.SelectedItem as DataRowView;
                        if (row3 != null)
                        {
                            VariablesGlobales.CodSocio = Convert.ToInt32(row3["Numero_Socio"].ToString());
                            this.Hide();
                        }
                        break;
                }
                
            }
            catch
            {
                MessageBox.Show("En este momento la operación no puede ser realizada.", "Climb", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void btn_Asistencia_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                VariablesGlobales.Socio = 0;
                VariablesGlobales.CodSocio = 0;
                DataRowView row = gdv_Socios.SelectedItem as DataRowView;
                VariablesGlobales.CodSocio = Convert.ToInt32(row["Numero_Socio"].ToString());
                VariablesGlobales.busquedaSocios = 1;
                this.Hide();
            }
            catch
            {
                MessageBox.Show("En este momento la operación no puede ser realizada.", "Climb", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }          
        }

        private void btn_Editar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                VariablesGlobales.Socio = 0;
                VariablesGlobales.CodSocio = 0;
                DataRowView row = gdv_Socios.SelectedItem as DataRowView;
                VariablesGlobales.Socio = Convert.ToInt32(row["Numero_Socio"].ToString());
                VariablesGlobales.CodSocio = Convert.ToInt32(row["Numero_Socio"].ToString());
                Socio s = new Socio();
                s.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("En este momento la operación no puede ser realizada.", "Climb", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void btn_Pago_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                VariablesGlobales.Socio = 0;
                VariablesGlobales.CodSocio = 0;
                DataRowView row = gdv_Socios.SelectedItem as DataRowView;
                VariablesGlobales.CodSocio = Convert.ToInt32(row["Numero_Socio"].ToString());
                Transaccion t = new Transaccion();
                t.Show();
                this.Hide();
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
                VariablesGlobales.CodSocio = 0;
                VariablesGlobales.Socio = 0;
            }
            catch
            {
                MessageBox.Show("En este momento la operación no puede ser realizada.", "Climb", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
        #region Comentado
        //private void btn_EditarGrid_Click(object sender, RoutedEventArgs e)
        //{
        //    DataRowView row = gdv_Socios.SelectedItem as DataRowView;
        //    MessageBox.Show(row["Numero_Socio"].ToString());
        //    //VariablesGlobales.CodSocio = Convert.ToInt32(this.txt_Cod_Socio.Text.ToString());
        //    //Socio s = new Socio();
        //    //s.Show();    
        //}
        #endregion 
    }
}
