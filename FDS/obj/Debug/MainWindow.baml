   M S B A M L   `   `   `  ����>  :FDS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:FDS.MVVM.ViewModelFDS.MVVM.ViewModel  5   	   clr-namespace:FDSFDS  5   	       FDS.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6	viewModel clr-namespace:FDS.MVVM.ViewModel     5   	   [ WMahApps.Metro.IconPacks.Material, Version=2.3.0.4, Culture=neutral, PublicKeyToken=null=	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks  5   	   localclr-namespace:FDS  5   	     � WindowStartupLocation$  CenterScreen=�5	   	   $	��600��5   	   $	��930��6    � WindowStyle$
 None=�5   	    � Icon$ /Images/logo.png��5   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency .  � DataContext 5      &   FDS.MVVM.ViewModel.MainViewModel  5   
   .��5      �� ���#272537 �� CornerRadius$ 20��5      ._�5   
   �  � ColumnDefinitions 5      �� 5      $	��200 �6#   �� 5       � RowDefinitions 5      �� 5      $��75 �6    �� 5      .+�5       �� $
��Left=�6   $��/Images/logo.png��6/   �� 5!      $��Food Donation Sys��6   $��Center=�5"      $
��Left=�5#      
�������$��15(�5%      $��
55,38,0,17q�5&      $	��135��6    �� 5'      $��1��6   .+�5*      	� $
��Home��5+      $��50��5,      
�������$��14(�5.         MenuButtonTheme#��[  5/      	 d� 	IsChecked$
	 TrueY�50      ��51      �� *HomeViewCommand+53      	� 57      $��Users��58      $��50��59      
�������$��14(�5;      #��[  5<      ��5>      �� *UserViewCommand+	� 5A      $��Beneficiares��5B      $��50��5C      
�������$��14(�5E      #��[  5F      ��5G      �� *BeneficiariesViewCommand+	� 5K      $��Donors��5L      $��50��5M      
�������$��14(�5O      #��[  5P      ��5Q      �� *DonorViewCommand+	� 5U      $��
Food Store��5V      $��50��5W      
�������$��14(�5Y      #��[  5[      ��5Z      �� *FoodstoreViewCommand+5[      	� 5_      $��Donation��5`      $��50��5a      
�������$��14(�5c      #��[  5e      ��5d      �� *DonationViewCommand+5e      	� 5i      $��Distribution��5j      $��50��5k      
�������$��14(�5m      #��[  5o      ��5n      �� *DistributionViewCommand+5o      	� 5s      $��Reports��5t      $��50��5u      
�������$��14(�5w      #��[  5y      ��5x      �� *ReportViewCommand+5y      5|      �� 5}      -   5        $��displayname01��5~      $	��250��5}      
�������$��22(�5�      $��40��5�      $��Center=�5�      $
��Left=�5�      $��5q�5�      $��1��5�      �� 5�      -   5        
 ��Name$

 lo01��5�      $��Right=�5�      $��Center=�6*   $��1��6E   $��
0,23,41,29q�6U   �� 5�      .F�5�      .  (MahApps.Metro.IconPacks.PackIconMaterial  
�������E AControlzEx, Version=3.0.2.4, Culture=neutral, PublicKeyToken=null�  �ControlzEx.PackIconBase`1[[MahApps.Metro.IconPacks.PackIconMaterialKind, MahApps.Metro.IconPacks.Material, Version=2.3.0.4, Culture=neutral, PublicKeyToken=null]]   Kind$ Logout=�6>   $��Right=�6L   $	��Top=�5�      $��	0,11,-2,0q�6(   $��12��6;   $��12��6F   5�      �� 6#   $� ��6'   �� 62   -   5         ��Name$	 mar��5�   <   .�6b   �� $�Logout��6f   5�   %   61   �� 5�      $��1��6   $��1��5�      $��10q�5�      ��5�      �� *CurrentView+5�      5�      5�      