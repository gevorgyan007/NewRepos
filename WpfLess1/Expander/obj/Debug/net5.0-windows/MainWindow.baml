   M S B A M L   `   `   `  ����C  ?Expander, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ExpanderExpander  5   	       Expander.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Expander     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �� .+�5
   
   9� $��
Expander 1��6    9� 
IsExpanded$ False��6'   $��5q�6:   $��3q�6E   
��� ���.��5      �� .��6   
Button 16"   5      9� 5   
   $��
Expander 2��6   $
 True��6'   $��5q�69   $��3q�6D   
���   �.��5      ��  �� TextWrapping$
 Wrap=�6    �� 
IsReadOnly$
 True��6*   " �� VerticalScrollBarVisibility$
 Auto=�6<   .��6_   �	�	User Controls provide a way to collect and combine different built-in controls together and package them into re-usable XAML. User controls are used in following scenarios − If the control consists of existing controls, i.e., you can create a single control of multiple, already existing controls. If the control doesn't need support for theming. User Controls do not support complex customization, control templates, and difficult to style. If a developer prefers to write controls using the code-behind model where a view and then a direct code behind for event handlers. You won't be sharing your control across applications. User Controls provide a way to collect and combine different built-in controls together and package them into re-usable XAML. User controls are used in following scenarios − If the control consists of existing controls, i.e., you can create a single control of multiple, already existing controls. If the control doesn't need support for theming. User Controls do not support complex customization, control templates, and difficult to style. If a developer prefers to write controls using the code-behind model where a view and then a direct code behind for event handlers. You won't be sharing your control across applications.5      5      9� 5   
   $��
Expander 1��6   $ False��6'   $��5q�6:   $��3q�6E   
��� ���.��5      �� .��6   
Button 16    5      9� 5   
   $��
Expander 1��6   $ False��6(   $��5q�6;   $��3q�6F   
��� ���.��5       �� $	��200��6   
�������
�������$��3q�5"       �� CornerRadius$ 10,20,45,40��5#       �� Padding$ 15q�5$      $��15q�5%      ._�5&      �� 
�������$	��120��62   
�������.��6W   
Button 16a   5'      5)      5*      5+      