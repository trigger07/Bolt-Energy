   M S B A M L   `   `   `  ���� T  PMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls   
BodyEnergy   BodyEnergy.BusquedaSocio   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Pcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     7my1-http://schemas.microsoft.com/wpf/2008/toolkit  -   $��BSocioW��  � Title$  Búsqueda de Socios�� � Topmost .  $	��520��$	��750�� � SizeToContent$ Height=� � WindowStyle$ ThreeDBorderWindow=� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � Icon$: 4/BodyEnergy;component/Imagenes_Sistema/CLIMB (8).png�� � ShowInTaskbar . .��]� ��. .+��� $	��Top=�$��10�����	#0A000000�� $��20��$��Bottom=����	#36000000�� ���	#0A000000._�� .+��� -   $��lbl_NombreCompleto��$��Nombre o Apellidos��$��14(�$��28��$
��Left=�$��
12,0,0,433q�$��Bottom=��� -   $��txt_NombreCompleto��$��26��$
��Left=�$��
12,0,0,407q�$��Bottom=�$	��176��$�� �� �� 	MaxLength$	 180��$��Center=�$��14(�	 � ToolTip$	 Filtro de Nombre de Socio��$��1���� -   $��lbl_TipoSocio��$��Tipo de Socio��$��14(�$��28��$
��Left=�$��197,0,0,433q�$��Bottom=��� -   $��cbo_TipoSocio��$��26��$
��Left=�$��197,0,0,407q�$��Bottom=�$��94��$��Center=�
�������$��14(�$��2��$	 Filtro por Tipo de Socio���� -   $��label3��$��Empresa��$��14(�$��28��$
��Left=�$��301,0,0,433q�$��Bottom=��� -   $��cbo_Empresa��$��26��$��301,0,0,407q�$��Bottom=�$��14(�$	 Filtro por Empresa��$��3��
�������$��Center=�$
��Left=�$	��159���� -   $��
btn_Buscar��$��50��
������    MetroCircleButtonStyle#���   $
��Left=�$	��Top=�$��50��$	 Buscar��$��5��$��
632,11,0,0q�.���� $
��Fill=�$��25��$��25��$;��5/BodyEnergy;component/Imagenes_Sistema/search_red.png��$	 Buscar��
 � Cursor$

 Hand���� -	   $��btn_Exportar��$��
680,11,0,0q�#���   
������ $
��Left=�$��50��$	��Top=�$��50��$��6��$

 Hand��.���� $
��Fill=�$��25��$��25��$<��6/BodyEnergy;component/Imagenes_Sistema/excel-file2.png��$	 Exportar a Excel��$

 Hand��&   System.Windows.Controls.DataGrid  -
   $��
gdv_Socios��$
��Left=�$��
12,69,0,10q�$	��722��   AutoGenerateColumns .     CanUserResizeColumns .    
IsReadOnly . $

 Hand��$��Center=�$   HorizontalScrollBarVisibility$ Disabled=�$��1q�   ColumnHeaderHeight$ 25Q�
�������   	RowHeight$ 20Q�$	��383������    Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Número��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 75    
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Numero_Socio+  $ Nombre Completo��$	 190  .  �� *Nombre_Completo+  $ 	Teléfono��$ 82  .  �� *Telefono_Celular+  $ Correo��$	 160  .  �� *Correo+  $ Fecha Vencimiento��$	 145  .  �� *Fecha_Vencimiento+4  .System.Windows.Controls.DataGridCheckBoxColumn  $ Activo��$ 65  .  �� *Estado_Socio+   RowDetailsTemplate �� .R���  �� Orientation$ 
Horizontal=�$��Center=�$��0,5,0,5q�.+��� $��btn_Asistencia��-   $��90��$��0,0,10,0q�$��
Asistencia���� $��
btn_Editar��-   $��90��$��0,0,10,0q�$��Editar���� $��btn_Pago��-   $��90��$��0,0,10,0q�$
��Pago��+  %Microsoft.Windows.Controls.DatePicker  -   $��	dcp_Fecha��$
��Left=�$��470,0,0,407q�$��Bottom=�$	��127��$��26��$��Center=�
�������$��14(�$!	 Filtro Fecha de Vencimiento��$��4���� -   $��label1��$��Fecha Vencimiento��$��14(�$��28��$
��Left=�$��470,0,0,433q�$��Bottom=�