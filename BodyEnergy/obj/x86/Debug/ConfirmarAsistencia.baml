   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	    
BodyEnergy$   BodyEnergy.ConfirmarAsistencia   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Pcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   -   5        $��ConfirmAsistW��5   V     � Title$!  Confirmación de Asistencia��5   	   $	��450��6,   $	��850��69    � WindowStartupLocation$ CenterOwner=�6E    � WindowStyle$ ThreeDBorderWindow=�5   	    � 
ResizeMode$ NoResize=�6+    � ShowInTaskbar .  � Icon$: 4/BodyEnergy;component/Imagenes_Sistema/CLIMB (8).png��5       � Topmost .  $��0q�5	   	   (   "MahApps.Metro.Controls.MetroWindow   WindowTransitionsEnabled .  .��5
      ]� ��. .+�5   
   �� $	��Top=�6   $��40��6&   ���	#0A000000._�5      �� -   5        $��lbl_MensajeBienvenida��5   �   $��Label��6   $��20(�6$   
�������$y�Hidden=�6E   $��Center=�6Y   $��Center=�6}   $��Center=�5      5      �� 5   
   $��70��6   $��Bottom=�6   ���	#FFC9C9C9._�5      �  � ColumnDefinitions 5      �� 5      $	��16* �6'   �� 5      $
��547* �6'   �� 5      $
��165* �6'   �� 5      $
��114* �6'   .+�5      �� 	 �� Orientation$	 
Horizontal=�6   $��Right=�67   $��3��6T   $��66��6d   .+�5      �� -   5        $��
btn_Cerrar��5   �   $��56��6      MetroCircleButtonStyle#���   6)   
������ $��0,0,0,0q�6t   $��Center=�6�   $y�Visible=�6�   $��Center=�6�   $��56��5      .��5      �� $
��Fill=�6    $��28��60   $��28��6<   $:��4/BodyEnergy;component/Imagenes_Sistema/equiz_Red.png��6G   
 � ToolTip$
 Cerrar��6�   5      5      �� 5      $	 
Horizontal=�6   $y�Hidden=�66   $
��Left=�6K   $��1��6f   $	��689��6v   $��2��6�   .+�5       �� -   5        $��	lbl_Monto��5    x   $�� ��6   $��0,0,7,0q�6'   $��20(�68   $
��Left=�6F   $y�	Collapsed=�6a   $��Center=�6�   $
��Bold"�6�   $��1��6�   $
 Monto��6�   �� 5!      -   5        $��lbl_DiaPago��5!   a   $�� ��6   $��0,0,7,0q�6'   $��20(�68   $
��Left=�6F   $��Center=�6t   $
��Bold"�6�   $��1��6�   $
 Día de Pago��6�   $	��646��6�   5"      5#      5$      �� 5%   
   $
��Left=�6   $	��275��6'   ���	#0A000000._�5&      �� $��Center=�6   $��Center=�66   .+�5'      �� -   5        $��	img_socio��5'   B   $	��258��6   $��Center=�6%   $
��Fill=�6S   $	��Top=�6b   $	��213��6z   5*      5+      �� 5,   
   ���	#0A000000._�5-      �� $��Center=�6   .+�5.      �� -   5        $��lbl_VenceHoy1��5.   v   $��Le recordamos que��6   $y�	Collapsed=�64   $��Center=�6K   $��44(�6h   $��Center=�6�   �� 5/      -   5        $��lbl_VenceHoy2��5/   ~   $��hoy debe realizar el pago��6   $y�	Collapsed=�6<   $��Center=�6S   $��44(�6p   $��Center=�6�   �� 50      -	   5        $��lbl_VenceHoy3��50   w   $��de su mensualidad.��6   $y�	Collapsed=�65   $��Center=�6L   $��44(�6i   $��Center=�6�   �� 51      -
   5        $��	lbl_AlDia��51   {   $��Gracias por su visita.��6   $y�	Collapsed=�69   $��Center=�6P   $��44(�6m   $��Center=�6�   �� 52      -   5        $��lbl_Moroso1��52   �   $��Su mensualidad ha vencido��6   
���  ��$y�	Collapsed=�6N   $��Center=�6e   $��44(�6�   $��Center=�6�   �� 53      -   5        $��lbl_Moroso2��53   �   $��por favor realice el pago��6   
���  ��$y�	Collapsed=�6M   $��Center=�6d   $��44(�6�   $��Center=�6�   �� 54      -   5        $��lbl_Moroso3��54   �   $��lo más pronto posible.��6   
���  ��$y�	Collapsed=�6J   $��Center=�6a   $��44(�6~   $��Center=�6�   �� 55      -   5        $��lbl_manana1��55   w   $��Le recordamos que ��6   $y�	Collapsed=�65   $��Center=�6L   $��44(�6i   $��Center=�6�   �� 56      -   5        $��lbl_manana2��56   u   $��el día de mañana��6   $y�	Collapsed=�63   $��Center=�6J   $��44(�6g   $��Center=�6�   �� 57      -   5        $��lbl_manana3��57   z   $��vence su mensualidad.��6   $y�	Collapsed=�68   $��Center=�6O   $��44(�6l   $��Center=�6�   �� 58      -   5        $��lbl_NombreSocio��58   _   $��Label��6   $��20(�6(   $��39��66   $��Center=�6B   $	��Top=�6v   59      5:      5;      5<      