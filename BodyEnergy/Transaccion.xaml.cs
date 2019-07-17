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
using System.Globalization;
using System.Reflection;
using System.Data;

namespace BodyEnergy
{
    /// <summary>
    /// Interaction logic for Transaccion.xaml
    /// </summary>
    public partial class Transaccion : MetroWindow
    {
        #region Load
        private System.Drawing.Printing.PrintDocument docToPrint = new System.Drawing.Printing.PrintDocument();
        public Transaccion()
        {
            InitializeComponent();
            try
            {
                CargarTipoPago();
                CargarPeriodoPago();
                this.txt_Monto.Focus();
                if (VariablesGlobales.CodTransaccion == 0)
                {
                    this.lbl_Comprobante.Visibility = Visibility.Collapsed;
                    this.txt_Comprobante.Visibility = Visibility.Collapsed;
                    //this.txt_Comprobante.BorderBrush = Brushes.DarkRed;
                    this.btn_Actualizar.Visibility = Visibility.Collapsed;
                    this.btn_Guardar.Visibility = Visibility.Visible;
                    this.btn_Guardar.IsDefault = true;
                    if (VariablesGlobales.CodSocio > 0)
                    {
                        this.txt_Socio.Text = VariablesGlobales.CodSocio.ToString();
                    }
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

        #region Eventos
        private void btn_Guardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Validar())
                {
                    Guardar();

                    //this.docToPrint.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(PrintPage);
                    //docToPrint.PrinterSettings.PrinterName = ConfigurationManager.AppSettings["impresoraRecibos"].ToString();
                    //docToPrint.Print();
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

        private void cbo_TipoPago_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (this.cbo_TipoPago.SelectedValue != null)
                {
                    if (Convert.ToInt32(this.cbo_TipoPago.SelectedValue.ToString()) == Convert.ToInt32(ConfigurationManager.AppSettings["IndiceTarjeta"]))
                    {
                        this.lbl_Comprobante.Visibility = Visibility.Visible;
                        this.txt_Comprobante.Visibility = Visibility.Visible;
                        //this.txt_Comprobante.BorderBrush = Brushes.DarkRed;
                    }
                    else
                    {
                        this.lbl_Comprobante.Visibility = Visibility.Collapsed;
                        this.txt_Comprobante.Visibility = Visibility.Collapsed;
                        //this.txt_Comprobante.BorderBrush = Brushes.Gray;
                    }
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
                VariablesGlobales.busquedaSocios = 2;
                VariablesGlobales.CodSocio = 0;
                BusquedaSocio b = new BusquedaSocio();
                b.ShowDialog();
                this.txt_Socio.Text = VariablesGlobales.CodSocio.ToString();
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
                Actualizar();
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
                VariablesGlobales.CodTransaccion = 0;
                VariablesGlobales.CodSocio = 0;
            }
            catch
            {
                MessageBox.Show("En este momento la operación no puede ser realizada.", "Climb", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void txt_Monto_KeyDown(object sender, KeyEventArgs e)
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

        private void txt_Socio_KeyDown(object sender, KeyEventArgs e)
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

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                this.Hide();
                VariablesGlobales.CodTransaccion = 0;
                VariablesGlobales.CodSocio = 0;
            }
            catch
            {
                MessageBox.Show("En este momento la operación no puede ser realizada.", "Climb", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            System.Drawing.Font font = new System.Drawing.Font("Arial", 7, System.Drawing.FontStyle.Regular);

            int posicionY = 0;
            e.Graphics.DrawString("Recibo de Dinero", font, System.Drawing.Brushes.Black, 94, 0);
            posicionY += 16;
            e.Graphics.DrawString("Iron Gym", font, System.Drawing.Brushes.Black, 105, posicionY);
            //posicionY += 16;
            //e.Graphics.DrawString("Gerson Trigueros", font, System.Drawing.Brushes.Black, 86, posicionY);
            //posicionY += 16;
            //e.Graphics.DrawString("Céd: 1-1132-0239", font, System.Drawing.Brushes.Black, 83, posicionY);
            posicionY += 16;
            e.Graphics.DrawString("Teléfono: 2276-8080", font, System.Drawing.Brushes.Black, 81, posicionY);
            posicionY += 16;
            e.Graphics.DrawString("________________________________________________", font, System.Drawing.Brushes.Black, 5, posicionY);
            posicionY += 18;
            e.Graphics.DrawString("Tiquete: 1", font, System.Drawing.Brushes.Black, 5, posicionY);
            posicionY += 18;
            e.Graphics.DrawString("Fecha: " + DateTime.Now, font, System.Drawing.Brushes.Black, 5, posicionY);
            posicionY += 16;
            e.Graphics.DrawString("Cliente: Gerson Trigueros", font, System.Drawing.Brushes.Black, 5, posicionY);
            
            posicionY += 18;
            e.Graphics.DrawString("Detalle: Pago de Mensualidad", font, System.Drawing.Brushes.Black, 5, posicionY);
            posicionY += 16;
            //e.Graphics.DrawString("Cant.", font, System.Drawing.Brushes.Black, 5, posicionY);
            //e.Graphics.DrawString("Artículo", font, System.Drawing.Brushes.Black, 80, posicionY);
            e.Graphics.DrawString("Monto: C27 000.00", font, System.Drawing.Brushes.Black, 5, posicionY);
            posicionY += 16;
            //e.Graphics.DrawString("Cant.", font, System.Drawing.Brushes.Black, 5, posicionY);
            //e.Graphics.DrawString("Artículo", font, System.Drawing.Brushes.Black, 80, posicionY);
            e.Graphics.DrawString("Periodo: Agosto", font, System.Drawing.Brushes.Black, 5, posicionY);

            int posicionYArticulo = 0;
            int aumentoGeneral = 0;

            //imprimir articulos
            //GdvArticulos.UpdateLayout();
            
            posicionY += 18;
            e.Graphics.DrawString("GRACIAS POR SU VISITA", font, System.Drawing.Brushes.Black, 65, posicionY);
            //posicionY += 15;
            //e.Graphics.DrawString("FIRMA AUTORIZADA", font, System.Drawing.Brushes.Black, 70, posicionY);
            //e.Graphics.DrawString("***REIMPRESIÓN***", font, System.Drawing.Brushes.Black, 70, posicionY);

        }
        #endregion

        #region Metodos
        private void CargarDatos()
        {
            try
            {
                Gym.Service.SoapServiceClient proxy = new Gym.Service.SoapServiceClient();
                TransaccionDTO dto = new TransaccionDTO();

                dto = proxy.ObtenerTransaccion(VariablesGlobales.CodTransaccion);
                
                if (dto == null)
                    MessageBox.Show("No se pudo cargar la información.", "Climb", MessageBoxButton.OK, MessageBoxImage.Information);
                else
                {
                    double amount;

                    this.txt_Socio.Text = dto.CodSocio.ToString();
                    this.txt_Detalle.Text = dto.Detalle;
                    this.txt_Monto.Text = Double.TryParse(dto.Monto.ToString(), NumberStyles.Number, null, out amount) ? amount.ToString("n") : 0.ToString("n");
                    //this.txt_Monto.Text = dto.Monto.ToString();
                    this.cbo_TipoPago.SelectedValue = dto.CodTipoPago;
                    this.txt_Comprobante.Text = dto.NumComprobante;
                    this.txt_NumeroRecibo.Text = dto.CodTransaccion.ToString();

                    FechaVencimientoDTO fdto = new FechaVencimientoDTO();

                    fdto = proxy.ObtenerFecha(dto.CodSocio);
                    if (fdto != null)
                    {
                        this.dpc_FechaVencimiento.Text = fdto.FechaVencimiento.ToShortDateString();
                            
                    }
                    this.cbo_PeriodoPago.SelectedValue = dto.CodCatPago;
                }
                proxy.Close();
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        private void Guardar()
        {
            try
            {
                
                TransaccionDTO tranDto = new TransaccionDTO();
                Gym.Service.SoapServiceClient proxy = new Gym.Service.SoapServiceClient();

                FechaVencimientoDTO fecDto = new FechaVencimientoDTO();

                tranDto.Method = Common.ObjectMethod.New;
                tranDto.Descripcion = string.Empty;
                tranDto.Detalle = this.txt_Detalle.Text.ToString();
                tranDto.Monto = Convert.ToDecimal(this.txt_Monto.Text.Trim().ToString().Replace(",", ""));
                tranDto.FechaTransaccion = DateTime.Now;
                tranDto.EsActivo = true;
                tranDto.CodTipoPago = Convert.ToInt32(this.cbo_TipoPago.SelectedValue.ToString());//Tarjeta o Efectivo
                tranDto.CodSocio = Convert.ToInt32(this.txt_Socio.Text.Trim().ToString());
                tranDto.NumComprobante = this.txt_Comprobante.Text.Trim().ToString();
                tranDto.NumReciboGym = this.txt_NumeroRecibo.Text.Trim().ToString();
                tranDto.UsuarioCreacion = VariablesGlobales.usuarioBD;
                tranDto.FechaCreacion = DateTime.Now;
                tranDto.CodCatPago = Convert.ToInt32(this.cbo_PeriodoPago.SelectedValue.ToString());
                int idFactura = proxy.SaveTransaction(tranDto);

                fecDto.Method = Common.ObjectMethod.Modify;
                fecDto.CodSocio = Convert.ToInt32(this.txt_Socio.Text.Trim().ToString());
                fecDto.FechaVencimiento = Convert.ToDateTime(this.dpc_FechaVencimiento.Text.ToString());
                fecDto.Descripcion = string.Empty;
                fecDto.UsuarioModificacion = VariablesGlobales.usuarioBD;
                fecDto.FechaModificacion = DateTime.Now;
                proxy.SaveExpireDate(fecDto);
                MessageBox.Show("Factura: " + idFactura.ToString()  + " generada exitosamente.", "Climb", MessageBoxButton.OK, MessageBoxImage.Information);


                proxy.Close();
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
                Gym.Service.SoapServiceClient proxy = new Gym.Service.SoapServiceClient();
                TransaccionDTO tranDto = new TransaccionDTO();
                FechaVencimientoDTO fecDto = new FechaVencimientoDTO();

                tranDto.Method = Common.ObjectMethod.Modify;
                tranDto.CodTransaccion = VariablesGlobales.CodTransaccion;
                tranDto.Descripcion = string.Empty;
                tranDto.Detalle = this.txt_Detalle.Text.ToString();
                tranDto.Monto = Convert.ToDecimal(this.txt_Monto.Text.Trim().ToString());
                tranDto.FechaTransaccion = DateTime.Now;
                tranDto.EsActivo = true;
                tranDto.CodTipoPago = Convert.ToInt32(this.cbo_TipoPago.SelectedValue.ToString());//Tarjeta o Efectivo
                tranDto.CodSocio = Convert.ToInt32(this.txt_Socio.Text.Trim().ToString());
                tranDto.NumComprobante = this.txt_Comprobante.Text.Trim().ToString();
                tranDto.NumReciboGym = this.txt_NumeroRecibo.Text.Trim().ToString();
                tranDto.UsuarioModificacion = VariablesGlobales.usuarioBD;
                tranDto.FechaModificacion = DateTime.Now;
                tranDto.CodCatPago = Convert.ToInt32(this.cbo_PeriodoPago.SelectedValue.ToString());
                int idFactura = proxy.SaveTransaction(tranDto);

                fecDto.Method = Common.ObjectMethod.Modify;
                fecDto.CodSocio = Convert.ToInt32(this.txt_Socio.Text.Trim().ToString());
                fecDto.FechaVencimiento = Convert.ToDateTime(this.dpc_FechaVencimiento.Text.ToString());
                fecDto.Descripcion = string.Empty;
                fecDto.UsuarioModificacion = VariablesGlobales.usuarioBD;
                fecDto.FechaModificacion = DateTime.Now;
                proxy.SaveExpireDate(fecDto);

                MessageBox.Show("Factura: " + idFactura.ToString() + " ha sido modificada.", "Climb", MessageBoxButton.OK, MessageBoxImage.Information);
                proxy.Close();
                Limpiar();
            }
            catch
            {
                throw;
            }
        }

        #region Cargas
        private void CargarPeriodoPago()
        {
            try
            {
                Gym.Service.SoapServiceClient proxy = new Gym.Service.SoapServiceClient();
                this.cbo_PeriodoPago.ItemsSource = proxy.ObtenerTodasCatPago();
                this.cbo_PeriodoPago.DisplayMemberPath = "Descripcion";
                this.cbo_PeriodoPago.SelectedValuePath = "CodCatPago";
                this.cbo_PeriodoPago.SelectedValue = 0;
                proxy.Close();
            }
            catch
            {
                throw;
            }
        }

        private void CargarTipoPago()
        {
            try
            {
                Gym.Service.SoapServiceClient proxy = new Gym.Service.SoapServiceClient();

                this.cbo_TipoPago.ItemsSource = proxy.ObtenerTodosTiposPago();
                this.cbo_TipoPago.DisplayMemberPath = "Descripcion";
                this.cbo_TipoPago.SelectedValuePath = "CodTipoPago";
                this.cbo_TipoPago.SelectedValue = 0;

                proxy.Close();
            }
            catch
            {
                throw;
            }
        }
        #endregion

        private void Limpiar()
        {
            try
            {
                this.txt_Socio.Text = string.Empty;
                this.txt_Detalle.Text = string.Empty;
                this.txt_Monto.Text = string.Empty;
                this.cbo_TipoPago.SelectedValue = 0;
                this.txt_Comprobante.Text = string.Empty;
                this.txt_NumeroRecibo.Text = string.Empty;
                this.dpc_FechaVencimiento.Text = string.Empty;
                this.cbo_PeriodoPago.SelectedValue = 0;
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
                if (this.txt_Socio.Text == string.Empty)
                {
                    mensaje += "Debe Ingresar un valor en el campo: Número de Socio." + "\n";
                    desplegarError = true;
                }
                if (this.txt_Monto.Text == string.Empty)
                {
                    mensaje += "Debe Ingresar un valor en el campo: Monto." + "\n";
                    desplegarError = true;
                }
                if (Convert.ToInt32(this.cbo_TipoPago.SelectedValue) == 0)
                {
                    mensaje += "Debe Seleccionar un valor en el campo: Tipo de Pago." + "\n";
                    desplegarError = true;
                }
                //if (this.txt_Comprobante.IsVisible == true)
                //{
                //    if (this.txt_Comprobante.Text == string.Empty)
                //    {
                //        mensaje += "Debe Ingresar un valor en el campo: Comprobante." + "\n";
                //        desplegarError = true;
                //    }
                //}
                //if (this.txt_NumeroRecibo.Text == string.Empty)
                //{
                //    mensaje += "Debe Ingresar un valor en el campo: Número de Recibo." + "\n";
                //    desplegarError = true;
                //}
                if (this.dpc_FechaVencimiento.Text == string.Empty)
                {
                    mensaje += "Debe Ingresar un valor en el campo: Fecha de Vencimiento." + "\n";
                    desplegarError = true;
                }
                if (Convert.ToInt32(this.cbo_PeriodoPago.SelectedValue) == 0)
                {
                    mensaje += "Debe Seleccionar un valor en el campo: Período de Pago." + "\n";
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

        private void cbo_PeriodoPago_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                int data = ((CategoriaPagoDTO)e.AddedItems[0]).CodCatPago;
                if (data == Convert.ToInt32(ConfigurationManager.AppSettings["sesion"].ToString()))
                {
                    dpc_FechaVencimiento.Text = DateTime.Now.ToShortDateString();
                }
                else if (data == Convert.ToInt32(ConfigurationManager.AppSettings["mensual"].ToString()))
                {
                    dpc_FechaVencimiento.Text = DateTime.Now.AddMonths(1).ToShortDateString();
                }
                else if (data == Convert.ToInt32(ConfigurationManager.AppSettings["cuatrimestre"].ToString()))
                {
                    dpc_FechaVencimiento.Text = DateTime.Now.AddMonths(4).ToShortDateString();
                }
                else if (data == Convert.ToInt32(ConfigurationManager.AppSettings["anual"].ToString()))
                {
                    dpc_FechaVencimiento.Text = DateTime.Now.AddMonths(12).ToShortDateString();
                }
            }
            catch(Exception ex)
            {
                throw;
            }
            
        }
    }
}
