   M S B A M L   `   `   `  ���� T  PMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  Z VVIBlend.WPF.Editors, Version=5.0.0.0, Culture=neutral, PublicKeyToken=5f568d4f9cd901f1X?clr-namespace:VIBlend.WPF.Controls;assembly=VIBlend.WPF.EditorsVIBlend.WPF.Controls  
BodyEnergy   BodyEnergy.Transaccion   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Pcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     7my2-http://schemas.microsoft.com/wpf/2008/toolkit  TviblendEditors?clr-namespace:VIBlend.WPF.Controls;assembly=VIBlend.WPF.Editors  -   $��TransaccionW��  � Title$  Pagos��$	��425��$	��650�� � Icon$: 4/BodyEnergy;component/Imagenes_Sistema/CLIMB (8).png�� � 
ResizeMode$ NoResize=� � ShowInTaskbar .  � Topmost .   � WindowStartupLocation$ CenterScreen=� � WindowStyle$ ThreeDBorderWindow=�.��]� ��. .+��� $	��Top=�$��20�����	#0A000000�� $��70��$��Bottom=����	#36000000._��  � ColumnDefinitions �� $	��22* ��� $
��301* ��� $
��303* �.+��� -   $��
btn_Olvido��$$��¿Olvidó el número de Socio?�����	#FFB80000
������ $��30��$	��200��$��Center=�$��Center=� � ToolTip$ Recordar Número de Socio��$
��Bold"�$��13(�$��0q�$��1��	 � Cursor$
	 Hand��$��9������ �� 
 �� Orientation$
 
Horizontal=�$��Right=�$��2��.+��� -   $��btn_Guardar��$��50��
������    MetroCircleButtonStyle#���   $��Center=�$��0,0,0,0q�$��Center=�$��50��$��10��.���� $
��Fill=�$��25��$��25��$9��3/BodyEnergy;component/Imagenes_Sistema/save_Red.png��$ Guardar Datos��$
	 Hand���� -   $��btn_Actualizar��$��50��$��0,0,0,0q�
������ #���   $��Center=�$��Center=�$��50��$��11��.���� $
��Fill=�$��25��$��25��$9��3/BodyEnergy;component/Imagenes_Sistema/save_red.png��$ Actualizar Datos��$
	 Hand���� -   $��btn_Limpiar��$��0,0,0,0q�
������ #���   $��50��$��Center=�$��Center=�$��50��$��12��.���� $
��Fill=�$��25��$��25��$:��4/BodyEnergy;component/Imagenes_Sistema/trash_Red.png��$ Limpiar Controles��$
	 Hand���� -   $��	btn_Salir��$��50��
������ #���   $��0,0,5,0q�$��50��$��Center=�$��Center=�$��13��.���� $
��Fill=�$��25��$��25��$:��4/BodyEnergy;component/Imagenes_Sistema/equiz_red.png��$ Cerrar Ventana��$
	 Hand���� ���	#0A000000._��  � RowDefinitions �� $
��Auto ��� $
��Auto ��� $��59 ��� $��1 ��� $
��Auto �$��28���� $
��Auto �$��32���� $
��Auto �$��34����  �� $
��200* ��� $
��200* ��� $
��176* �.+��� -   $��lbl_Detalle��$��Detalle��$��14(�$��28��$
��Left=�$	��Top=�$��22,6,0,0q�$��53���� -   $��txt_Detalle��$��32��$
��Left=�$	��Top=�$	��384��$��22,0,0,0q�$��2��$��1��$ Detalle del Pago�� �� 	MaxLength$ 90��$��14(�$��Center=�$��1���� -	   $��	lbl_Monto��$��Monto��$��14(�$��28��$
��Left=�$	��Top=�$��3,6,0,0q�$��2��$��52��'  !VIBlend.WPF.Controls.NumberEditor  -
   $��	txt_Monto��$  VIBlend.WPF.Controls.InputBase   CultureInfo$ en-US��$
��Left=�$��94�� �� TextWrapping$
 Wrap=�$	��Top=�$	��167��$��3,0,0,0q�$��1��$��2��$��3�����	#FFB80000$ Monto a Cancelar��$��28(�$��Center=�$��7��$��Right=��� -   $��lbl_TipoPago��$��Tipo de Pago��$��14(�$��28��$
��Left=�$	��Top=�$��21,4,0,0q�$��2��$��92���� -   $��lbl_PeriodoPago��$��Período de Pago��$��14(�$��28��$
��Left=�$	��Top=�$��1��$��5,4,0,0q�$��2��$	��113���� -   $��cbo_TipoPago��$��29��$
��Left=�$	��Top=�$	��169��$��	22,31,0,0q�$��2�����	#FFB80000$ Tipo de Pago��$��14(�$
��Left=�$��Center=�$��2��
��������� -   $��cbo_PeriodoPago��$��29��$
��Left=�$	��Top=�$	��176��$��1��$��5,31,0,0q�$��2�����	#FFB80000$ Período a Cancelar�� �� 
IsReadOnly . $��Center=�$
��Left=�$��14(�$��3��
��������� -   $��lbl_NumeroRecibo��$��Número Recibo��$��14(�$��28��$��Right=�$	��Top=�$��0,0,87,0q�$��4��$��2��$	��107���� -   $��lbl_Comprobante��$��Comprobante��$��14(�$��28��$
��Left=�$	��Top=�$��22,0,0,0q�$��4��$��96���� $��Socio��$��14(�$��28��$
��Left=�$	��Top=�$��5,0,0,0q�$��1��$��4��$��44���� -   $��	txt_Socio��$��99��$
��Left=�$	��Top=�$	��177��$��1��$��5,0,0,0q�$��5��$��3�����	#FFB80000$ Número de Socio��$��35(�$��Center=�$��8��$��Center=��� -   $��txt_NumeroRecibo��$��99��$
��Left=�$	��Top=�$	��167��$��5��$$ Número de Recibo del Gimnasio��$��Center=�$ 40��$��Center=�$��30(�$��4��$��2��$��3,0,0,0q�$��3���� -   $��txt_Comprobante��$��32��$
��Left=�$	��Top=�$	��169��$��22,0,0,0q�$��5��$ Número de Voucher��$ 40��$��14(�$��Center=�$��5���� -   $��lbl_FechaVencimiento��$��Fecha de Vencimiento��$��14(�$��28��$
��Left=�$	��Top=�$��21,6,0,0q�$��6��$	��146��+  %Microsoft.Windows.Controls.DatePicker  -   $��dpc_FechaVencimiento��$
��Left=�$	��Top=�$	��169��$��Stretch=�$��Center=�
�������$��Normal"�$��22,1,0,0q�$��7�����	#FFB80000$��32��$, &Fecha de Vencimiento de la Mensualidad��$��LeftToRight=�$��6��$��14(�