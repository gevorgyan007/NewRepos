   M S B A M L   `   `   `  ����G  CCatalogModul, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:CatalogModul.ViewsCatalogModul.Views  5      A%clr-namespace:CatalogModul.ViewModelsCatalogModul.ViewModels  6=   $    CatalogModul.Views.CatalogView   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:CatalogModul.Views     5      <
viewmodels%clr-namespace:CatalogModul.ViewModels     6=   .��5
      �   � RowDefinitions  5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   
���   � �� Padding$ 3q�62   $��3q�6>   ._�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��5q�6   $��10q�5      $	��Add��5      $��30��5      ��5      �� *AddCarCommand+�� 5      $��5q�6   $��10q�6%   $��Remove��63   5      5      �� 5   
   $��1��6   
���   �$ 3q�63   $��3q�6?   ._�5      �� $ 
Horizontal=�6   .+�5      �� $��5q�6   $��17(�6'   $��Filter��65   �� 5      $	��100��6   $��5q�5      ��5       �� *	CarType+ �� SelectedValue 5!      �� *SelctedItemMaker+�� 5#      $	��100��5%      $��5q�6'    5#      �� *SelectedModel+��5$      �� *	ModelType+5'      5(      5)      �� 5+   
   $��1��6   $��Order��6   $��5,5,20,5q�5,      $��Right=�5-      $��Center=�5.      ��5/      �� *SendOrderCommand+��50      �� *SelectedCar+� 52   
   $��2��6    � ColumnDefinitions 54      �� 55      $
��175* �6#   �� 56      $	��25* �6#   �� 57      $��56 �6#   �� 58      $
��172* �6#   .+�5;      &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5;      $��2��5>      ��5<      �� *	CarView+ �� SelectedItem 5=      �� *SelectedCar+5@      �� 5B      $��2��6   $��2��6*   .@�5C      �� $
��Make��6   .��5D      �  5E      �� 5F      $��* �6/   �� 5G      $��* �6/   .+�5I      �� $S��Mc:\users\tarong\source\repos\wpfcarcatalogapp\catalogmodul\images\carimg.jfif��6    $	��Top=�5J       �� 5K      $��1��6%   .+�5L      �� $
��Bold"�6(   $
��Make��6:   �� 5M      ��6&   �� *SelectedCar.Make+�� 5N      $
��Bold"�6(   $��Model��6:   �� 5O      ��6'   �� *SelectedCar.Model+�� 5P      $
��Bold"�6(   $
��Year��6:   �� 5Q      ��6'   �� *SelectedCar.Year+�� 5R      $
��Bold"�6(   $��Color��6:   �� 5S      ��6'   �� *SelectedCar.Color+5T      5V      5W      �� 5X      $��Model��6   �� 5Y      $��Discription��6   5Z      5\      5_      5`      