   M S B A M L   `   `   `  ����>  :FDS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:FDS.MVVM.ViewFDS.MVVM.View  5          FDS.MVVM.View.UserView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:FDS.MVVM.View     5      
������ .��5      ��   �� Orientation$  
Horizontal=�6   .+�5   
   �� ��5      �� 5      .��5      �  � Color$ #7be9f6��6#    � Offset$	 0.0Q�63   � 5      $ #f083da��6#   $ 1Q�63   5      ._�5      �� 
������ $
��Left=�5      $��Stretch=�5      $	��798��61   .@�5      �� -   5         ��Name$	 New��5      
������ $	��New��5      
���   �$��14(�5       $��Center=�5!      $
��Left=�5"      $��0,0,0,0q�5#      $��SemiBold"�5$      $��	helvetica)�5%      $	��100��5&      $��50��5'      $��0q�5(      ��6   Z� .��5+      �  � ColumnDefinitions 5,      �� 5-      $	��43* �6/   �� 5.      $
��230* �6/   �� 5/      $
��525* �6/    � RowDefinitions 51      �� 52      $	��67* �6,   �� 53      $	��61* �6,   .+�55      �� -   5         ��Name$ 	FullName0��55       
�������$��	Full Name��56      $��Center=�57      $
��Left=�58      $��38,18,0,160q�59      $��0��5:      $��2��6   �� 5<      -   5         ��Name$
 FN01��5@      $	��250��5<   "   $��40��5A      $��Center=�5B      $
��Left=�5C      $��10,38,0,128q�5D         
ModernForm#��[  5E      $��2��61   ��5>      �� *NewUser.FullName+5E   1   �� 5F      -   5        $ UserName��5F       
�������$��Username��5G      $��Center=�5H      $��Center=�5I      $��34,19,415,161q�5J      $��2��5K       J� RenderTransformOrigin$ 0.444,0.448&�6   �� 5M      -   5        $
 UN01��5N      $	��250��5M   "   $��40��5P      $��Center=�5Q      $��Center=�5R      $��6,38,269,128q�5S      #��[  5T      $��2��61   ��5O      �� *NewUser.Username+5T   1   �� 5U      -   5        $ Email��5U       
�������$��Email��5V      $��Center=�5W      $
��Left=�5X      $��
38,84,0,96q�5Y      $��0��5Z      $ 0.444,0.448&�6   $��2��6A   �� 5\      -   5        $	 E01��5]      $	��250��5\   "   $��40��5a      $��Center=�5b      $��Center=�5c      $��11,102,12,64q�5d      #��[  5e      $��2��61   ��5^      �� *NewUser.Email+5e   1   �� 5f      -   5        $ Password��5f       
�������$��Password��5h      $��Center=�5i      $��Center=�5j      $��33,86,422,94q�5k      $��2��5l      $ 0.444,0.448&�6   �� 5n      -	   5        $	 P01��5p      $	��250��5n   "   $��40��5q      $��Center=�5r      $��Center=�5s      $��6,102,269,64q�5t      #��[  5u      $��2��61   ��5o      �� *NewUser.Password+5u   1   �� 5v      -
   5        $ 	CellPhone��5v       
�������$��	Cellphone��5w      $��Center=�5x      $��Center=�5y      $��38,148,161,30q�5z      $��0��5{      $ 0.444,0.448&�6   $��2��6A   �� 5}      -   5        $
 CP01��5      	 �� 	MaxLength$	 11��5�      $��Center=�5�      $��Center=�5�      $��11,170,12,184q�5�      #��[  5�      $ 0.492,0.475&�5�      $��2��5�      $��2��6*   ��5~      �� *NewUser.Cellphone+5�   *   �� 5�      -   5        $ Address��5�       
�������$��Address��5�      $��Center=�5�      $��Center=�5�      $��33,148,430,30q�5�      $��2��5�      $ 0.444,0.448&�6   �� 5�      -   5        $	 A01��5�      $��Center=�5�      $��Center=�5�      $��27,172,291,0q�5�      
 �� TextWrapping$

 Wrap=�5�       �� AcceptsReturn . " �� VerticalScrollBarVisibility$ Visible=�5�      #��[  5�      $��2��61   ��5�      �� *NewUser.Address+5�   1   �� 5�      -   5        $
 Role��5�       
�������$
��Role��5�      $��Center=�5�      $��Center=�5�      $��38,12,197,148q�5�      $��0��5�      $ 0.444,0.448&�6   $��1��6A   $��2��6N   �� 5�      -   5         ��Name$ Role1��5�   #   $��39,40,34,118q�5�      $��Center=�5�      $��Center=�5�      $	��200��5�      $��30��5�      
������ $��1��5�   &   ��. $��2��5�   2    �� SelectedIndex 5�      �� *NewUser.Role+.@�5�      �� -   5         ��Name$ admin��5�   +   $��Administrator��6<   �� 5�      -   5        $ employee��5�   +   $��Employee��6?   5�      �� 5�      -   5        $��btnsb01��5�      $��Register��5�   !   $	��167��5�      $��34��5�      $��Center=�5�      $��Center=�5�      
�������$��36,35,322,118q�5�      $��0q�5�      $��Yu Gothic UI Semibold)�5�      $ 0.5,0.5&�5�      $��1��5�      $��2��6'   ��5�      �� *AddUserCommand+5�   '   5�      5�      �� 5�      -   5        $
 List��5�      $��User's List��5�      
���   �
������ $��14(�5�      $	��Top=�5�      $
��Left=�5�      $��0,0,0,0q�5�      $��SemiBold"�5�      $��	helvetica)�5�      $	��100��5�      $��50��5�      $��0q�5�      ��6   Z� .��5�      �  5�      �� 5�      $	��39* �6/   �� 5�      $
��361* �6/   .+�5�      �� -   5         ��Name$ Userlist��5�   E   $
��Left=�6W   $��0,4,0,16q�5�      $	��700��5�      $��2��6   ��5�   #   �� *	FirstUser+ �� View 5�      �� 5�   "   .P�5�   &   �� $��Username��65    �� DisplayMemberBinding 6G   �� *
Username+�� 5�   &   $��Password��65    6G   �� *
Password+�� 5�   &   $��Email��65    6D   �� *Email+�� 5�   &   $��	Full Name��65    6H   �� *
FullName+�� 5�   &   $��Address��65    6F   �� *	Address+�� 5�   &   $��	Cellphone��65    6H   �� *	Cellphone+�� 5�   &   $��Action��65    �� CellTemplate 5�   *   �� 5�   .   .R�5�   2   �� $  
Horizontal=�6=   $��4q�6V   .+�5�   6   ��  ��Name$ 	BtnUpdate��6=   $��Update��6P   $��90��5�      $��30��5�      $��10,0,0,0q�5�      ��5�      �� *DataContext.UpdateCommand+ �� RelativeSource ��  �� AncestorType" ����6�   �� �� 5�   6   $ 	BtnDelete��6=   $��Delete��6P   $��90��5�      $��30��5�      $��10,0,0,0q�5�      ��5�      �� *DataContext.DeleteCommand+ �� " ����6�   �� 5�   3   5�   /   5�   '   5�   #   5�      5�      5�      �� 5�      -   5        $ Update01��5�      $��User Update��5�      
���   �
������ $��14(�5�      $��Center=�5�      $
��Left=�5�      $��0,0,0,0q�5�      $��SemiBold"�5�      $��	helvetica)�5      $	��100��5     $��50��5     $��0q�5     ��6   Z� .��5     � $ 0.494,0.522&�6    5     �� 5     $��0* �6/   �� 5     $��0* �6/   �� 5	     $��3* �6/   �� 5
     $	��85* �6/   �� 5     $��0* �6/    5     �� 5     $	��67* �6,   �� 5     $	��61* �6,   .+�5     �� -   5        $ 
FullName01��5      $��	Full Name��5     $��Center=�5     $
��Left=�5     $��
0,20,0,161q�5     $��3��5     $��24��6   $��72��6)   �� 5     -   5        $��UFN02��5  "   $	��250��5  "   $��40��5     $��Center=�5     $
��Left=�5     $��
1,38,0,127q�5     #��[  5      $��4��61   ��5     �� *SelectedUser.FullName+5   1   �� 5!     -   5        $ 
UserName01��5!      $��Username��5"     $��Center=�5#     $��Center=�5$     $��307,20,386,161q�5%     $��3��5&     $ 0.444,0.448&�6   $��24��6A   $��72��6M   �� 5(     -   5        $��UUN02��5)  "   $	��250��5(  "    �� 
IsReadOnly .  � ToolTip$ Can't Change Username��5,     $��40��5-     $��Center=�5.     $��Center=�5/     $��279,38,236,127q�50     #��[  51     $��3��61   ��5*     �� *SelectedUser.Username+51  1   �� 53     -   5        $ Email01��53      $��Email��54     $��Center=�55     $
��Left=�56     $��	3,84,0,97q�57     $��3��58     $ 0.444,0.448&�6   $��24��6A   $��62��6M   �� 5:     -   5        $	 E02��5<     $	��250��5:  "   $��40��5=     $��Center=�5>     $��Center=�5?     $��3,102,539,63q�5@     #��[  5A     $��1��61   $��3��6A   ��5;     �� *SelectedUser.Email+5A  A   �� 5B     -   5        $ 
Password01��5B      $��Password��5C     $��Center=�5D     $��Center=�5E     $��309,86,388,95q�5F     $��3��5G     $ 0.444,0.448&�6   $��24��6A   $��68��6M   �� 5I     -   5        $	 P02��5K     $	��250��5I  "   $��40��5L     $��Center=�5M     $��Center=�5N     $��279,102,236,63q�5O     #��[  5P     $��3��61   ��5J     �� *SelectedUser.Password+5P  1   �� 5Q     -   5        $ CellPhone01��5Q      $��	Cellphone��5R     $��Center=�5S     $��Center=�5T     $��5,150,688,31q�5U     $��3��5V     $ 0.444,0.448&�6   $��24��6A   $��72��6M   �� 5X     -   5        $��UCP02��5Y  "   $	��250��5X  "   $	 11��5[     $��40��5]     $��Center=�5^     $��Center=�5_     $��3,169,539,183q�5`     #��[  5a     $ 0.492,0.475&�61   $��2��6U   $��1��6f   $��3��6v   ��5Z     �� *SelectedUser.Cellphone+5a  v   �� 5b     -    5        $ 	Address01��5b      $��Address��5c     $��Center=�5d     $��Center=�5e     $��311,150,394,31q�5f     $��3��5g     $ 0.444,0.448&�6   $��24��6A   $��60��6M   �� 5i     -!   5        $��UAd02��5j     $��Center=�5l     $��Center=�5m     $��307,174,258,183q�5n     $

 Wrap=�5o      . $ Visible=�5q     #��[  5r     $��3��61   $��35��6A   $	��200��6M   $��2��6Y   ��5k     �� *SelectedUser.Address+5r  Y   �� 5s     -"   5        $ Role01��5s      $
��Role��5t     $��Center=�5u     $��Center=�5v     $��-79,13,638,150q�5w     $��3��5x     $ 0.444,0.448&�6   $��1��6A   $��24��6N   $��36��6Z   �� 5z     -#   5        $��URCOM02��5{     $��-11,39,544,118q�5|     $��Center=�5}     $��Center=�5~     $	��200��5     $��30��5�     
������ $��1��5�  1   ��. $��3��5�  2    5�     �� *SelectedUser.Role+.@�5�     �� -$   5        $ Admin01��5�  +   $��Administrator��6>   �� 5�     -%   5        $ 
Employee01��5�  +   $��Employee��6?   5�     �� 5�     -&   5        $ 
UpdateUser��5�  !   $��Update��65   $	��166��5�     $��34��5�     $��Center=�5�     $��Center=�5�     
�������$��322,41,277,112q�5�     $��0q�6&   $��Yu Gothic UI Semibold)�6:   $ 0.5,0.5&�6]   $��1��6}   $��3��6�   ��5�     �� *UpdateUserCommand+5�  �   5�     5�     5�     5�     5�     5�     