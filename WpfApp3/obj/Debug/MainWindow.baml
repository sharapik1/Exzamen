   M S B A M L   `   `   `  ����B  >WpfApp3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp3WpfApp3  5   	       WpfApp3.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp3     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ShowGridLines .  � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      �� 5      $��50 �6    � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      .+�5   
   �� $!��./Photo/pokupateliphoto.jpg��5      $��2��5      �� 5   
    �� Orientation$ Vertical=�5   	   $��3��5   	   $��Bottom=�5   	   .+�5      �� -   5         ��Name$ 
ExitButton��5      $��
Выход��5      $��50��5!      5"      � 5$   
    � Orientation$ 
Horizontal=�5%   	   $��1��5&   	   $��50��5'   	   .+�5(      �� $��Город:��5)      $��Center=�5*      �� 5+      -   5        $��CityFilterComboBox��5,      $��Center=�5.      $	��100��5/       �� SelectedIndex$ 0��50      ��51      �� *
CityList+��52      �� 53      .R�54      �� ��55      �� *Title+56      58      �� 59      $��Искать��5:      $��Center=�5;      �� 5<      -   5         ��Name$ SearchFilterTextBox��5?      $	��200��5=      $��Center=�5>      5@      �� 5A      $ ��Сумма покупки:��5B      $��Center=�5C      	� 5D      -   5        	 	� 	GroupName$	 Summapokupok��5E      

 � Tag$
 1��5F      $!��по возрастанию��5G       d� 	IsChecked$
 TrueY�5H      $��Center=�5J      	� 5K      -   5        $	 Summapokupok��5L      $
 2��5M      $��по убыванию��5N      $��Center=�5P      5R      &   System.Windows.Controls.DataGrid  5S   
   $��1��5T      $��1��5U         CanUserAddRows .     AutoGenerateColumns .  ��5X      �� *PokupateliList+   Columns 5Y      0  *System.Windows.Controls.DataGridTextColumn  5Z      ,  &System.Windows.Controls.DataGridColumn   Header$ Имя��5[      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5\      �� *Name+  5]      $ Возраст��5^       5_      �� *Age+  5`      $ Сумма покупок��5a       5b      �� *Summapokupok+  5c      $ Дата покупки��5d       5e      �� *
DateString+  5f      $ 
Город��5g       5h      �� *City+  5i      $ Магазин��5j       5k      �� *	Magazin+5m      5n      5q      