   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   Z VVIBlend.WPF.Editors, Version=5.0.0.0, Culture=neutral, PublicKeyToken=5f568d4f9cd901f1X?clr-namespace:VIBlend.WPF.Controls;assembly=VIBlend.WPF.EditorsVIBlend.WPF.Controls 5       
BodyEnergy$   BodyEnergy.BusquedaTransaccion   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Pcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   ZviblendEditors?clr-namespace:VIBlend.WPF.Controls;assembly=VIBlend.WPF.Editors     5      6my-http://schemas.microsoft.com/wpf/2008/toolkit  5   .   -   5        $��BTransaccionW��5   =     � Title$  Reporte de Pagos��6	   $	��520��6#   $	��830��61    � SizeToContent$ Height=�5   	    � WindowStyle$ ThreeDBorderWindow=�6     � 
ResizeMode$ NoResize=�6A    � WindowStartupLocation$ CenterScreen=�5   	    � Icon$: 4/BodyEnergy;component/Imagenes_Sistema/CLIMB (8).png��5	   	    � ShowInTaskbar .  � Topmost .  .��5
      ]� ��. .+�5   
   �� $	��Top=�6   $��9��6&   ���	#0A0000005      �� 5   
   $��45��6   $��Bottom=�6   ���	#36000000._�5      �� -   5        $��
pnl_Montos��5       �� Orientation$ 
Horizontal=�6+   $��20,0,0,0q�6D   .+�5      �� -   5        $��lbl_Efectivo��5   Y   $��
Efectivo: ��6   $��0,0,0,0q�6.   $��14(�6?   $��28��6M   $��Center=�6m   $��Center=�6�   '  !VIBlend.WPF.Controls.NumberEditor  5      -   5        	  Name$	 txt_Efectivo��5   C   $  VIBlend.WPF.Controls.InputBase
   CultureInfo$
 en-US��6.   $��23��6Z    �� TextWrapping$
 Wrap=�6f   $��6��6z   $	��149��6�   $
��0,11q�6�   �� 5      -   5        $��lbl_Tarjeta��5   Y   $��	Tarjeta: ��6   $��20,0,0,0q�6-   $��14(�6?   $��28��6M   $��Center=�6l   $��Center=�6�     5      -   5        $	 txt_Tarjeta��5   C   $
 en-US��6.   $��23��6Y   $
 Wrap=�6e   $��6��6y   $	��149��6�   $��0,10,0,9q�6�   �� 5      -   5        $��lbl_MontoTotal��5   ]   $��Monto Total: ��6   $��50,0,0,0q�61   $��14(�6C   $��28��6Q   $��Center=�6s   $��Center=�6�     5      -   5        $	 txt_MontoTotal��5   C   $
 en-US��6.   $��23��6\   $
 Wrap=�6h   $��6��6|   $	��149��6�   $��0,10,0,9q�6�   5      5      �� 5   
   ���	#0A000000._�5      �  � ColumnDefinitions 5      �� 5      $
��371* �6'   �� 5      $
��373* �6'   .+�5       �� -	   5        $��	lbl_Socio��5    {   $��Número de Socio��6   $��14(�62   $��28��6@   $
��Left=�6L   $��
14,0,0,410q�6g   $��Bottom=�6�   �� 5!      -
   5        $��	txt_socio��5!   U   $��28��6   $
��Left=�6&   $��
14,0,0,382q�6A   $��Bottom=�6f   $	��120��6�    �� 	MaxLength$ 15��6�   $��Center=�6�   $��Center=�6�   $��14(�6�   $��1��6   � ToolTip$  Filtro de Número de Socio��6  �� 5"      -   5        $��lbl_TipoPago��5"   y   $��Tipo de Pago��6   $��28��6/   $��14(�6;   $
��Left=�6I   $��148,0,0,410q�6d   $��Bottom=�6�   �� 5#      -   5        $��cbo_TipoPago��5#   W   $��28��6   $
��Left=�6'   $��148,0,0,382q�6B   $��Bottom=�6k   $	��136��6�   $��Center=�6�   
�������$��2��6�   $ Filtro de Tipo de Pago��6�   �� 5$      -   5        $��lbl_FechaInicio��5$   z   $��Fecha Inicial��6   $��14(�60   $��28��6>   $
��Left=�6J   $��295,0,0,410q�6e   $��Bottom=�6�   $��2��6�   +  %Microsoft.Windows.Controls.DatePicker  5%      -   5        $��dcp_FechaInicio��5%   P   $
��Left=�6    $��295,0,0,382q�6;   $��Bottom=�6g   $��28��6�   $	��143��6�   $��3��6�   $ Fecha Inicial��6�   
�������$��Center=�6�   $��14(�6�   $��2��6  �� 5&      -   5        $��
btn_Buscar��5&   �   $��50��6   
������    MetroCircleButtonStyle#���   6>   $
��Left=�6p   $	��Top=�6�   $��50��6�   $ Buscar��6�   $��5��6�   $��
301,11,0,0q�6�   $��1��6  .��5'      �� $
��Fill=�6   $��25��6+   $��25��67   $;��5/BodyEnergy;component/Imagenes_Sistema/search_red.png��6B   $ Buscar��6�    � Cursor$
 Hand��6�   5(      �� 5)      -   5        $��btn_Exportar��5)   �   $��
349,11,0,0q�6   #���   6-   
������ $
��Left=�6w   $��50��6�   $	��Top=�6�   $��50��6�   $��6��6�   $
 Hand��6�   $��1��6  .��5*      �� $
��Fill=�6   $��25��6+   $��25��67   $<��6/BodyEnergy;component/Imagenes_Sistema/excel-file2.png��6B   $ Exportar a Excel��6�   $
 Hand��6�   5+      &   System.Windows.Controls.DataGrid  5,      -   5        $��gdv_Transacciones��5,   b   $
��Left=�6   $��	12,0,0,10q�67   $��Bottom=�6{   $	��802��5-         AutoGenerateColumns .     CanUserResizeColumns .    
IsReadOnly . $
 Hand��6r   $��Center=�5.      $��1q�5/         ColumnHeaderHeight$ 25Q�60   
�������   	RowHeight$ 20Q�6_   $	��353��6n   $��2��6{   ��5,   J   ��    Columns 50      0  *System.Windows.Controls.DataGridTextColumn  51      ,  &System.Windows.Controls.DataGridColumn   Header$ Codigo��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ 10 6=      
Visibility$ Hidden=�6H      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6n   �� *Cod_Transaccion+  52      $ Socio��6-   $	 190 6<    .  6[   �� *Nombre_Completo+  53      $ Monto��6-   $ 95 6<    .  6Z   �� *Monto+ �� StringFormat$ {0:N}��  54      $ Fecha��6-   $	 135 6<    .  6[   �� *Fecha_Transaccion+  55      $ Tipo de Pago��6-   $	 105 6C    .  6b   �� *Descripcion_TipoPago+  56      $ Factura��6-   $	 110 6>    .  6]   �� *Cod_Transaccion+  57      $ Período��6-   $ 80 6>    .  6\   �� *	Periodo+  58      $ Estado��6-   $ 80 6=    .  6[   �� *Estado+   RowDetailsTemplate 5:      �� 5;      .R�5<      �� $ 
Horizontal=�6*   $��Center=�6C   $��0,5,0,5q�6a   .+�5=   "   �� $��btn_Eliminar��6)   -   5        $��90��5=   =   $��0,0,10,0q�6H   $��Anular��6Z   6k   5>      5?      5A        5B      -   5        $��dcp_FechaFinal��5B   g   $
��Left=�6    $��28��6;   $	��146��6G   $��
41,0,0,382q�6S   $��Bottom=�6}   $��4��6�   $ Fecha Final ��6�   $��14(�6�   $��Center=�6�   
�������$��1��6�   �� 5C      -   5        $��label1��5C   w   $��Fecha Final��6   $��14(�6.   $��28��6<   $
��Left=�6H   $��
41,0,0,410q�6c   $��Bottom=�6�   $��1��6�   �� 5D      -   5        $��chk_hoy��5D   X   $��28��6   $
��Left=�6(   $��207,0,0,382q�6C   $��Bottom=�6g   $ Pagos del Día de Hoy��6�    J� SnapsToDevicePixels . $��5��6�   $��1��6�   �� 5E      -   5        $��lbl_Hoy��5E   b   $	��Hoy��6   $��28��6&   $
��Left=�62   $��200,0,0,408q�6M   $��Bottom=�6q   $��1��6�   5F      5G      5H      5I      