   M S B A M L   `   `   `  ���� T  PMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls   
BodyEnergy   BodyEnergy.Empresa   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Pcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     -   $��EmpresaW��  � Title$  Empresa��$	��360��$	��600�� � Icon$: 4/BodyEnergy;component/Imagenes_Sistema/CLIMB (8).png�� � 
ResizeMode$ NoResize=� � ShowInTaskbar .  � Topmost .   � WindowStartupLocation$ CenterScreen=� � WindowStyle$ ThreeDBorderWindow=�.��]� ��. .+��� $	��Top=�$��20�����	#0A000000�� $��70��$��Bottom=����	#36000000._��  � ColumnDefinitions �� $
��282* ��� $
��294* �.+���  �� Orientation$ 
Horizontal=�$��Right=�$��2��.+��� -   $��btn_Guardar��$��50��$��Center=�   MetroCircleButtonStyle#���   $��0,0,0,0q�$��Center=�$��50��$��8��.���� $
��Fill=�$��25��$��25��$9��3/BodyEnergy;component/Imagenes_Sistema/save_Red.png��	 � ToolTip$	 Guardar Datos��
 � Cursor$

 Hand���� -   $��btn_Actualizar��$��50��$��Center=�#���   $��0,0,0,0q�$��Center=�$��50��$��9��.���� $
��Fill=�$��25��$��25��$9��3/BodyEnergy;component/Imagenes_Sistema/save_red.png��$	 Actualizar Datos��$

 Hand���� -   $��btn_Limpiar��$��50��$��Center=�#���   $��0,0,0,0q�$��Center=�$��50��$��10��.���� $
��Fill=�$��25��$��25��$:��4/BodyEnergy;component/Imagenes_Sistema/trash_red.png��$	 Limpiar Controles��$

 Hand���� -   $��	btn_Salir��$��50��$��Center=�#���   $��0,0,5,0q�$��Center=�$��50��$��11��.���� $
��Fill=�$��25��$��25��$:��4/BodyEnergy;component/Imagenes_Sistema/equiz_red.png��$	 Cerrar Ventana��$

 Hand���� ���	#0A000000._�� $	��240�� � RowDefinitions �� $��37 ��� $��37 ��� $��37 ��� $��37 ��� $��37 ��� $��37 ��� $��7* � �� $	��94* ��� $��0* ��� $
��203* �.+��� -   $��lbl_NombreEmpresa��$��Empresa:��$��14(�$��28��$��Center=�$��Center=�$��	79,2,43,7q�$��66���� -   $��lbl_Descripcion��$��Descripción:��$��14(�$��28��$��Center=�$��Center=�$��1��$��	61,2,43,7q�$��84���� -   $��lbl_Telefonos��$��
Teléfono:��$��14(�$��28��$��Center=�$��Center=����	#FF1E1E4B$��2��$��	77,2,43,7q�$��68���� -	   $��lbl_Fax��$
��Fax:��$��14(�$��28��$��Center=�$��Center=�$��3��$��
113,2,43,7q�$��32���� -
   $��
lbl_Estado��$��Estado:��$��14(�$��28��$��Center=�$��Center=�$��4��$��	91,3,43,6q�$��54���� -   $��
lbl_Correo��$��Correo:��$��14(�$��28��$��Center=�$��Center=����	#FF1E1E4B$��5��$��	89,2,43,7q�$��56���� -   $��
txt_Nombre��$��30��$
��Left=�$	��Top=�$	��327��$��2��
���  ��$��1��$��14(�$��Center=�$	 Nombre de la Empresa�� �� 	MaxLength$ 90���� -   $��txt_Descripcion��$��30��$
��Left=�$	��Top=�$	��327��$��2��$��1��$��2��$��14(�$��Center=�$ 	 Descripción de la Empresa��$ 90���� -   $��txt_Telefono1��$��30��$
��Left=�$	��Top=�$	��327��$��2��$��2��
���  ��$��3��$��14(�$	 	Teléfono��$ 15���� -   $��
txt_Correo��$��30��$
��Left=�$	��Top=�$	��327��$��2��$��5��$��7��$��14(�$��Center=�$	 Correo��$ 45���� -   $��txt_Fax��$��30��$
��Left=�$	��Top=�$	��327��$��2��$��3��$��4��$��14(�$��Center=�$		 Fax��$ 15���� -   $��
chk_Activo��$��Activo��$��14(�$��20��$
��Left=�$��Center=�$��2��$��4��
���  ��$��5��$	 Activo��$��0,8,0,9q�$��63���� -   $��chk_Inactivo��$��Inactivo��$��14(�$��20��$
��Left=�$	��Top=�$��2��$��4��$��78,8,0,0q�
���  ��$��6��$	 Inactivo��$��72��