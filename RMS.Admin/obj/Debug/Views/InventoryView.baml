   M S B A M L   `   `   `  ����  	RMS.Admin#    RMS.Admin.Views.InventoryView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      $��Stretch=�5      $��Stretch=�6B     � 	Resources  5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value)  #System.Windows.Controls.DataGridRow �� Triggers P� Property P� Value*  $System.Windows.Controls.DataGridCell �� 
TargetType ��Name	 �� Padding
 �� Triggers �� 
TargetName��%n  '        '  W    '  ~    �� 5	   
   "  6   .�5
      ��  � ��$ 30��6'   �� 5       � ��
 �����6+   �� 5       � ��
 �   �6+   �� 5       � ��$ DemiBold"�6+   �� 5       � ��$ Center=�69   �� 5       � ��$ Center=�6;   �� 5       � ��
 �����6,   �� 5       � ��$ 1q�60   5      �� 5   
   "  6   .�5      ��  � ��
 ���� 6+   �� 5       � ��$ Center=�62   �� 5       � ��$ Normal"�6+    5      P� 5       �@ 
IsSelected . . �5      ��  � ��
 �����63   �� 5       � ��$
 Bold"�63   5      5      �� 5    
   "  6   .�5!      ��  � �� 5"      �� 5#      "  6&   .R�5$      �� $ 
ItemBorder��6!   
�������$��1,0,1,1q�6L   $	 0q�6f   ._�5%      �� 5&      
 5'      P� 5(       �@ 
IsSelected . . �5)   "   �� $ 
ItemBorder��6)    � ��
 �����6W   �� 5*   "    � ��
 �   �6?   �� 5+   "    � ��$
 Bold"�6?   �� 5,   "    �@ 	IsEditing . 6>   5-      5/      51      52      54      .��56      � $��Stretch=�6    � RowDefinitions 57   
   �� 58      $��40 �6   �� 59      $��5 �6   �� 5:      $��* �6   �� 5;      $��5 �6   �� 5<      $��60 �6   .+�5>   
   �� $��0��6   $
��Left=�6"    �� Orientation$ Vertical=�6=   $	��Top=�6T   .+�5?      �� $	��150��6   $��30��6!   $��3q�6-   $��Upload Inventory List��68   5@      &   System.Windows.Controls.DataGrid  5A   
   $��2��6      AutoGenerateColumns .     CanUserResizeRows .  $��Stretch=�5C         SelectionUnit$ FullRow=�5E         CanUserAddRows .  
������ $��Stretch=�5I      ��. $
��Auto=�5J   8   ��5D      �� *Items+ �� SelectedItem 5F      �� *SelectedItem+   Columns 5K      0  *System.Windows.Controls.DataGridTextColumn  5L      ,  &System.Windows.Controls.DataGridColumn   Header$ Items��6%      MinWidth$	 300Q�64   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *Name+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�  5M      $ Quantity��6%   $	 100Q�67      MaxWidth$	 100Q�6F    6U   �� *
Quantity+$ PropertyChanged=�$ TwoWay=�5O      � 5P   
   $��4��6    � ColumnDefinitions 5Q      �� 5R      �� 5S      .+�5U      �� $��0��6   $ 
Horizontal=�6)   $
��Left=�6B   .+�5V      �� $��Add Item��6   $��30��6,   $	��100��68   $��	10,0,10,0q�6D   ��6W   �� *AddItemCommand+�� 5W      $��Delete Item��6   $��30��6/   $	��100��6;   $��	10,0,10,0q�6G   ��6Z   �� *DeleteItemCommand+5X      �� 5Y      $��1��6   $ 
Horizontal=�6*   $��Right=�6C   .+�5Z      �� $
��Save��6   $��30��6(   $	��100��64   $��0,0,10,0q�6@   �� 5[      $��Cancel��6   $��30��6*   $	��100��66   $��0,0,10,0q�6B   5\      5]      5_      5`      