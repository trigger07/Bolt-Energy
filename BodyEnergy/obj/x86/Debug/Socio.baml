   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	    
BodyEnergy   BodyEnergy.Socio   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Pcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   6my-http://schemas.microsoft.com/wpf/2008/toolkit  5   0   -   5        $��SocioW��5   @     � Title$  Socio��5   	   $	��500��6   $	��800��6$    � WindowStyle$ ThreeDBorderWindow=�5   	    � WindowStartupLocation$ CenterScreen=�6*    � 
ResizeMode$ NoResize=�6P    � ShowInTaskbar .  � Icon$: 4/BodyEnergy;component/Imagenes_Sistema/CLIMB (8).png��5   	    � Topmost .  .��5      ]� ��. .+�5	   
   �� $	��Top=�6   $��20��6&   ���	#0A0000005      �� 5   
   $��70��6   $��Bottom=�6   ���	#36000000._�5      �  � ColumnDefinitions 5      �� 5      $
��497* �6'   �� 5      $
��297* �6'   .+�5      �� -   5        $��
btn_Olvido��5   7   $$��¿Olvidó el número de Socio?��5      ���	#FFB80000
������ $��30��6o   $	��200��6{   $��Center=�5      $��Center=�6I    � ToolTip$ Recordar Número de Socio��5      $
��Bold"�6<   $��13(�6N   $��0q�6\   	 � Cursor$
	 Hand��5      $��16��6(   $��149,20,148,20q�66   ��5      �� 5      5      �� 5      
 �� Orientation$
 
Horizontal=�6   $��Right=�66   $��1��6S   .+�5      �� -   5        $��btn_Actualizar��5   �   
������    MetroCircleButtonStyle#���   67   $��Center=�6h   $��Center=�6�   $��50��6�   $��17��6�   $��50��6�   $��0,5,0,0q�6�   .��5      �� $
��Fill=�6    $��25��6/   $��25��6;   $9��3/BodyEnergy;component/Imagenes_Sistema/save_Red.png��6F   $ Actualizar Datos��6�   $
	 Hand��6�   5      �� 5      -   5        $��btn_Guardar��5   �   $��0,5,0,0q�6   
������ #���   6G   $��Center=�6x   $��Center=�6�   $��50��6�   $��50��6�   $��18��6�   .��5      �� $
��Fill=�6    $��25��6/   $��25��6;   $9��3/BodyEnergy;component/Imagenes_Sistema/save_Red.png��6F   $ Guardar Datos��6�   $
	 Hand��6�   5       �� 5!      -   5         ��Name$ 
btn_Buscar��5!   �   $��0,5,0,0q�6   $��50��6.   #���   6:   
������ $��Center=�6�   $��Center=�6�   $��50��6�   $��19��6�   .��5"      �� $
��Fill=�6    $��25��6/   $��25��6;   $;��5/BodyEnergy;component/Imagenes_Sistema/search_red.png��6F   $ Buscar��6�   $
	 Hand��6�   5#      �� 5$      -   5        $ btn_Limpiar��5$   �   $��0,5,0,0q�6   $��50��6.   #���   6:   
������ $��Center=�6�   $��Center=�6�   $��50��6�   $��20��6�   .��5%      �� $
��Fill=�6    $��25��6/   $��25��6;   $:��4/BodyEnergy;component/Imagenes_Sistema/trash_Red.png��6F   $ Limpiar Controles��6�   $
	 Hand��6�   5&      �� 5'      -   5        $��	btn_Salir��5'   �   $��50��6   $��0,5,5,0q�6)   #���   6:   
������ $��50��6�   $��Center=�6�   $��Center=�6�   $��21��6�   .��5(      �� $
��Fill=�6    $��25��6/   $��25��6;   $:��4/BodyEnergy;component/Imagenes_Sistema/equiz_Red.png��6F   $ Cerrar Ventana��6�   $
	 Hand��6�   5)      5+      5,      5-      �� 5.   
   ���	#0A000000$��Right=�6(   $	��225��6?   ._�5/      �� $��Center=�6   .+�50      �� -   5        $��	img_Socio��50   B   $	��222��6   $��Center=�6%   $
��Fill=�6S   $	��Top=�6b   $	��201��6z   $ Imágen de Socio��6�   �� 51      -	   5        $��lbl_CodSocio��51   [   $��Número de Socio��6   $��28��62   $��Center=�6>   6[   �� 52      -
   5        $��txt_CodSocio��53   <   $��90��52      $��Center=�6&   $��40(�6D   $
��Bold"�6R   $��Center=�6d   $��Center=�53      $��Center=�6P   $	��199��6k    �� 	MaxLength$ 12��6�   $��15��6�   $ Número de Socio��6�   54      55      �� 56   
   ���	#0A000000._�57      �  58      �� 59      $
��191* �6'   �� 5:      $
��177* �6'   �� 5;      $
��201* �6'    � RowDefinitions 5=      �� 5>      $��36 �6$   �� 5?      $��36 �6$   �� 5@      $
��Auto �6$   �� 5A      $��36 �6$   �� 5B      $
��Auto �6$   �� 5C      $��36 �6$   �� 5D      $
��Auto �6$   �� 5E      $
��Auto �6$   �� 5F      $��36 �6$   �� 5G      $
��Auto �6$   $��38��62   �� 5H      .+�5J      �� -   5        $��
lbl_Nombre��5J   ^   $��Nombre��6   $��28��6)   $��14(�65   $
��Left=�6C   $��Bottom=�6q   $	��Top=�6�   $��70��6�   $��11,8,0,0q�6�   �� 5K      -   5        $��lbl_Apellido1��5K   g   $��Primer Apellido��6   $��14(�62   $��28��6@   $
��Left=�6L   $	��Top=�6|   $��8,8,0,0q�6�   $��1��6�   $	��105��6�   �� 5L      -   5        $��lbl_Apellido2��5L   h   $��Segundo Apellido��6   $��14(�63   $��28��6A   $
��Left=�6M   $	��Top=�6}   $��2��6�   $��6,8,0,0q�6�   $	��120��6�   �� 5M      -   5        $��
txt_Nombre��5M   B   $��32��6   $
��Left=�6&   $	��Top=�6T   $	��163��6l   $��13,1,0,0q�6x   $��1��6�   $��14(�6�   $��Center=�6�   $ 45��6�   $ Ingrese el Nombre��6�   $��1��6�   
���  ��6�   �� 5N      -   5        $��txt_Apellido1��5N   A   $��32��6   $
��Left=�6&   $	��Top=�6V   $	��163��6n   $��8,0,0,0q�6z   $��1��6�   $ 45��6�   $��Center=�6�   
���  ��$��14(�6�   $��2��6�   $  Ingrese el Primer Apellido��6�   $��1��6  �� 5O      -   5        $��txt_Apellido2��5O   A   $��32��6   $
��Left=�6&   $	��Top=�6V   $	��163��6n   $��2��6z   $��6,0,0,0q�6�   $��1��6�   $ 45��6�   $! Ingrese el Segundo Apellido��6�   $��Center=�6�   $��14(�6�   $��3��6  �� 5P      -   5        $��lbl_TelCelular��5P   h   $��Teléfono Celular��6   $��14(�63   $��28��6A   $
��Left=�6M   $	��Top=�6~   $��13,0,0,0q�6�   $��2��6�   $	��111��6�   �� 5Q      -   5        $��lbl_TelResidencia��5Q   l   $��Teléfono Residencia��6   $��14(�66   $��28��6E   $
��Left=�6Q   $	��Top=�6�   $��2��6�   $��1��6�   $��8,0,0,0q�6�   $	��133��6�   �� 5R      -   5        $��txt_TelCelular��5R   A   $��32��6   $
��Left=�6&   $	��Top=�6W   $	��165��6o   $��11,0,0,0q�6{   $��3��6�   $ 15��6�   $- 'Ingrese el Número de Teléfono Celular��6�   $��4��6�   $��Center=�6�   $��14(�6  �� 5S      -   5        $��txt_TelResidencia��5S   B   $��32��6   $
��Left=�6&   $	��Top=�6[   $	��163��6s   $��3��6   $��14(�6�   $��5��6�   $��Center=�6�   $3 -Ingrese el Número de Teléfono de Residencia��6�   $ 15��6�   $��1��6  $��8,0,0,0q�6  �� 5T      -   5        $��lbl_FecNacimiento��5T   i   $��Fecha Nacimiento��6   $��14(�63   $��28��6A   $
��Left=�6M   $	��Top=�6�   $��13,4,0,0q�6�   $��4��6�   $	��121��6�   �� 5U      -   5        $��	lbl_Email��5U   j   $��Correo Electrónico��6   $��14(�65   $��28��6C   $
��Left=�6O   $	��Top=�6{   $��8,4,0,0q�6�   $��4��6�   $��1��6�   $	��124��6�   +  %Microsoft.Windows.Controls.DatePicker  5V      -   5        $��dpc_fecNacimiento��5V   <   $
��Left=�6    $	��Top=�6U   $	��163��6m   $��	13,31,0,0q�6y   $��4��6�   $��32��6�   $��2��6�   $ Fecha de Nacimiento��6�   $��7��6�   $��Center=�6�   $��14(�6  
�������
���  ��6$  �� 5W      -   5        $��	txt_Email��5W   A   $��32��6   $
��Left=�6&   $	��Top=�6R   $	��343��6j   $��2��6v   $��5��6�   $ 45��6�   $��8��6�   $��Center=�6�   $��14(�6�   $��1��6�   $��8,0,0,0q�6�   �� 5X      -   5        $��
lbl_Imagen��5X   _   $��Imágen��6   $��14(�6)   $��28��67   $
��Left=�6C   $	��Top=�6q   $��13,5,0,0q�6�   $��7��6�   $��56��6�   �� 5Y      -   5        $��
txt_Imagen��5Y   B   $��32��6   $
��Left=�6&   $	��Top=�6T   $	��342��6l    �� 
IsReadOnly . $��2��6�   $��13,1,0,0q�6�   $��8��6�   $��Center=�6�   $ Ruta de la Imágen��6�   $��14(�6�   $��9��6
  �� 5Z      -   5        $��
btn_Browse��5Z   `   $��Browse��6   $��32��6+   $��14(�67   $
��Left=�6E   $	��Top=�6r   $��75��6�   $��2��6�   $��8��6�   $��10��6�   $
	 Hand��6�   $ Buscar Imágen��6�   �� 5[      -   5        $��btn_EliminarImagen��5[   �   
������ 
������ $��0q�6N   $��2��6b   $��60��6r   $��60��6~   $
��Left=�6�   $	��Top=�6�   $
	 Hand��6�    � ForceCursor . $��	66,20,0,0q�6  $��7��6,  $��11��69  $��3��6G  .��5\      �� $7��1/BodyEnergy;component/Imagenes_Sistema/borrar.png��6   $��2��6W   $��Uniform=�6g   $��8��6z   $
��Left=�6�   $ Eliminar Imágen��6�   6�   5]      �� 5^      -   5        $��lbl_TipoSocio��5^   f   $��Tipo de Socio��6   $��14(�60   $��28��6>   $
��Left=�6J   $	��Top=�6{   $��2��6�   $��2��6�   $��6,0,0,0q�6�   $��94��6�   �� 5_      -   5        $��cbo_TipoSocio��5_   B   $��29��6   $
��Left=�6'   $	��Top=�6W   $	��163��6o   $��2��6�   $��6,0,0,0q�6�   $��3��6�   $! Seleccione el Tipo de Socio��6�   $��6��6  $��14(�6  $��Center=�6  
���  ��
�������6T  �� 5`      -   5        $��
lbl_Estado��5`   _   $��Estado��6   $��14(�6)   $��28��67   $
��Left=�6C   $	��Top=�6q   $��13,0,0,0q�6�   $��9��6�   $��51��6�   �� 5a      -    5        $��
chk_Activo��5a   c   $��Activo��6   $��14(�6-   $��28��6;   $
��Left=�6G   $	��Top=�6u   $��25,1,0,0q�6�   $��10��6�   $��12��6�   $ Activo��6�   
���  ��$��63��6�   �� 5b      -!   5        $��chk_Inactivo��5b   c   $��Inactivo��6   $��14(�6.   $��28��6<   $
��Left=�6H   $	��Top=�6w   $��96,1,0,0q�6�   $��10��6�   $��13��6�   $ Inactivo��6�   
���  ��$��72��6  �� 5c      -"   5        $��lbl_Empresa��5c   E   $��Empresa��6   $��14(�6*   $��28��68   $	��Top=�6X   $��	8,0,107,0q�6p   $��9��6�   $��1��6�   �� 5d      -#   5        $��cbo_Empresa��5d   C   $��29��6   $
��Left=�6'   $	��Top=�6V   $	��343��6n   $��2��6z   $��10��6�   $��Center=�6�   
�������$��14(�6�   $ Seleccione una Empresa��6�   $��14��6   $��1��6  $��8,0,0,0q�6  5e      5f      5g      5h      