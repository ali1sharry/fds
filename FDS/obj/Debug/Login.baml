   M S B A M L   `   `   `  ����>  :FDS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:FDSFDS  5   	       	FDS.Login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:FDS     5   	   [ WMahApps.Metro.IconPacks.Material, Version=2.3.0.4, Culture=neutral, PublicKeyToken=null=	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks  5   	   -   5          � Icon$  /Images/logo.png��5	   	   $	��450��5
   	   $	��380��6    � AllowsTransparency . 
������  � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�6   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      �� 5      .+�5      ��  �� CornerRadius$ 10��6   $��2��6'   ��5      �� 5      .��5      �  � Color$ #7be9f6��6'    � Offset$	 0.0Q�67   � 5      $ #f083da��6'   $ 1Q�67   5      5      .  (MahApps.Metro.IconPacks.PackIconMaterial  5       -   5        E AControlzEx, Version=3.0.2.4, Culture=neutral, PublicKeyToken=null�  �ControlzEx.PackIconBase`1[[MahApps.Metro.IconPacks.PackIconMaterialKind, MahApps.Metro.IconPacks.Material, Version=2.3.0.4, Culture=neutral, PublicKeyToken=null]]   Kind$ CloseCircle=�5    )   $��20��5"   %   $��20��5#   %   $��Right=�5$   -   $	��Top=�5%   -   
�������$��	0,10,10,0q�5&   @   	 J� RenderTransformOrigin$	 0.608,0.355&�6S   �� 5'      $��Center=�6   .+�5(      �� $��/Images/logo.png��6   $��80��62   �� 5)      $��Food Distribution System��6   $��Light"�5*      $��	helvetica)�5+      $��22(�5,      
�������$��Center=�5.      5/      �� 52      $��1��6   .+�53      �� 
 �� Orientation$
 
Horizontal=�6   .+�54      �� -   5        $��
username01��56      $��	helvetica)�54      $��Light"�57      $��20(�59      $��Center=�5:      
�������
������ $��0q�5=      $	��235��5>      $
��Left=�5?       J� Opacity$	 0.5Q�5@      $��25��5A      $��63,0,0,0q�5B        5C      $ Account=�61   $��Center=�5D   -   $��Center=�5E   -   
�������5F   -   5I      �� 5J      $	��250��6   $��2��5K      
�������$	 0.5Q�5M      �� 5P      $
 
Horizontal=�6   $��0,20,0,0q�67   .+�5Q      G� -   5        $��pwd01��5U      $��	helvetica)�5Q   "   $��Light"�5R      $��20(�5W      $��Center=�5X      
�������
������ $��0q�5[      $	��235��5\      $
��Left=�5]      $	 0.5Q�5^      $��25��5_      $��63,0,0,0q�5`        5a      $ TextboxPassword=�61   $��Center=�5b   -   $��Center=�5c   -   
�������5d   -   5g      �� 5h      $	��250��6   $��2��5i      
�������$	 0.5Q�5k      �� 5l      $
 
Horizontal=�6   $��0,50,0,0q�66   .+�5m      �� -   5        $	��100��5m      $��40��5o      $��LOGIN��5p      $��140,-20,0,0q�5q      5s      5t      5v      5w      5x      