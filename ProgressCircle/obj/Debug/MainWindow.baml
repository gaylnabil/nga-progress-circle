   M S B A M L   `   `   `  ����I  EProgressCircle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ProgressCircleProgressCircle  5   I       ProgressCircle.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   c _Microsoft.Expression.Drawing, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35=ed4http://schemas.microsoft.com/expression/2010/drawing  5   	   (localclr-namespace:ProgressCircle  6I     � Title$  
MainWindow��5   	   $	��400��6   $	��357��6)    � 
ResizeMode$ CanResizeWithGrip=�65    � WindowStartupLocation$ CenterScreen=�6T   |�.   � WindowStyle$ ThreeDBorderWindow=�6�   .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $	��320 �6   6+   �� 5      $��* �6   6)   .+�5   
   %   ProgressCircle.ProgressCircleUC  $
��Left=�6!   $��5q�6<   $��Center=�6G   $��Center=�6b      indicatorBrush
 ��+��   BorderProgressBarBrush
 �����   ellipseBgBrush
 �����	   percentBrush
	 ��+��
   valueEndAngle
 5   y   ��  �� ElementName$ Slider1�� �� Path$ Value��� 5   
   -   5         ��Name$ Slider1��5      $
��auto��6"   $��0��6/   $��1��6?    � Minimum$ 0Q�6L    � Maximum$	 100Q�6X    � Value$ 35Q�6f   5      5      