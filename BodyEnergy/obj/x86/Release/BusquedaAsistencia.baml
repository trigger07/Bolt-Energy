   M S B A M L   `   `   `  ���� U  QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35[<clr-namespace:Microsoft.Windows.Controls;assembly=WPFToolkitMicrosoft.Windows.Controls  T PMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  
BodyEnergy#   BodyEnergy.BusquedaAsistencia   Cmy<clr-namespace:Microsoft.Windows.Controls;assembly=WPFToolkit  \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Pcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     -   $��BAsistenciaW��  � Title$  
Asistencia��$	��520��$	��650�� � SizeToContent$ Height=� � WindowStyle$ ThreeDBorderWindow=� � 
ResizeMode$ NoResize=� � Icon$: 4/BodyEnergy;component/Imagenes_Sistema/CLIMB (8).png�� � ShowInTaskbar .  � Topmost .   � WindowStartupLocation$ CenterScreen=�.��]� ��. .+��� $	��Top=�$��16�����	#0A000000�� $��43��$��Bottom=����	#36000000._��� -   $��
pnl_Montos�� �� Orientation$ 
Horizontal=�$��20,0,0,0q�.+��� -   $��lbl_Asistencia��$��Cantidad de Asistencia: ��$��0,0,0,0q�$��14(�$��28��$��Center=�$��Center=��� -   $��txt_Asistencia��$��23��$	��120���� ���	#0A000000._�� .+��� -   $��	lbl_Socio��$��Número de Socio��$��14(�$
��Left=�$��14,-2,0,407q��� -   $��	txt_socio��$��28��$
��Left=�$��
14,0,0,379q�$��Bottom=�$	��120��	 �� 	MaxLength$	 15��$��Center=�$��Center=�$��14(�$��1��
 � ToolTip$ 
 Filtro de Número de Socio���� -   $��lbl_FechaInicio��$��Fecha Inicial��$��14(�$
��Left=�$��150,-2,0,407q�+   %Microsoft.Windows.Controls.DatePicker  -   $��dcp_FechaInicio��$
��Left=�$��150,0,0,379q�$��Bottom=�$��28��$	��143��$��3��$
 Fecha Inicial��
�������$��Center=�$��14(��� -	   $��
btn_Buscar��$��50��   MetroCircleButtonStyle#���   $
��Left=�$��528,0,0,375q�$��Bottom=�$��50��$��6��.���� $
��Fill=�$��25��$��25��$;��5/BodyEnergy;component/Imagenes_Sistema/search_red.png��$
 Buscar�� � Cursor$
 Hand���� -
   $��btn_Exportar��$��575,0,0,375q�#���   $
��Left=�$��Bottom=�$��50��$��50��$��7��$
 Hand��.���� $
��Fill=�$��25��$��25��$<��6/BodyEnergy;component/Imagenes_Sistema/excel-file2.png��$
 Exportar a Excel��$
 Hand��&   System.Windows.Controls.DataGrid  -   $��gdv_Asistencia��$��
12,0,10,10q�   AutoGenerateColumns .     CanUserResizeColumns .    
IsReadOnly . $
 Hand��$��Center=�$   HorizontalScrollBarVisibility$ Disabled=�$��1q�   ColumnHeaderHeight$ 25Q�
�������   	RowHeight$ 20Q�$	��351��$��Bottom=�����    Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Codigo��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 20    
Visibility$ Hidden=�   
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Codigo+  $ Código��$ 75  .  �� *Numero_Socio+  $ Socio��$	 230  .  �� *Socio+  $ Fecha de Asistencia��$	 203  .  �� *Fecha_Asistencia+  $ Estado��$	 110  .  �� *Estado+   RowDetailsTemplate �� .R��� $ 
Horizontal=�$��Center=�$��0,5,0,5q�.+��� $��btn_Eliminar��-   $��90��$��0,0,10,0q�$��Eliminar��  -   $��dcp_FechaFinal��$
��Left=�$��28��$	��146��$��309,0,0,379q�$��Bottom=�$��4��$
 Fecha Final ��$��14(�$��Center=�
��������� -   $��label1��$��Fecha Final��$��14(�$��Right=�$��0,-2,257,407q��� -   $��chk_hoy��$��28��$
��Left=�$��481,0,0,379q�$��Bottom=�$
 Pagos del Día de Hoy�� J� SnapsToDevicePixels . $��5�� J� RenderTransformOrigin$ -0.292,1&��� -   $��lbl_Hoy��$	��Hoy��$
��Left=�$��474,-2,0,407q�