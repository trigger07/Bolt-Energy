   M S B A M L   `   `   `  ����U  QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35[<clr-namespace:Microsoft.Windows.Controls;assembly=WPFToolkitMicrosoft.Windows.Controls  5      T PMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   
    
BodyEnergy#   BodyEnergy.BusquedaAsistencia   5      Cmy<clr-namespace:Microsoft.Windows.Controls;assembly=WPFToolkit  \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Pcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   
   -   5        $��BAsistenciaW��5   6     � Title$  
Asistencia��6	   $	��520��6   $	��650��6*    � SizeToContent$ Height=�5   	    � WindowStyle$ ThreeDBorderWindow=�6     � 
ResizeMode$ NoResize=�6A    � Icon$: 4/BodyEnergy;component/Imagenes_Sistema/CLIMB (8).png��5   	    � ShowInTaskbar .  � Topmost .   � WindowStartupLocation$ CenterScreen=�5   	   .��5	      ]� ��. .+�5
   
   �� $	��Top=�6   $��16��6&   ���	#0A0000005      �� 5   
   $��43��6   $��Bottom=�6   ���	#36000000._�5      �� -   5        $��
pnl_Montos��5       �� Orientation$ 
Horizontal=�6+   $��20,0,0,0q�6D   .+�5      �� -   5        $��lbl_Asistencia��5   g   $��Cantidad de Asistencia: ��6   $��0,0,0,0q�6<   $��14(�6M   $��28��6[   $��Center=�6}   $��Center=�6�   �� 5      -   5        $��txt_Asistencia��5   &   $��23��6   $	��120��6<   5      5      �� 5   
   ���	#0A000000._�5      � .+�5      �� -   5        $��	lbl_Socio��5   p   $��Número de Socio��6   $��14(�62   $
��Left=�6@   $��14,-2,0,407q�6[   6p   �� 5      -   5        $��	txt_socio��5   U   $��28��6   $
��Left=�6&   $��
14,0,0,379q�6A   $��Bottom=�6f   $	��120��6�   	 �� 	MaxLength$	 15��6�   $��Center=�6�   $��Center=�6�   $��14(�6�   $��1��6�   
 � ToolTip$ 
 Filtro de Número de Socio��6�   6!  �� 5      -   5        $��lbl_FechaInicio��5   o   $��Fecha Inicial��6   $��14(�60   $
��Left=�6>   $��150,-2,0,407q�6Y   6o   +   %Microsoft.Windows.Controls.DatePicker  5      -   5        $��dcp_FechaInicio��5   P   $
��Left=�6    $��150,0,0,379q�6;   $��Bottom=�6g   $��28��6�   $	��143��6�   $��3��6�   $
 Fecha Inicial��6�   
�������$��Center=�6�   $��14(�6�   �� 5      -	   5        $��
btn_Buscar��5   �   $��50��6      MetroCircleButtonStyle#���   6&   $
��Left=�6W   $��528,0,0,375q�6r   $��Bottom=�6�   $��50��6�   $��6��6�   .��5      �� $
��Fill=�6   $��25��6+   $��25��67   $;��5/BodyEnergy;component/Imagenes_Sistema/search_red.png��6B   $
 Buscar��6�    � Cursor$
 Hand��6�   5      �� 5      -
   5        $��btn_Exportar��5   �   $��575,0,0,375q�6   #���   6.   $
��Left=�6_   $��Bottom=�6z   $��50��6�   $��50��6�   $��7��6�   $
 Hand��6�   .��5      �� $
��Fill=�6   $��25��6+   $��25��67   $<��6/BodyEnergy;component/Imagenes_Sistema/excel-file2.png��6B   $
 Exportar a Excel��6�   $
 Hand��6�   5      &   System.Windows.Controls.DataGrid  5      -   5        $��gdv_Asistencia��5   G   $��
12,0,10,10q�6      AutoGenerateColumns .     CanUserResizeColumns .    
IsReadOnly . $
 Hand��5   E   $��Center=�6S   $   HorizontalScrollBarVisibility$ Disabled=�6w   $��1q�5          ColumnHeaderHeight$ 25Q�61   
�������   	RowHeight$ 20Q�6`   $	��351��6o   $��Bottom=�6|   ��5   /   ��    Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn   Header$ Codigo��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ 20 6=      
Visibility$ Hidden=�6H      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6n   �� *Codigo+  5#      $ Código��6-   $ 75 6=    .  6[   �� *Numero_Socio+  5$      $ Socio��6-   $	 230 6<    .  6[   �� *Socio+  5%      $ Fecha de Asistencia��6-   $	 203 6J    .  6i   �� *Fecha_Asistencia+  5&      $ Estado��6-   $	 110 6=    .  6\   �� *Estado+   RowDetailsTemplate 5(      �� 5)      .R�5*      �� $ 
Horizontal=�6*   $��Center=�6C   $��0,5,0,5q�6a   .+�5+   "   �� $��btn_Eliminar��6)   -   5        $��90��5+   =   $��0,0,10,0q�6H   $��Eliminar��6Z   6m   5,      5-      5/        50      -   5        $��dcp_FechaFinal��50   h   $
��Left=�6    $��28��6;   $	��146��6G   $��309,0,0,379q�6S   $��Bottom=�6~   $��4��6�   $
 Fecha Final ��6�   $��14(�6�   $��Center=�6�   
�������6�   �� 51      -   5        $��label1��51   n   $��Fecha Final��6   $��14(�6.   $��Right=�6<   $��0,-2,257,407q�6X   6n   �� 52      -   5        $��chk_hoy��52   X   $��28��6   $
��Left=�6(   $��481,0,0,379q�6C   $��Bottom=�6g   $
 Pagos del Día de Hoy��6�    J� SnapsToDevicePixels . $��5��6�    J� RenderTransformOrigin$ -0.292,1&�6�   �� 53      -   5        $��lbl_Hoy��53   W   $	��Hoy��6   $
��Left=�6&   $��474,-2,0,407q�6A   6W   54      55      56      57      