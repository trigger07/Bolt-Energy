   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	    
BodyEnergy   BodyEnergy.BusquedaSocio   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Pcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   7my1-http://schemas.microsoft.com/wpf/2008/toolkit  5   	   -   5        $��BSocioW��5   @     � Title$  Búsqueda de Socios��5   	    � Topmost .  $	��520��64   $	��750��6A    � SizeToContent$ Height=�5   C    � WindowStyle$ ThreeDBorderWindow=�6Z    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Icon$: 4/BodyEnergy;component/Imagenes_Sistema/CLIMB (8).png��6.    � ShowInTaskbar . .��5
      ]� ��. .+�5   
   �� $	��Top=�6   $��10��6&   ���	#0A0000005      �� 5   
   $��20��6   $��Bottom=�6   ���	#360000005      �� 5   
   ���	#0A000000._�5      � .+�5      �� -   5        $��lbl_NombreCompleto��5   ~   $��Nombre o Apellidos��6   $��14(�65   $��28��6C   $
��Left=�6O   $��
12,0,0,433q�6j   $��Bottom=�6�   �� 5      -   5        $��txt_NombreCompleto��5   U   $��26��6   $
��Left=�6&   $��
12,0,0,407q�6A   $��Bottom=�6o   $	��176��6�   $�� ��6�    �� 	MaxLength$	 180��6�   $��Center=�6�   $��14(�6�   	 � ToolTip$	 Filtro de Nombre de Socio��6�   $��1��6  �� 5      -   5        $��lbl_TipoSocio��5   z   $��Tipo de Socio��6   $��14(�60   $��28��6>   $
��Left=�6J   $��197,0,0,433q�6e   $��Bottom=�6�   �� 5      -   5        $��cbo_TipoSocio��5   W   $��26��6   $
��Left=�6'   $��197,0,0,407q�6B   $��Bottom=�6l   $��94��6�   $��Center=�6�   
�������$��14(�6�   $��2��6�   $	 Filtro por Tipo de Socio��6�   �� 5      -   5        $��label3��5   t   $��Empresa��6   $��14(�6*   $��28��68   $
��Left=�6D   $��301,0,0,433q�6_   $��Bottom=�6�   �� 5      -   5        $��cbo_Empresa��5   <   $��26��6   $��301,0,0,407q�6'   $��Bottom=�6O   $��14(�6j   $	 Filtro por Empresa��6x   $��3��6�   
�������$��Center=�6�   $
��Left=�6�   $	��159��6�   �� 5      -   5        $��
btn_Buscar��5   �   $��50��6   
������    MetroCircleButtonStyle#���   6>   $
��Left=�6p   $	��Top=�6�   $��50��6�   $	 Buscar��6�   $��5��6�   $��
632,11,0,0q�6�   .��5      �� $
��Fill=�6   $��25��6+   $��25��67   $;��5/BodyEnergy;component/Imagenes_Sistema/search_red.png��6B   $	 Buscar��6�   
 � Cursor$

 Hand��6�   5      �� 5      -	   5        $��btn_Exportar��5   �   $��
680,11,0,0q�6   #���   6-   
������ $
��Left=�6w   $��50��6�   $	��Top=�6�   $��50��6�   $��6��6�   $

 Hand��6�   .��5      �� $
��Fill=�6   $��25��6+   $��25��67   $<��6/BodyEnergy;component/Imagenes_Sistema/excel-file2.png��6B   $	 Exportar a Excel��6�   $

 Hand��6�   5      &   System.Windows.Controls.DataGrid  5      -
   5        $��
gdv_Socios��5   c   $
��Left=�6   $��
12,69,0,10q�67   $	��722��6u      AutoGenerateColumns .     CanUserResizeColumns .    
IsReadOnly . $

 Hand��5   u   $��Center=�6�   $   HorizontalScrollBarVisibility$ Disabled=�5       $��1q�6E      ColumnHeaderHeight$ 25Q�6Y   
�������   	RowHeight$ 20Q�6�   $	��383��6�   ��5   K   ��    Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn   Header$ Número��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ 75 6=      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6Z   �� *Numero_Socio+  5#      $ Nombre Completo��6-   $	 190 6F    .  6d   �� *Nombre_Completo+  5$      $ 	Teléfono��6-   $ 82 6?    .  6\   �� *Telefono_Celular+  5%      $ Correo��6-   $	 160 6=    .  6[   �� *Correo+  5&      $ Fecha Vencimiento��6-   $	 145 6H    .  6f   �� *Fecha_Vencimiento+4  .System.Windows.Controls.DataGridCheckBoxColumn  5'      $ Activo��61   $ 65 6A    .  6^   �� *Estado_Socio+5(         RowDetailsTemplate 5*      �� 5+      .R�5,      ��  �� Orientation$ 
Horizontal=�6*   $��Center=�6C   $��0,5,0,5q�6`   .+�5-   "   �� $��btn_Asistencia��6)   -   5        $��90��5-   ?   $��0,0,10,0q�6J   $��
Asistencia��6\   6q   �� 5.   "   $��
btn_Editar��6)   -   5        $��90��5.   ;   $��0,0,10,0q�6F   $��Editar��6X   6i   �� 5/   "   $��btn_Pago��6)   -   5        $��90��5/   9   $��0,0,10,0q�6D   $
��Pago��6V   6e   50      51      53      +  %Microsoft.Windows.Controls.DatePicker  54      -   5        $��	dcp_Fecha��54   Q   $
��Left=�6!   $��470,0,0,407q�6<   $��Bottom=�6b   $	��127��6}   $��26��6�   $��Center=�6�   
�������$��14(�6�   $!	 Filtro Fecha de Vencimiento��6�   $��4��6�   �� 55      -   5        $��label1��55      $��Fecha Vencimiento��6   $��14(�65   $��28��6C   $
��Left=�6O   $��470,0,0,433q�6j   $��Bottom=�6�   56      57      58      59      