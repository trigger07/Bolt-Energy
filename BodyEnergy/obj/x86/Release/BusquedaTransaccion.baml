   M S B A M L   `   `   `  ���� T  PMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  Z VVIBlend.WPF.Editors, Version=5.0.0.0, Culture=neutral, PublicKeyToken=5f568d4f9cd901f1X?clr-namespace:VIBlend.WPF.Controls;assembly=VIBlend.WPF.EditorsVIBlend.WPF.Controls  
BodyEnergy$   BodyEnergy.BusquedaTransaccion   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Pcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     ZviblendEditors?clr-namespace:VIBlend.WPF.Controls;assembly=VIBlend.WPF.Editors     6my-http://schemas.microsoft.com/wpf/2008/toolkit  -   $��BTransaccionW��  � Title$  Reporte de Pagos��$	��520��$	��830�� � SizeToContent$ Height=� � WindowStyle$ ThreeDBorderWindow=� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � Icon$: 4/BodyEnergy;component/Imagenes_Sistema/CLIMB (8).png�� � ShowInTaskbar .  � Topmost .  .��]� ��. .+��� $	��Top=�$��9�����	#0A000000�� $��45��$��Bottom=����	#36000000._��� -   $��
pnl_Montos�� �� Orientation$ 
Horizontal=�$��20,0,0,0q�.+��� -   $��lbl_Efectivo��$��
Efectivo: ��$��0,0,0,0q�$��14(�$��28��$��Center=�$��Center=�'  !VIBlend.WPF.Controls.NumberEditor  -   	  Name$	 txt_Efectivo��$  VIBlend.WPF.Controls.InputBase
   CultureInfo$
 en-US��$��23�� �� TextWrapping$
 Wrap=�$��6��$	��149��$
��0,11q��� -   $��lbl_Tarjeta��$��	Tarjeta: ��$��20,0,0,0q�$��14(�$��28��$��Center=�$��Center=�  -   $	 txt_Tarjeta��$
 en-US��$��23��$
 Wrap=�$��6��$	��149��$��0,10,0,9q��� -   $��lbl_MontoTotal��$��Monto Total: ��$��50,0,0,0q�$��14(�$��28��$��Center=�$��Center=�  -   $	 txt_MontoTotal��$
 en-US��$��23��$
 Wrap=�$��6��$	��149��$��0,10,0,9q��� ���	#0A000000._��  � ColumnDefinitions �� $
��371* ��� $
��373* �.+��� -	   $��	lbl_Socio��$��Número de Socio��$��14(�$��28��$
��Left=�$��
14,0,0,410q�$��Bottom=��� -
   $��	txt_socio��$��28��$
��Left=�$��
14,0,0,382q�$��Bottom=�$	��120�� �� 	MaxLength$ 15��$��Center=�$��Center=�$��14(�$��1�� � ToolTip$  Filtro de Número de Socio���� -   $��lbl_TipoPago��$��Tipo de Pago��$��28��$��14(�$
��Left=�$��148,0,0,410q�$��Bottom=��� -   $��cbo_TipoPago��$��28��$
��Left=�$��148,0,0,382q�$��Bottom=�$	��136��$��Center=�
�������$��2��$ Filtro de Tipo de Pago���� -   $��lbl_FechaInicio��$��Fecha Inicial��$��14(�$��28��$
��Left=�$��295,0,0,410q�$��Bottom=�$��2��+  %Microsoft.Windows.Controls.DatePicker  -   $��dcp_FechaInicio��$
��Left=�$��295,0,0,382q�$��Bottom=�$��28��$	��143��$��3��$ Fecha Inicial��
�������$��Center=�$��14(�$��2���� -   $��
btn_Buscar��$��50��
������    MetroCircleButtonStyle#���   $
��Left=�$	��Top=�$��50��$ Buscar��$��5��$��
301,11,0,0q�$��1��.���� $
��Fill=�$��25��$��25��$;��5/BodyEnergy;component/Imagenes_Sistema/search_red.png��$ Buscar�� � Cursor$
 Hand���� -   $��btn_Exportar��$��
349,11,0,0q�#���   
������ $
��Left=�$��50��$	��Top=�$��50��$��6��$
 Hand��$��1��.���� $
��Fill=�$��25��$��25��$<��6/BodyEnergy;component/Imagenes_Sistema/excel-file2.png��$ Exportar a Excel��$
 Hand��&   System.Windows.Controls.DataGrid  -   $��gdv_Transacciones��$
��Left=�$��	12,0,0,10q�$��Bottom=�$	��802��   AutoGenerateColumns .     CanUserResizeColumns .    
IsReadOnly . $
 Hand��$��Center=�$��1q�   ColumnHeaderHeight$ 25Q�
�������   	RowHeight$ 20Q�$	��353��$��2������    Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Codigo��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 10    
Visibility$ Hidden=�   
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Cod_Transaccion+  $ Socio��$	 190  .  �� *Nombre_Completo+  $ Monto��$ 95  .  �� *Monto+ �� StringFormat$ {0:N}��  $ Fecha��$	 135  .  �� *Fecha_Transaccion+  $ Tipo de Pago��$	 105  .  �� *Descripcion_TipoPago+  $ Factura��$	 110  .  �� *Cod_Transaccion+  $ Período��$ 80  .  �� *	Periodo+  $ Estado��$ 80  .  �� *Estado+   RowDetailsTemplate �� .R��� $ 
Horizontal=�$��Center=�$��0,5,0,5q�.+��� $��btn_Eliminar��-   $��90��$��0,0,10,0q�$��Anular��  -   $��dcp_FechaFinal��$
��Left=�$��28��$	��146��$��
41,0,0,382q�$��Bottom=�$��4��$ Fecha Final ��$��14(�$��Center=�
�������$��1���� -   $��label1��$��Fecha Final��$��14(�$��28��$
��Left=�$��
41,0,0,410q�$��Bottom=�$��1���� -   $��chk_hoy��$��28��$
��Left=�$��207,0,0,382q�$��Bottom=�$ Pagos del Día de Hoy�� J� SnapsToDevicePixels . $��5��$��1���� -   $��lbl_Hoy��$	��Hoy��$��28��$
��Left=�$��200,0,0,408q�$��Bottom=�$��1��