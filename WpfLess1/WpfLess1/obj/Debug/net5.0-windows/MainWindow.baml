   M S B A M L   `   `   `  ����C  ?WpfLess1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfLess1WpfLess1  5   	       WpfLess1.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WpfLess1     5   	     � Title$  Magic 8 ball��5   	   $	��450��6   $	��800��6+   .��5	      � ��5
   
   �� 5       �� EndPoint$	 0,1&�6"    �� 
StartPoint$	 0,0&�61   .��5      �  � Color$ Black��6    � 5      $ 	#FF592525��6     � Offset$ 1Q�62   5       � ColumnDefinitions 5   
   �� 5      $
��324* �6   �� 5      $
��193* �6    � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $
��auto �6   �� 5      $	��90* �6   .+�5   
   �� -   5        $��txtQusetion��5      $��Stretch=�5      $��Stretch=�5      $��10q�5       �� TextWrapping$
 Wrap=�5      $��Vardana)�5      $��20(�5       $��0��5!      ���	#FF646464$��[Inpute Question.]��5#      $��2��6,   ���	#FF5B8D5F6@   �� 5$   
   -   5        $
��Left=�5%      $��Stretch=�5&      $��10,0,0,0q�5'      $��5q�5(      $��1��5)      $��Answer question��5*       �� 	IsDefault$
 True��5,      ���	#FF2D746D6   �� 5-   
   -   5        $��	txtAnswer��5-      $��Stretch=�5.      $��Stretch=�5/      $��10q�50      $
 Wrap=�51      $��Vardana)�52      	 �� 
IsReadOnly$
	 True��53      $��20(�54      $��2��55      ���	#FF009Bff$��[Answer show there]��57      $��2��6-   ���	#FF6E57576A   58      5:      