   M S B A M L   `   `   `  ����G  CCatalogModul, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:CatalogModul.ViewsCatalogModul.Views  5      A%clr-namespace:CatalogModul.ViewModelsCatalogModul.ViewModels  5      $    CatalogModul.Views.CatalogView   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:CatalogModul.Views     5      <
viewmodels%clr-namespace:CatalogModul.ViewModels     5        � 	Resources  5
         NamesSource �� Source  NamesSource1��%a   &	        &	 &     �� 5   
    63   �� *Makes+�� 5   
    64   �� *Models+5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   
���   � �� Padding$ 3q�62   $��3q�6>   ._�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��5q�6   $��10q�5      $	��Add��5      $��30��5      ��5      �� *AddCarCommand+�� 5      $��5q�5      $��10q�5       $��Remove��5!      ��5"      �� *RemoveCammand+��5#      �� *SelectedCar+5$      5%      �� 5&   
   $��1��6   
���   �$ 3q�63   $��3q�6?   ._�5'      �� $ 
Horizontal=�6   .+�5(      �� $��5q�6   $��17(�6'   $��Filter��65   �� 5+      -   5        $��MakesBox��5,   &   $	��100��5+      $��5q�5,       �� SelectedIndex$ 0��5/       �� DisplayMemberPath$
 Name��50      ��5-      �� *Makes+ �� SelectedItem 5.      �� *SelctedMaker+ �� Mode$ TwoWay=�52      �� 54      $	��100��6   $��5q�6'   $
 Name��57      ��55      �� 	 �� ElementName$	 MakesBox��
 �� Path$
 SelectedItem.Models� 56      �� *SelectedModel+$ TwoWay=�59      5:      5;      �� 5=   
   $��1��6   $��Order��6   $��5,5,20,5q�5>      $��Right=�5?      $��Center=�5@      ��5A      �� *SendOrderCommand+��5B      �� *SelectedCar+� 5C   
   $��2��6    � ColumnDefinitions 5E      �� 5F      $��* �6#   �� 5G      $��* �6#   .+�5K      &   System.Windows.Controls.DataGrid  -   5        $
��myDG��5K         AutoGenerateColumns$ False��6e   ��6#   �� *Cars+ 6@   �� *SelectedCar+   Columns 5L      0  *System.Windows.Controls.DataGridTextColumn  5M      ,  &System.Windows.Controls.DataGridColumn   Header$
 Make��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *
Makes.Name+  5N      $ Model��6)    69   �� *Models.Name+  5O      $
 Year��6)    68   �� *Year+  5P      $ Color��6)    69   �� *Color+  5Q      $ Price��6)    69   �� *Price+5T      �� 5V      $��2��6   .@�5W      �� $
��Make��6   .��5X      �  5Y      �� 5Z      $��* �6/   �� 5[      $��* �6/   .+�5]      �� $S��Mc:\users\tarong\source\repos\wpfcarcatalogapp\catalogmodul\images\carimg.jfif��6    $	��Top=�5^       �� 5_      $��1��6%   .+�5`      �� $
��Bold"�6(   $
��Make��6:   �� 5a      ��6&   �� *SelectedCar.Makes.Name+�� 5b      $
��Bold"�6(   $��Model��6:   �� 5c      ��6'   �� *SelectedCar.Models.Name+�� 5d      $
��Bold"�6(   $
��Year��6:   �� 5e      ��6'   �� *SelectedCar.Year+�� 5f      $
��Bold"�6(   $��Color��6:   �� 5g      ��6'   �� *SelectedCar.Color+5h      5j      5k      �� 5l      $��Model��6   �� 5m      $��Discription��6   5n      5p      5q      5r      