   M S B A M L   `   `   `  ���� T  PMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls   
BodyEnergy    BodyEnergy.BusquedaEmpresa   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Pcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     6my-http://schemas.microsoft.com/wpf/2008/toolkit  -   $��	BEmpresaW��  � Title$  Busqueda de Empresas��$	��500��$	��178�� � SizeToContent$ Height=�$	��550�� � Icon$: 4/BodyEnergy;component/Imagenes_Sistema/CLIMB (8).png�� � 
ResizeMode$ NoResize=� � ShowInTaskbar .  � Topmost .   � WindowStartupLocation$ CenterScreen=� � WindowStyle$ ThreeDBorderWindow=�.��]� ��. .+��� $	��Top=�$��15�����	#0A000000�� $��20��$��Bottom=����	#36000000�� ���	#0A000000._�� .+��� -   $��lbl_Empresa��$��Empresa��$��14(�$��28��$
��Left=�$��12,-5,0,414q�$��Bottom=��� -   $��txt_Empresa��$��28��$
��Left=�$��
12,0,0,386q�$��Bottom=�$	��303�� �� 	MaxLength$	 150��$��Center=�$��14(�$��1��	 � ToolTip$!	 Filtro de Nombre de Empresa���� -   $��
btn_Buscar��$��50��
������    MetroCircleButtonStyle#���   $
��Left=�$	��Top=�$��50��$	 Buscar��$��5��$��	430,1,0,0q�.���� $
��Fill=�$��25��$��25��$;��5/BodyEnergy;component/Imagenes_Sistema/search_red.png��$	 Buscar��
 � Cursor$

 Hand���� -   $��btn_Exportar��$��	480,1,0,0q�#���   
������ $
��Left=�$��50��$	��Top=�$��50��$��6��$

 Hand��.���� $
��Fill=�$��25��$��25��$<��6/BodyEnergy;component/Imagenes_Sistema/excel-file2.png��$	 Exportar a Excel��$

 Hand��&   System.Windows.Controls.DataGrid  -   $��gdv_Empresas��$
��Left=�$��
12,66,0,10q�   
IsReadOnly . $	��522��$

 Hand��   AutoGenerateColumns .  $��1q�   ColumnHeaderHeight$ 25Q�
�������   	RowHeight$ 20Q�����    Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Codigo_Empresa��   
Visibility$ Hidden=�   Width5  /System.Windows.Controls.DataGridLengthConverter$ 10    
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Codigo+  $ Empresa��$	 165  .  �� *Nombre_Empresa+  $ Teléfono 1��$ 80  .  �� *
Telefono_1+  $ Teléfono 2��$ 80  .  �� *
Telefono_2+  $ Correo��$	 127  .  �� *Correo+4  .System.Windows.Controls.DataGridCheckBoxColumn  $ Activo��$ 65  .  �� *Estado+