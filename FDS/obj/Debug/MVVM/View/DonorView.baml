   M S B A M L   `   `   `  ����>  :FDS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:FDS.MVVM.ViewFDS.MVVM.View  5          FDS.MVVM.View.DonorView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:FDS.MVVM.View     5      .��5	      �� .+�5
   
   �� $��Donor��6   
�������$��20(�5      $
��Left=�5      $��0,0,0,10q�5      �� 5   
     �� Orientation$  
Horizontal=�6   .+�5      �� $	��700��6   $��2q�5      ��5      �� 5      .��5      �  � Color$ #7be9f6��6'    � Offset$	 0.0Q�67   � 5      $ #f083da��6'   $ 1Q�67   5      ._�5      � $	��101��6   $��10,10,10,10q�5      .+�5      �� -   5        $��	donname01��5      $�� Name��5      $	��top=�5      $
��Left=�5      $��0,0,0,0q�5      �� 5      -   5        $��dname01��5       �� AcceptsReturn .    
ModernForm#��[  5#      $
��Left=�5$      $	��Top=�5%      $��60,0,0,0q�5&      $	��200��5'      ��5"      �� *Adddonor.DonorName+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5'      �� 5)      -   5        $��dname02��5)       . $y�	Collapsed=�5,      #��[  5.      $
��Left=�5/      $	��Top=�50      $��60,0,0,0q�51      $	��200��52      ��5-      �� *Selectdon.DonorName+$ TwoWay=�$ PropertyChanged=�52      �� 54      -   5        $��donad01��54      $��Address��55      $	��top=�56      $
��Left=�57      $��0,44,0,0q�58      �� 59      -   5        $��dad01��59       . #��[  5<      $
��Left=�5=      $��Bottom=�5>      $��	60,0,0,21q�5?      $	��200��5@      ��5;      �� *Adddonor.DonorAdress+5@      �� 5B      -   5        $��dad02��5B      $y�	Collapsed=�5C       . #��[  5F      $
��Left=�5G      $��Bottom=�5H      $��	60,0,0,21q�5I      $	��200��5J      ��5E      �� *Selectdon.DonorAdress+5J      �� 5L      -   5        $��donno01��5L      $��	Cellphone��5M      $	��top=�5N      $
��Left=�5O      $��	278,4,0,0q�5P      �� 5Q      -   5        $��dno01��5Q      #��[  5U      $
��Left=�5V      $	��Top=�5W      $��	355,0,0,0q�5X      $	��200��5Y      ��5S      �� *Adddonor.DonorNumber+5Y      �� 5[      -	   5        $��dno02��5[      $y�	Collapsed=�5\      #��[  5_      $
��Left=�5`      $	��Top=�5a      $��	355,0,0,0q�5b      $	��200��5c      ��5^      �� *Selectdon.DonorNumber+5c      �� 5e      -
   5        $��	docnicd01��5e      $
��CNIC��5f      $	��top=�5g      $
��Left=�5h      $��
278,50,0,0q�5i      �� 5j      -   5        $��dcnic01��5j      #��[  5m      $
��Left=�5n      $	��Top=�5o       �� 	MaxLength$ 13��5p      $��
355,50,0,0q�5q      $	��200��5r      ��5k      �� *Adddonor.DonorCNIC+5r      �� 5t      -   5        $��dcnic02��5t      $y�	Collapsed=�5u      $ 13��5v      #��[  5y      $
��Left=�5z      $	��Top=�5{      $��
355,50,0,0q�5|      $	��200��5}      ��5x      �� *Selectdon.DonorCNIC+5}      �� 5      -   5        $��
donerbtn01��5      $��90��5�      $��Submit��5�      $��40��5�      $��
557,0,0,20q�5�      ��5�      �� *AddDonCommand+5�      �� 5�      -   5        $��
donerbtn02��5�      $y�	Collapsed=�5�      $��90��5�      $��Update��5�      $��40��5�      $��
557,0,0,20q�5�      ��5�      �� *UpdateDonCommand+5�      5�      5�      5�      �� 5�   
   $  
Horizontal=�6   .+�5�      �� $	��700��6   $��2q�5�      ��5�      �� 5�      .��5�      � $ #7be9f6��6'   $	 0.0Q�67   � 5�      $ #f083da��6'   $ 1Q�67   5�      ._�5�      � .+�5�      �� 
������ ��. $
��Left=�5�      $��Bottom=�5�      $	��690��6+   $	��276��67   $��5,0,0,0q�5�   3   ��6   �� *
DonorrLoad+ �� View 5�      �� 5�      .P�5�   "   �� $
��Name��61    �� DisplayMemberBinding 6?   �� *	DonorName+�� 5�   "   $��Address��61    6B   �� *DonorAdress+�� 5�   "   $��	Cellphone��61    6D   �� *DonorNumber+	 �� StringFormat$	 0���� 5�   "   $
��CNIC��61    6?   �� *	DonorCNIC+�� 5�   "   $��Action��61   
 �� CellTemplate
 5�   &   �� 5�   *   .R�5�   .   �� $  
Horizontal=�69   $��4q�6R   .+�5�   2   ��  ��Name$ 	BtnUpdate��69   -   5        $��Update��5�   L   $��90��5�      $��30��5�      $��10,0,0,0q�5�      ��5�      �� *DataContext.UpdateCommand+ �� RelativeSource ��  �� AncestorType" ����6�   �� �� 5�   2   $ 	BtnDelete��69   $��Delete��6L   $��90��5�      $��30��5�      $��10,0,0,0q�5�      ��5�      �� *DataContext.DeleteCommand+ �� " ����6�   �� 5�   /   5�   +   5�   #   5�      5�      5�      5�      5�      5�      5�      