   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	    
BodyEnergy    BodyEnergy.BusquedaEmpresa   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Pcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   6my-http://schemas.microsoft.com/wpf/2008/toolkit  5   	   -   5        $��	BEmpresaW��5   @     � Title$  Busqueda de Empresas��5   	   $	��500��6&   $	��178��63    � SizeToContent$ Height=�6C   $	��550��6Z    � Icon$: 4/BodyEnergy;component/Imagenes_Sistema/CLIMB (8).png��5   B    � 
ResizeMode$ NoResize=�5   	    � ShowInTaskbar .  � Topmost .   � WindowStartupLocation$ CenterScreen=�6D    � WindowStyle$ ThreeDBorderWindow=�5   	   .��5	      ]� ��. .+�5
   
   �� $	��Top=�6   $��15��6&   ���	#0A0000005      �� 5   
   $��20��6   $��Bottom=�6   ���	#360000005      �� 5   
   ���	#0A000000._�5      � .+�5      �� -   5        $��lbl_Empresa��5   t   $��Empresa��6   $��14(�6*   $��28��68   $
��Left=�6D   $��12,-5,0,414q�6_   $��Bottom=�6�   �� 5      -   5        $��txt_Empresa��5   U   $��28��6   $
��Left=�6&   $��
12,0,0,386q�6A   $��Bottom=�6h   $	��303��6�    �� 	MaxLength$	 150��6�   $��Center=�6�   $��14(�6�   $��1��6�   	 � ToolTip$!	 Filtro de Nombre de Empresa��6�   �� 5      -   5        $��
btn_Buscar��5   �   $��50��6   
������    MetroCircleButtonStyle#���   6>   $
��Left=�6p   $	��Top=�6�   $��50��6�   $	 Buscar��6�   $��5��6�   $��	430,1,0,0q�6�   .��5      �� $
��Fill=�6   $��25��6+   $��25��67   $;��5/BodyEnergy;component/Imagenes_Sistema/search_red.png��6B   $	 Buscar��6�   
 � Cursor$

 Hand��6�   5      �� 5      -   5        $��btn_Exportar��5   �   $��	480,1,0,0q�6   #���   6,   
������ $
��Left=�6v   $��50��6�   $	��Top=�6�   $��50��6�   $��6��6�   $

 Hand��6�   .��5      �� $
��Fill=�6   $��25��6+   $��25��67   $<��6/BodyEnergy;component/Imagenes_Sistema/excel-file2.png��6B   $	 Exportar a Excel��6�   $

 Hand��6�   5      &   System.Windows.Controls.DataGrid  5      -   5        $��gdv_Empresas��5   t   $
��Left=�6   $��
12,66,0,10q�66      
IsReadOnly . $	��522��6�   $

 Hand��5   L      AutoGenerateColumns .  $��1q�5         ColumnHeaderHeight$ 25Q�60   
�������   	RowHeight$ 20Q�6_   ��5   J   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Codigo_Empresa��6-      
Visibility$ Hidden=�6E      Width5  /System.Windows.Controls.DataGridLengthConverter$ 10 6Y      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6v   �� *Codigo+  5      $ Empresa��6-   $	 165 6>    .  6]   �� *Nombre_Empresa+  5      $ Teléfono 1��6-   $ 80 6A    .  6_   �� *
Telefono_1+  5      $ Teléfono 2��6-   $ 80 6A    .  6^   �� *
Telefono_2+  5       $ Correo��6-   $	 127 6=    .  6[   �� *Correo+4  .System.Windows.Controls.DataGridCheckBoxColumn  5!      $ Activo��61   $ 65 6A    .  6^   �� *Estado+5"      5$      5%      5&      5'      5(      