   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	    
BodyEnergy(   "BodyEnergy.BusquedaSocioAsistencia   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Pcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   7my1-http://schemas.microsoft.com/wpf/2008/toolkit  5   	   -   5        $��BSocioAsistW��5   @     � Title$  Búsqueda de Socios��5   	    � Topmost .  $	��500��64   $	��478��6E   $	��500��6U   $	��729��6c    � SizeToContent$ Height=�5   C    � WindowStyle$ ThreeDBorderWindow=�6Z    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Icon$: 4/BodyEnergy;component/Imagenes_Sistema/CLIMB (8).png��6.    � ShowInTaskbar . .��5
      ]� ��. .+�5   
   �� $	��Top=�6   $��10��6&   ���	#0A0000005      �� 5   
   $��20��6   $��Bottom=�6   ���	#360000005      �� 5   
   ���	#0A000000._�5      � .+�5      �� -   5        $��lbl_NombreCompleto��5   ~   $��Nombre o Apellidos��6   $��14(�65   $��28��6C   $
��Left=�6O   $��
27,0,0,414q�6j   $��Bottom=�6�   $	��228��6�   �� 5      -   5        $��txt_NombreCompleto��5   d   $��64��6   $
��Left=�6&   $��40(�6A   $��
27,0,0,350q�6P   $��Bottom=�6~   $	��557��6�   $�� ��6�    �� 	MaxLength$	 180��6�   $��Center=�6�   	 � ToolTip$	 Filtro de Nombre de Socio��6�   $��1��6  6  �� 5      -   5        $��
btn_Buscar��5   d   
������    MetroCircleButtonStyle#���   62   $	 Buscar��6v   $��5��6�   $��
612,21,0,0q�6�   $��73��6�   $	��Top=�6�   $
��Left=�6�   $��72��6   .��5      �� $
��Fill=�6   $��30��6+   $��30��67   $;��5/BodyEnergy;component/Imagenes_Sistema/search_red.png��6B   $	 Buscar��6�   
 � Cursor$

 Hand��6�   5      &   System.Windows.Controls.DataGrid  5      -   5        $��
gdv_Socios��5   p   $
��Left=�6   $��16(�67   $��	10,0,0,10q�6E   $��Bottom=�6�   $	��703��6�      AutoGenerateColumns .     CanUserResizeColumns .    
IsReadOnly . $

 Hand��5   G   $��Center=�6U   $   HorizontalScrollBarVisibility$ Disabled=�6y   $��1q�5         ColumnHeaderHeight$ 30Q�60   
�������   	RowHeight$ 20Q�6_   $	��323��6n   ��5   X   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Número��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6=      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6[   �� *Numero_Socio+  5      $ Nombre Completo��6-   $	 280 6F    .  6d   �� *Nombre_Completo+  5       $ Fecha Vencimiento��6-   $	 220 6H    .  6f   �� *Fecha_Vencimiento+4  .System.Windows.Controls.DataGridCheckBoxColumn  5!      $ Activo��61   $ 97 6A    .  6^   �� *Estado_Socio+5"         RowDetailsTemplate 5$      �� 5%      .R�5&      ��  �� Orientation$ 
Horizontal=�6*   $��Center=�6C   $��0,5,0,5q�6`   .+�5'   "   �� $��btn_Asistencia��6)   $��90��6?   $��0,0,10,0q�6J   $��
Asistencia��6\   �� 5(   "   $��
btn_Editar��6)   $��90��6;   $��0,0,10,0q�6F   $��Editar��6X   �� 5)   "   $��btn_Pago��6)   $��90��69   $��0,0,10,0q�6D   $
��Pago��6V   5*      5+      5-      5.      5/      50      51      