   M S B A M L   `   `   `  ����   	RMS.Admin#    RMS.Admin.Views.InventoryView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     $��Stretch=�$��Stretch=�  � 	Resources  =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value)  #System.Windows.Controls.DataGridRow �� Triggers P� Property P� Value*  $System.Windows.Controls.DataGridCell �� 
TargetType ��Name	 �� Padding
 �� Triggers �� 
TargetName��%�  '        '  �     '      �� "  .���  � ��$ 30����  � ��
 �������  � ��
 �   ���  � ��$ DemiBold"���  � ��$ Center=���  � ��$ Center=���  � ��
 �������  � ��$ 1q��� "  .���  � ��
 ���� ��  � ��$ Center=���  � ��$ Normal"� P�  �@ 
IsSelected . . ���  � ��
 �������  � ��$
 Bold"��� "  .���  � �� �� "  .R��� $ 
ItemBorder��
�������$��1,0,1,1q�$	 0q�._��� 
 P�  �@ 
IsSelected . . ��� $ 
ItemBorder�� � ��
 �������  � ��
 �   ���  � ��$
 Bold"���  �@ 	IsEditing . .��� $��Stretch=� � RowDefinitions �� $��40 ��� $��5 ��� $��* ��� $��5 ��� $��60 �.+��� $��0��$
��Left=� �� Orientation$ Vertical=�$	��Top=�.+��� $	��150��$��30��$��3q�$��Upload Inventory List��&   System.Windows.Controls.DataGrid  $��2��   AutoGenerateColumns .     CanUserResizeRows .  $��Stretch=�$��Stretch=���. $
��Auto=����� *Items+   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Items��   MinWidth$	 300Q�1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Name+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�  $ Quantity��$	 100Q�   MaxWidth$	 100Q� �� *
Quantity+$ PropertyChanged=�$ TwoWay=�� $��4�� � ColumnDefinitions �� �� .+��� $��0��$ 
Horizontal=�$
��Left=�.+��� $��Add Item��$��30��$	��100��$��	10,0,10,0q����� *AddItemCommand+�� $��Delete Item��$��30��$	��100��$��	10,0,10,0q��� $��1��$ 
Horizontal=�$��Right=�.+��� $
��Save��$��30��$	��100��$��0,0,10,0q��� $��Cancel��$��30��$	��100��$��0,0,10,0q�