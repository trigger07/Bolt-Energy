   M S B A M L   `   `   `  ���� T  PMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls   
BodyEnergy(   "BodyEnergy.BusquedaSocioAsistencia   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Pcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     7my1-http://schemas.microsoft.com/wpf/2008/toolkit  -   $��BSocioAsistW��  � Title$  Búsqueda de Socios�� � Topmost .  $	��500��$	��478��$	��500��$	��729�� � SizeToContent$ Height=� � WindowStyle$ ThreeDBorderWindow=� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � Icon$: 4/BodyEnergy;component/Imagenes_Sistema/CLIMB (8).png�� � ShowInTaskbar . .��]� ��. .+��� $	��Top=�$��10�����	#0A000000�� $��20��$��Bottom=����	#36000000�� ���	#0A000000._�� .+��� -   $��lbl_NombreCompleto��$��Nombre o Apellidos��$��14(�$��28��$
��Left=�$��
27,0,0,414q�$��Bottom=�$	��228���� -   $��txt_NombreCompleto��$��64��$
��Left=�$��40(�$��
27,0,0,350q�$��Bottom=�$	��557��$�� �� �� 	MaxLength$	 180��$��Center=�	 � ToolTip$	 Filtro de Nombre de Socio��$��1���� -   $��
btn_Buscar��
������    MetroCircleButtonStyle#���   $	 Buscar��$��5��$��
612,21,0,0q�$��73��$	��Top=�$
��Left=�$��72��.���� $
��Fill=�$��30��$��30��$;��5/BodyEnergy;component/Imagenes_Sistema/search_red.png��$	 Buscar��
 � Cursor$

 Hand��&   System.Windows.Controls.DataGrid  -   $��
gdv_Socios��$
��Left=�$��16(�$��	10,0,0,10q�$��Bottom=�$	��703��   AutoGenerateColumns .     CanUserResizeColumns .    
IsReadOnly . $

 Hand��$��Center=�$   HorizontalScrollBarVisibility$ Disabled=�$��1q�   ColumnHeaderHeight$ 30Q�
�������   	RowHeight$ 20Q�$	��323������    Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Número��   Width5  /System.Windows.Controls.DataGridLengthConverter$	 100    
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Numero_Socio+  $ Nombre Completo��$	 280  .  �� *Nombre_Completo+  $ Fecha Vencimiento��$	 220  .  �� *Fecha_Vencimiento+4  .System.Windows.Controls.DataGridCheckBoxColumn  $ Activo��$ 97  .  �� *Estado_Socio+   RowDetailsTemplate �� .R���  �� Orientation$ 
Horizontal=�$��Center=�$��0,5,0,5q�.+��� $��btn_Asistencia��$��90��$��0,0,10,0q�$��
Asistencia���� $��
btn_Editar��$��90��$��0,0,10,0q�$��Editar���� $��btn_Pago��$��90��$��0,0,10,0q�$
��Pago��