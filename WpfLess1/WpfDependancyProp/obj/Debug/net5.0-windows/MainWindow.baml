   M S B A M L   `   `   `  ����L  HWpfDependancyProp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:WpfDependancyPropWpfDependancyProp  5   	   "    WpfDependancyProp.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:WpfDependancyProp     5   	     � Title$  
MainWindow��5   	   $	��400��6   $	��800��6)   .��5	      �  J� RenderTransformOrigin$ 0.5,0.5&�6   z�5
   
   V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -0.04Q�6"   T� 5      5       � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $
��Auto �6   �� 5      �� 5      $��0* �6   .+�5   
   '   !WpfDependancyProp.MyFirstControls  -   5          Name$ myFirstControl1��5         Data 5      ��  �� ElementName$ slider1�� �� Path$ Value�5      �� 5   
   -   5        $��button1��5       $��3��6   $��	Get value��5       $��23��5!      $
��Left=�5"      $��12,3,0,0q�5#      $	��Top=�5$      $��75��5%      5&      �� 5(   
   -   5        $��slider1��5(   .   $��0��6    � Maximum$	 100Q�6    $��23��5)      $
��Left=�5*      $	��Top=�5+      $	��437��5,      $��	10,10,0,0q�5-      �� 5.   
   	 �� Orientation$	 
Horizontal=�6   $��1��6.   .+�5/      �� -   5        $��text1��5/   �   
��� ���$��10q�6�   $
��Left=�6�   $��30��6�   $	��150��6�   
 �� 
IsReadOnly
 6   �� $ chek1��$ 	IsChecked���6P   �� $ slider1��$ Value�6�   �� 50      -   5        $��chek1��50   +   
��� ���$��20q�6l    d� 	IsChecked$
 TrueY�6x   �� 52      -   5        $��button2��52   $   $��2��6   $��Change��53      $��23��54      $��75��55      56      57      58      59      