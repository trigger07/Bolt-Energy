   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   0   Z VVIBlend.WPF.Editors, Version=5.0.0.0, Culture=neutral, PublicKeyToken=5f568d4f9cd901f1X?clr-namespace:VIBlend.WPF.Controls;assembly=VIBlend.WPF.EditorsVIBlend.WPF.Controls 5       
BodyEnergy   BodyEnergy.Transaccion   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Pcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   0   7my2-http://schemas.microsoft.com/wpf/2008/toolkit  5   	   TviblendEditors?clr-namespace:VIBlend.WPF.Controls;assembly=VIBlend.WPF.Editors  5      -   5        $��TransaccionW��5   @     � Title$  Pagos��5   	   $	��425��6   $	��650��6$    � Icon$: 4/BodyEnergy;component/Imagenes_Sistema/CLIMB (8).png��5   C    � 
ResizeMode$ NoResize=�5   	    � ShowInTaskbar .  � Topmost .   � WindowStartupLocation$ CenterScreen=�6D    � WindowStyle$ ThreeDBorderWindow=�5   	   .��5	      ]� ��. .+�5
   
   �� $	��Top=�6   $��20��6&   ���	#0A0000005      �� 5   
   $��70��6   $��Bottom=�6   ���	#36000000._�5      �  � ColumnDefinitions 5      �� 5      $	��22* �6'   �� 5      $
��301* �6'   �� 5      $
��303* �6'   .+�5      �� -   5        $��
btn_Olvido��5   7   $$��¿Olvidó el número de Socio?��5      ���	#FFB80000
������ $��30��6o   $	��200��6{   $��Center=�5      $��Center=�6I    � ToolTip$ Recordar Número de Socio��5      $
��Bold"�6<   $��13(�6N   $��0q�6\   $��1��5      	 � Cursor$
	 Hand��6)   $��9��67   ��5      �� 5      5      �� 5      
 �� Orientation$
 
Horizontal=�6   $��Right=�66   $��2��6R   .+�5      �� -   5        $��btn_Guardar��5   �   $��50��6   
������    MetroCircleButtonStyle#���   6B   $��Center=�6s   $��0,0,0,0q�6�   $��Center=�6�   $��50��6�   $��10��6�   .��5      �� $
��Fill=�6    $��25��6/   $��25��6;   $9��3/BodyEnergy;component/Imagenes_Sistema/save_Red.png��6F   $ Guardar Datos��6�   $
	 Hand��6�   5      �� 5       -   5        $��btn_Actualizar��5    �   $��50��6   $��0,0,0,0q�6)   
������ #���   6S   $��Center=�6�   $��Center=�6�   $��50��6�   $��11��6�   .��5!      �� $
��Fill=�6    $��25��6/   $��25��6;   $9��3/BodyEnergy;component/Imagenes_Sistema/save_red.png��6F   $ Actualizar Datos��6�   $
	 Hand��6�   5"      �� 5#      -   5        $��btn_Limpiar��5#   �   $��0,0,0,0q�6   
������ #���   6G   $��50��6x   $��Center=�6�   $��Center=�6�   $��50��6�   $��12��6�   .��5$      �� $
��Fill=�6    $��25��6/   $��25��6;   $:��4/BodyEnergy;component/Imagenes_Sistema/trash_Red.png��6F   $ Limpiar Controles��6�   $
	 Hand��6�   5%      �� 5&      -   5        $��	btn_Salir��5&   �   $��50��6   
������ #���   6B   $��0,0,5,0q�6s   $��50��6�   $��Center=�6�   $��Center=�6�   $��13��6�   .��5'      �� $
��Fill=�6    $��25��6/   $��25��6;   $:��4/BodyEnergy;component/Imagenes_Sistema/equiz_red.png��6F   $ Cerrar Ventana��6�   $
	 Hand��6�   5(      5)      5*      5+      �� 5,   
   ���	#0A000000._�5-      �  � RowDefinitions 5.      �� 5/      $
��Auto �6$   �� 50      $
��Auto �6$   �� 51      $��59 �6$   �� 52      $��1 �6$   �� 53      $
��Auto �6$   $��28��62   �� 54      $
��Auto �6$   $��32��62   �� 55      $
��Auto �6$   $��34��62   �� 56       58      �� 59      $
��200* �6'   �� 5:      $
��200* �6'   �� 5;      $
��176* �6'   .+�5=      �� -   5        $��lbl_Detalle��5=   `   $��Detalle��6   $��14(�6*   $��28��68   $
��Left=�6D   $	��Top=�6s   $��22,6,0,0q�6�   $��53��6�   �� 5>      -   5        $��txt_Detalle��5>   C   $��32��6   $
��Left=�6'   $	��Top=�6V   $	��384��6n   $��22,0,0,0q�6z   $��2��6�   $��1��6�   $ Detalle del Pago��6�    �� 	MaxLength$ 90��6�   $��14(�6�   $��Center=�6�   $��1��6  �� 5?      -	   5        $��	lbl_Monto��5?   ^   $��Monto��6   $��14(�6(   $��28��66   $
��Left=�6B   $	��Top=�6o   $��3,6,0,0q�6�   $��2��6�   $��52��6�   '  !VIBlend.WPF.Controls.NumberEditor  5A      -
   5        $��	txt_Monto��5A   _   $  VIBlend.WPF.Controls.InputBase   CultureInfo$ en-US��6.   $
��Left=�6C   $��94��6q    �� TextWrapping$
 Wrap=�6}   $	��Top=�6�   $	��167��6�   $��3,0,0,0q�6�   $��1��6�   $��2��6�   $��3��6�   ���	#FFB80000$ Monto a Cancelar��6  $��28(�6D  $��Center=�6R  $��7��6t  $��Right=�6�  �� 5B      -   5        $��lbl_TipoPago��5B   e   $��Tipo de Pago��6   $��14(�6/   $��28��6=   $
��Left=�6I   $	��Top=�6y   $��21,4,0,0q�6�   $��2��6�   $��92��6�   �� 5C      -   5        $��lbl_PeriodoPago��5C   i   $��Período de Pago��6   $��14(�62   $��28��6A   $
��Left=�6M   $	��Top=�6�   $��1��6�   $��5,4,0,0q�6�   $��2��6�   $	��113��6�   �� 5D      -   5        $��cbo_TipoPago��5D      $��29��6/   $
��Left=�6;   $	��Top=�6V   $	��169��6n   $��	22,31,0,0q�6{   $��2��6�   ���	#FFB80000$ Tipo de Pago��6�   $��14(�6�   $
��Left=�6	  $��Center=�6+  $��2��6M  
�������6Z  �� 5E      -   5        $��cbo_PeriodoPago��5E   C   $��29��6   $
��Left=�6(   $	��Top=�6Z   $	��176��6r   $��1��6~   $��5,31,0,0q�6�   $��2��6�   ���	#FFB80000$ Período a Cancelar��6�    �� 
IsReadOnly . $��Center=�6�   $
��Left=�6  $��14(�68  $��3��6F  
�������6f  �� 5F      -   5        $��lbl_NumeroRecibo��5F   g   $��Número Recibo��6   $��14(�60   $��28��6>   $��Right=�6J   $	��Top=�6   $��0,0,87,0q�6�   $��4��6�   $��2��6�   $	��107��6�   �� 5G      -   5        $��lbl_Comprobante��5G   c   $��Comprobante��6   $��14(�6.   $��28��6<   $
��Left=�6H   $	��Top=�6z   $��22,0,0,0q�6�   $��4��6�   $��96��6�   �� 5H      $��Socio��6   $��14(�6(   $��28��66   $
��Left=�6B   $	��Top=�6_   $��5,0,0,0q�6x   $��1��6�   $��4��6�   $��44��6�   �� 5I      -   5        $��	txt_Socio��5I   A   $��99��6   $
��Left=�6&   $	��Top=�6R   $	��177��6j   $��1��6v   $��5,0,0,0q�6�   $��5��6�   $��3��6�   ���	#FFB80000$ Número de Socio��6�   $��35(�6  $��Center=�6  $��8��63  $��Center=�6@  �� 5J      -   5        $��txt_NumeroRecibo��5J   C   $��99��6   $
��Left=�6'   $	��Top=�6[   $	��167��6s   $��5��6   $$ Número de Recibo del Gimnasio��6�   $��Center=�6�   $ 40��6�   $��Center=�6�   $��30(�6	  $��4��6  $��2��6$  $��3,0,0,0q�64  $��3��6E  �� 5K      -   5        $��txt_Comprobante��5K   B   $��32��6   $
��Left=�6&   $	��Top=�6Y   $	��169��6q   $��22,0,0,0q�6}   $��5��6�   $ Número de Voucher��6�   $ 40��6�   $��14(�6�   $��Center=�6�   $��5��6�   �� 5L      -   5        $��lbl_FechaVencimiento��5L   m   $��Fecha de Vencimiento��6   $��14(�67   $��28��6E   $
��Left=�6Q   $	��Top=�6�   $��21,6,0,0q�6�   $��6��6�   $	��146��6�   +  %Microsoft.Windows.Controls.DatePicker  5M      -   5        $��dpc_FechaVencimiento��5M   >   $
��Left=�6"   $	��Top=�6[   $	��169��6s   $��Stretch=�6   $��Center=�6�   
�������$��Normal"�6�   $��22,1,0,0q�6�   $��7��6�   ���	#FFB80000$��32��6$  $, &Fecha de Vencimiento de la Mensualidad��60  $��LeftToRight=�6a  $��6��6}  $��14(�6�  5N      5O      5P      5Q      