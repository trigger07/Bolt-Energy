   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	    
BodyEnergy(   "BodyEnergy.BusquedaContactoEmpresa   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Pcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   6my-http://schemas.microsoft.com/wpf/2008/toolkit  5   	   -   5        $��
BContactoW��5   @     � Title$  Contactos de Empresa��5   	    � Topmost .  $	��520��66   $	��729��5   	    � SizeToContent$ Height=�6    � WindowStyle$ ThreeDBorderWindow=�6,    � 
ResizeMode$ NoResize=�6M    � WindowStartupLocation$ CenterScreen=�6c    � Icon$: 4/BodyEnergy;component/Imagenes_Sistema/CLIMB (8).png��5   B    � ShowInTaskbar . .��5      ]� ��. .+�5	   
   �� $	��Top=�6   $��10��6&   ���	#0A0000005
      �� 5   
   $��20��6   $��Bottom=�6   ���	#360000005      �� 5   
   ���	#0A000000._�5      �  � ColumnDefinitions 5      �� 5      $
��362* �6'   �� 5      $
��343* �6'   .+�5      �� -   5        $��
lbl_Nombre��5   ~   $��Nombre o Apellidos��6   $��14(�65   $��28��6C   $
��Left=�6O   $��
23,0,0,434q�6j   $��Bottom=�6�   �� 5      -   5        $��
btn_Buscar��5   �   $��50��6   $
��Left=�6&      MetroCircleButtonStyle#���   6A   $��	237,7,0,0q�6r   $	��Top=�6�   $��50��6�   	 � Cursor$
	 Hand��6�   $��3��6�   
 � ToolTip$
 Buscar��6�   $��1��6�   .��5      �� $
��Fill=�6   $��25��6+   $��25��67   $;��5/BodyEnergy;component/Imagenes_Sistema/search_Red.png��6B   $
 Buscar��6�   $
	 Hand��6�   5      �� 5      -   5        $��lbl_Empresa��5   t   $��Empresa��6   $��28��6*   $��14(�66   $
��Left=�6D   $��318,0,0,434q�6_   $��Bottom=�6�   $��2��6�   �� 5      -   5        $��
txt_Nombre��5   U   $��28��6   $
��Left=�6&   $��
23,0,0,406q�6A   $��Bottom=�6g   $	��252��6�   $"
 Filtro de Nombre o Apellidos��6�   $��1��6�   $��14(�6�   $��Center=�6�   $�� ��6�    �� 	MaxLength$	 175��6�   �� 5      -   5        $��cbo_Empresa��5   Z   $��28��6   $��Right=�6)   $��0,0,168,406q�6E   $��Bottom=�6m   $	��237��6�   $��Center=�6�   $��14(�6�   
�������$��2��6�   $
 Filtro de  Empresa��6�   $��2��6  5      &   System.Windows.Controls.DataGrid  5      -   5        $��gdv_Contactos��5   d   $
��Left=�6   $��
10,73,0,10q�68   $	��703��6y   $
	 Hand��6�   $��Center=�5         AutoGenerateColumns .     CanUserResizeColumns .    
IsReadOnly . $��2��5   N   $��1q�5         ColumnHeaderHeight$ 25Q�60   
�������   	RowHeight$ 20Q�6_   ��5   L   ��    Columns 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn   Header$ Codigo��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ 10 6=      
Visibility$ Hidden=�6H      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6n   �� *Codigo+  5"      $ Nombre Completo��6-   $	 172 6F    .  6d   �� *Nombre_Completo+  5#      $ 	Teléfono��6-   $ 80 6?    .  6\   �� *
Telefono_1+  5$      $	 Fax��6-   $ 75 6:    .  6W   �� *
Telefono_2+  5%      $ Correo��6-   $	 144 6=    .  6[   �� *Correo+  5&      $ Empresa��6-   $	 160 6>    .  6\   �� *Nombre_Empresa+4  .System.Windows.Controls.DataGridCheckBoxColumn  5'      $ Activo��61   $ 67 6A    .  6^   �� *Estado+5(      5*      �� 5+      -   5        $��btn_Exportar��5+   �   $��50��6   $
��Left=�6%   $��	283,7,0,0q�6@   #���   6S   $	��Top=�6�   $��50��6�   $
 Exportar a Excel��6�   $��4��6�   $
	 Hand��6�   $��1��6  .��5,      �� $
��Fill=�6   $��25��6+   $��25��67   $<��6/BodyEnergy;component/Imagenes_Sistema/excel-file2.png��6B   $
 Exportar a Excel��6�   $
	 Hand��6�   5-      5.      5/      50      51      