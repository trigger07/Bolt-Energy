   M S B A M L   `   `   `  ���� T  PMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls   
BodyEnergy    BodyEnergy.ContactoEmpresa   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Pcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     -   $��ContactoEmpresaW��  � Title$  Contacto de Empresa��$	��340��$	��600�� � 
ResizeMode$ NoResize=� � ShowInTaskbar .  � Topmost .   � WindowStartupLocation$ CenterScreen=� � WindowStyle$ ThreeDBorderWindow=� � Icon$: 4/BodyEnergy;component/Imagenes_Sistema/CLIMB (8).png��.��]� ��. .+��� $	��Top=�$��20�����	#0A000000�� $��70��$��Bottom=����	#36000000._��  � ColumnDefinitions �� $
��278* ��� $
��298* �.+���  �� Orientation$ 
Horizontal=�$��Right=�$��2��.+��� -   $��btn_Actualizar��$��0,0,0,0q�$��50��   MetroCircleButtonStyle#���   $��Center=�$��Center=�$��50��$��10��.���� $
��Fill=�$��25��$��25��$9��3/BodyEnergy;component/Imagenes_Sistema/save_red.png��	 � ToolTip$	 Actualizar Datos��
 � Cursor$

 Hand���� -   $��btn_Guardar��$��0,0,0,0q�#���   $��50��$��Center=�$��Center=�$��50��$��11��.���� $
��Fill=�$��25��$��25��$9��3/BodyEnergy;component/Imagenes_Sistema/save_red.png��$	 Guardar Datos��$

 Hand���� -   $��btn_Limpiar��$��0,0,0,0q�#���   $��50��$��Center=�$��Center=�$��50��$��12��.���� $
��Fill=�$��25��$��25��$:��4/BodyEnergy;component/Imagenes_Sistema/trash_red.png��$	 Limpiar Controles��$

 Hand���� -   $��	btn_Salir��$��0,0,5,0q�#���   $��50��$��Center=�$��Center=�$��50��$��13��.���� $
��Fill=�$��25��$��25��$:��4/BodyEnergy;component/Imagenes_Sistema/equiz_red.png��$	 Cerrar Ventana��$

 Hand���� ���	#0A000000._��  � RowDefinitions �� $	��55* ��� $	��57* ��� $	��77* � �� $	��192 ��� $	��192 ��� $	��192 �.+��� -   $��
lbl_Nombre��$��Nombre��$��14(�$��28��$
��Left=�$	��Top=�$��30,1,0,0q��� -   $��
txt_Nombre��$��28��$
��Left=�$	��Top=�$	��146��$��	30,27,0,0q�$��1�� �� 	MaxLength$ 45��$	 Nombre��$��Center=�$��14(�
���  ���� -   $��lbl_Apellido1��$��Primer Apellido��$��14(�$��1��$��28��$
��Left=�$	��Top=�$��21,1,0,0q��� -	   $��txt_Apellido1��$��1��$��28��$
��Left=�$	��146��$��	21,27,0,0q�$��2��$ 45��$	 Primer Apellido��$��Center=�$��14(�
���  ��$	��Top=��� -
   $��lbl_Apellido2��$��Segundo Apellido��$��14(�$��2��$��28��$
��Left=�$	��Top=�$��14,1,0,0q��� -   $��txt_Apellido2��$��2��$��28��$
��Left=�$	��Top=�$	��146��$��	14,27,0,0q�$��3��$ 45��$	 Segundo Apellido��$��Center=�$��14(��� -   $��lbl_Telefono1��$��Teléfono 1��$��14(�$��28��$
��Left=�$	��Top=�$��30,6,0,0q�$��1���� -   $��txt_telefono1��$��28��$
��Left=�$	��Top=�$	��146��$��	30,32,0,0q�$��1��$��4��$ 15��$	 Primer Teléfono��$��Center=�$��14(�
���  ���� -   $��lbl_Telefono2��$��Teléfono 2��$��14(�$��1��$��28��$
��Left=�$	��Top=�$��21,6,0,0q�$��1���� -   $��txt_Telefono2��$��1��$��28��$
��Left=�$	��Top=�$	��146��$��	21,32,0,0q�$��1��$��5��$ 15��$	 Primer Teléfono��$��Center=�$��14(��� -   $��
lbl_Estado��$��Estado��$��14(�$��2��$��28��$
��Left=�$	��Top=�$��14,6,0,0q�$��1���� -   $��
chk_Activo��$��Activo��$��14(�$��2��$��24��$
��Left=�$	��Top=�$��	14,33,0,0q�$��1��$��6��$	 Activo��
���  ���� -   $��chk_Inactivo��$��Inactivo��$��14(�$��2��$��24��$
��Left=�$	��Top=�$��	84,33,0,0q�$��1��$��7��$	 Inactivo��
���  ���� -   $��
lbl_Correo��$��Correo Electrónico��$��14(�$��28��$
��Left=�$	��Top=�$��30,4,0,0q�$��2���� -   $��
txt_Correo��$��28��$
��Left=�$	��Top=�$	��238��$��2��$��	30,30,0,0q�$��2��$��8��$ 45��$	 Correo Electrónico��$��Center=�$��14(��� -   $��lbl_Empresa��$��Empresa��$��28��$��14(�$
��Left=�$	��Top=�$��1��$��86,4,0,0q�$��2��$��71���� -   $��cbo_Empresa��$��28��$
��Left=�$	��Top=�$	��266��$��2��$��1��$��	86,30,0,0q�$��2��$��9��$	 Empresa��$��Center=�$��14(�
���  ��
�������