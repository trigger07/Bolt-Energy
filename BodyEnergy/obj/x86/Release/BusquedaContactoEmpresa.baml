   M S B A M L   `   `   `  ���� T  PMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls   
BodyEnergy(   "BodyEnergy.BusquedaContactoEmpresa   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Pcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     6my-http://schemas.microsoft.com/wpf/2008/toolkit  -   $��
BContactoW��  � Title$  Contactos de Empresa�� � Topmost .  $	��520��$	��729�� � SizeToContent$ Height=� � WindowStyle$ ThreeDBorderWindow=� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � Icon$: 4/BodyEnergy;component/Imagenes_Sistema/CLIMB (8).png�� � ShowInTaskbar . .��]� ��. .+��� $	��Top=�$��10�����	#0A000000�� $��20��$��Bottom=����	#36000000�� ���	#0A000000._��  � ColumnDefinitions �� $
��362* ��� $
��343* �.+��� -   $��
lbl_Nombre��$��Nombre o Apellidos��$��14(�$��28��$
��Left=�$��
23,0,0,434q�$��Bottom=��� -   $��
btn_Buscar��$��50��$
��Left=�   MetroCircleButtonStyle#���   $��	237,7,0,0q�$	��Top=�$��50��	 � Cursor$
	 Hand��$��3��
 � ToolTip$
 Buscar��$��1��.���� $
��Fill=�$��25��$��25��$;��5/BodyEnergy;component/Imagenes_Sistema/search_Red.png��$
 Buscar��$
	 Hand���� -   $��lbl_Empresa��$��Empresa��$��28��$��14(�$
��Left=�$��318,0,0,434q�$��Bottom=�$��2���� -   $��
txt_Nombre��$��28��$
��Left=�$��
23,0,0,406q�$��Bottom=�$	��252��$"
 Filtro de Nombre o Apellidos��$��1��$��14(�$��Center=�$�� �� �� 	MaxLength$	 175���� -   $��cbo_Empresa��$��28��$��Right=�$��0,0,168,406q�$��Bottom=�$	��237��$��Center=�$��14(�
�������$��2��$
 Filtro de  Empresa��$��2��&   System.Windows.Controls.DataGrid  -   $��gdv_Contactos��$
��Left=�$��
10,73,0,10q�$	��703��$
	 Hand��$��Center=�   AutoGenerateColumns .     CanUserResizeColumns .    
IsReadOnly . $��2��$��1q�   ColumnHeaderHeight$ 25Q�
�������   	RowHeight$ 20Q�����    Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Codigo��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 10    
Visibility$ Hidden=�   
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Codigo+  $ Nombre Completo��$	 172  .  �� *Nombre_Completo+  $ 	Teléfono��$ 80  .  �� *
Telefono_1+  $	 Fax��$ 75  .  �� *
Telefono_2+  $ Correo��$	 144  .  �� *Correo+  $ Empresa��$	 160  .  �� *Nombre_Empresa+4  .System.Windows.Controls.DataGridCheckBoxColumn  $ Activo��$ 67  .  �� *Estado+�� -   $��btn_Exportar��$��50��$
��Left=�$��	283,7,0,0q�#���   $	��Top=�$��50��$
 Exportar a Excel��$��4��$
	 Hand��$��1��.���� $
��Fill=�$��25��$��25��$<��6/BodyEnergy;component/Imagenes_Sistema/excel-file2.png��$
 Exportar a Excel��$
	 Hand��