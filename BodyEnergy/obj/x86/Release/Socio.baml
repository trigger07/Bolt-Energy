   M S B A M L   `   `   `  ���� T  PMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls   
BodyEnergy   BodyEnergy.Socio   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Pcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     6my-http://schemas.microsoft.com/wpf/2008/toolkit  -   $��SocioW��  � Title$  Socio��$	��500��$	��800�� � WindowStyle$ ThreeDBorderWindow=� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=� � ShowInTaskbar .  � Icon$: 4/BodyEnergy;component/Imagenes_Sistema/CLIMB (8).png�� � Topmost .  .��]� ��. .+��� $	��Top=�$��20�����	#0A000000�� $��70��$��Bottom=����	#36000000._��  � ColumnDefinitions �� $
��497* ��� $
��297* �.+��� -   $��
btn_Olvido��$$��¿Olvidó el número de Socio?�����	#FFB80000
������ $��30��$	��200��$��Center=�$��Center=� � ToolTip$ Recordar Número de Socio��$
��Bold"�$��13(�$��0q�	 � Cursor$
	 Hand��$��16��$��149,20,148,20q����� �� 
 �� Orientation$
 
Horizontal=�$��Right=�$��1��.+��� -   $��btn_Actualizar��
������    MetroCircleButtonStyle#���   $��Center=�$��Center=�$��50��$��17��$��50��$��0,5,0,0q�.���� $
��Fill=�$��25��$��25��$9��3/BodyEnergy;component/Imagenes_Sistema/save_Red.png��$ Actualizar Datos��$
	 Hand���� -   $��btn_Guardar��$��0,5,0,0q�
������ #���   $��Center=�$��Center=�$��50��$��50��$��18��.���� $
��Fill=�$��25��$��25��$9��3/BodyEnergy;component/Imagenes_Sistema/save_Red.png��$ Guardar Datos��$
	 Hand���� -    ��Name$ 
btn_Buscar��$��0,5,0,0q�$��50��#���   
������ $��Center=�$��Center=�$��50��$��19��.���� $
��Fill=�$��25��$��25��$;��5/BodyEnergy;component/Imagenes_Sistema/search_red.png��$ Buscar��$
	 Hand���� -   $ btn_Limpiar��$��0,5,0,0q�$��50��#���   
������ $��Center=�$��Center=�$��50��$��20��.���� $
��Fill=�$��25��$��25��$:��4/BodyEnergy;component/Imagenes_Sistema/trash_Red.png��$ Limpiar Controles��$
	 Hand���� -   $��	btn_Salir��$��50��$��0,5,5,0q�#���   
������ $��50��$��Center=�$��Center=�$��21��.���� $
��Fill=�$��25��$��25��$:��4/BodyEnergy;component/Imagenes_Sistema/equiz_Red.png��$ Cerrar Ventana��$
	 Hand���� ���	#0A000000$��Right=�$	��225��._��� $��Center=�.+��� -   $��	img_Socio��$	��222��$��Center=�$
��Fill=�$	��Top=�$	��201��$ Imágen de Socio���� -	   $��lbl_CodSocio��$��Número de Socio��$��28��$��Center=��� -
   $��txt_CodSocio��$��90��$��Center=�$��40(�$
��Bold"�$��Center=�$��Center=�$��Center=�$	��199�� �� 	MaxLength$ 12��$��15��$ Número de Socio���� ���	#0A000000._��  �� $
��191* ��� $
��177* ��� $
��201* � � RowDefinitions �� $��36 ��� $��36 ��� $
��Auto ��� $��36 ��� $
��Auto ��� $��36 ��� $
��Auto ��� $
��Auto ��� $��36 ��� $
��Auto �$��38���� .+��� -   $��
lbl_Nombre��$��Nombre��$��28��$��14(�$
��Left=�$��Bottom=�$	��Top=�$��70��$��11,8,0,0q��� -   $��lbl_Apellido1��$��Primer Apellido��$��14(�$��28��$
��Left=�$	��Top=�$��8,8,0,0q�$��1��$	��105���� -   $��lbl_Apellido2��$��Segundo Apellido��$��14(�$��28��$
��Left=�$	��Top=�$��2��$��6,8,0,0q�$	��120���� -   $��
txt_Nombre��$��32��$
��Left=�$	��Top=�$	��163��$��13,1,0,0q�$��1��$��14(�$��Center=�$ 45��$ Ingrese el Nombre��$��1��
���  ���� -   $��txt_Apellido1��$��32��$
��Left=�$	��Top=�$	��163��$��8,0,0,0q�$��1��$ 45��$��Center=�
���  ��$��14(�$��2��$  Ingrese el Primer Apellido��$��1���� -   $��txt_Apellido2��$��32��$
��Left=�$	��Top=�$	��163��$��2��$��6,0,0,0q�$��1��$ 45��$! Ingrese el Segundo Apellido��$��Center=�$��14(�$��3���� -   $��lbl_TelCelular��$��Teléfono Celular��$��14(�$��28��$
��Left=�$	��Top=�$��13,0,0,0q�$��2��$	��111���� -   $��lbl_TelResidencia��$��Teléfono Residencia��$��14(�$��28��$
��Left=�$	��Top=�$��2��$��1��$��8,0,0,0q�$	��133���� -   $��txt_TelCelular��$��32��$
��Left=�$	��Top=�$	��165��$��11,0,0,0q�$��3��$ 15��$- 'Ingrese el Número de Teléfono Celular��$��4��$��Center=�$��14(��� -   $��txt_TelResidencia��$��32��$
��Left=�$	��Top=�$	��163��$��3��$��14(�$��5��$��Center=�$3 -Ingrese el Número de Teléfono de Residencia��$ 15��$��1��$��8,0,0,0q��� -   $��lbl_FecNacimiento��$��Fecha Nacimiento��$��14(�$��28��$
��Left=�$	��Top=�$��13,4,0,0q�$��4��$	��121���� -   $��	lbl_Email��$��Correo Electrónico��$��14(�$��28��$
��Left=�$	��Top=�$��8,4,0,0q�$��4��$��1��$	��124��+  %Microsoft.Windows.Controls.DatePicker  -   $��dpc_fecNacimiento��$
��Left=�$	��Top=�$	��163��$��	13,31,0,0q�$��4��$��32��$��2��$ Fecha de Nacimiento��$��7��$��Center=�$��14(�
�������
���  ���� -   $��	txt_Email��$��32��$
��Left=�$	��Top=�$	��343��$��2��$��5��$ 45��$��8��$��Center=�$��14(�$��1��$��8,0,0,0q��� -   $��
lbl_Imagen��$��Imágen��$��14(�$��28��$
��Left=�$	��Top=�$��13,5,0,0q�$��7��$��56���� -   $��
txt_Imagen��$��32��$
��Left=�$	��Top=�$	��342�� �� 
IsReadOnly . $��2��$��13,1,0,0q�$��8��$��Center=�$ Ruta de la Imágen��$��14(�$��9���� -   $��
btn_Browse��$��Browse��$��32��$��14(�$
��Left=�$	��Top=�$��75��$��2��$��8��$��10��$
	 Hand��$ Buscar Imágen���� -   $��btn_EliminarImagen��
������ 
������ $��0q�$��2��$��60��$��60��$
��Left=�$	��Top=�$
	 Hand�� � ForceCursor . $��	66,20,0,0q�$��7��$��11��$��3��.���� $7��1/BodyEnergy;component/Imagenes_Sistema/borrar.png��$��2��$��Uniform=�$��8��$
��Left=�$ Eliminar Imágen���� -   $��lbl_TipoSocio��$��Tipo de Socio��$��14(�$��28��$
��Left=�$	��Top=�$��2��$��2��$��6,0,0,0q�$��94���� -   $��cbo_TipoSocio��$��29��$
��Left=�$	��Top=�$	��163��$��2��$��6,0,0,0q�$��3��$! Seleccione el Tipo de Socio��$��6��$��14(�$��Center=�
���  ��
��������� -   $��
lbl_Estado��$��Estado��$��14(�$��28��$
��Left=�$	��Top=�$��13,0,0,0q�$��9��$��51���� -    $��
chk_Activo��$��Activo��$��14(�$��28��$
��Left=�$	��Top=�$��25,1,0,0q�$��10��$��12��$ Activo��
���  ��$��63���� -!   $��chk_Inactivo��$��Inactivo��$��14(�$��28��$
��Left=�$	��Top=�$��96,1,0,0q�$��10��$��13��$ Inactivo��
���  ��$��72���� -"   $��lbl_Empresa��$��Empresa��$��14(�$��28��$	��Top=�$��	8,0,107,0q�$��9��$��1���� -#   $��cbo_Empresa��$��29��$
��Left=�$	��Top=�$	��343��$��2��$��10��$��Center=�
�������$��14(�$ Seleccione una Empresa��$��14��$��1��$��8,0,0,0q�