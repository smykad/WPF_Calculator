   M S B A M L   `   `   `  ����I  EWPF_Calculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WPF_CalculatorWPF_Calculator  5   	       WPF_Calculator.HelpWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:WPF_Calculator     5   	     � Title$  Help Window��5   	   $	��400��5	   	   $	��300��5
   	    � WindowStartupLocation$ CenterOwner=�5   	    � 	Resources 5         HelpTextBlock �� 
TargetType �� Property �� Value3  -System.Windows.Media.Effects.DropShadowEffect   Color   	Direction  	BaseLabel��%K  &	        &	 r    �� 5   
   " ��6&   .�5      ��  � ��$ Calibri)�6+   �� 5       � ��$ 20(�6)   �� 5       � ��$
 Bold"�6+   �� 5       � ��
 �����6+   �� 5       � ��$ 15q�6'   �� 5       � ��$
 Wrap=�6-   �� 5       �@J�Effect 5        5      $ DimGray��5      $	 220Q�5      5      5      �� 5   
   " ��6"   .�5       ��  � ��$ Arial)�6+   �� 5!       � ��$
 Bold"�6+   �� 5"       � ��$ 30(�6)   �� 5#       � ��$ Center=�64   �� 5$       � ��$ Center=�62   �� 5%       � ��$ Right=�6;   �� 5&       � ��$ Center=�69   �� 5'       � ��
 �����6+   �� 5(       �@J�Effect 5)        5*      $ DimGray��5+      $	 220Q�5,      5.      5/      50      .��53      �� ��55   
   �� 56      -   5        _background�� �� ImageSource$ Images\backgroundhelp.png��58      .+�5;   
   �� $��Instructions��5<      #��[ 5=      �� 5?   
   $��Enter operands��5@      #��[  5A      �� 5B   
   $#��Click operator of your choice��5C      #��[  5D      �� 5E   
   $;��5The calculation will display in the label at the top.��5F      #��[  5G      �� 5H   
   $?��9To change the theme press the Radio buttons at the bottom��5I      #��[  5J      �� 5L   
   -   5        	 ��Name$	 Button_ExitButton��5L      $
��Exit��5M      $��60��5N      $��25��5O      $��Arial)�5P      $
��Bold"�5Q      $��18(�5R      
���������5T      �� 5U      $ Images\buttonhelp.png��6   
 J� Effect
 5W        5X      $ DimGray��5Y      $	 220Q�5Z      5\      5^      5_      