   M S B A M L   `   `   `  ����>  :FDS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:FDS.MVVM.ViewFDS.MVVM.View  5      !    FDS.MVVM.View.FoodstoreView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:FDS.MVVM.View     5      .��5
      � .+�5   
   �� $��
Food Store��6   
�������$��20(�5      $
��Left=�5      $��0,0,0,10q�5      � 5   
   $��0,35,0,0q�6     � RowDefinitions  5      �� 5      $��4* �6    �� 5      $��6* �6    .+�5      ��  �� CornerRadius$ 10��6   $��2��6'   $	��8,5q�68   ��5      �� 5      .��5      �  � Color$ #7be9f6��6'    � Offset$	 0.0Q�67   � 5      $ #f083da��6'   $ 1Q�67   5      5      � 5      .+�5       �� $
��Left=�6   $��	0,0,0,-15q�68   $	��780��6K   .+�5#      �� $��
Store Name��6   $	��100��5$      $
��Left=�5%      $	��Top=�5&      $��20q�5'      
�������$��12(�5)      $��2��6+   �� 5+      -   5        $��storename01��5+         
ModernForm#��[  5-      $
��Left=�5.      $	��Top=�5/      $��
20,-15,0,0q�50      $	��200��51      ��5,      �� *Fodstore.StoreName+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�51      �� 53      -   5         ��Name$ upstorename01��53      #��[  55      $
��Left=�56      $	��Top=�57      $��
20,-15,0,0q�58      $y�	Collapsed=�59      $	��200��5:      ��54      �� *SelectedFs.StoreName+$ TwoWay=�$ PropertyChanged=�5:      �� 5<      -   5        $ storelocation01��5=       �� TextWrapping$
 Wrap=�5>      #��[  5@      $	��Top=�5A      $��290,-30,198,-140q�5B      $��Center=�5C      ��5?      �� *Fodstore.StoreLocation+$ TwoWay=�$ PropertyChanged=�5C      �� 5F      -   5        $ upstorelocation01��5G      $
 Wrap=�5H      $y�	Collapsed=�5I      #��[  5K      $	��Top=�5L      $��290,-30,198,-140q�5M      $��Center=�5N      ��5J      �� *SelectedFs.StoreLocation+$ TwoWay=�$ PropertyChanged=�5N      �� 5P      $��Store Capicity (KG)��6   $	��107��5Q      $
��Left=�5R      $	��Top=�5S      $��
20,20,0,20q�5T      
�������$��12(�5V      �� 5W      -   5        $��
storecap01��5W       � ToolTip$ Insert in kg��5X      $	��200��5Y      $
��Left=�5Z      $	��Top=�5[      $��
20,-15,0,0q�5\      #��[  5^      ��5]      �� *Fodstore.StoreCapacity+$ TwoWay=�$ PropertyChanged=�5^      �� 5_      -   5        $��upstorecap01��5_      $	��200��5`      $ Insert in kg��5a      $y�	Collapsed=�5b      $
��Left=�5c      $	��Top=�5d      $��
20,-15,0,0q�5e      #��[  5g      ��5f      �� *SelectedFs.StoreCapacity+$ TwoWay=�$ PropertyChanged=�5g      �� 5h      $��Store Location��6   $	��100��5i      $��Center=�5j      $	��Top=�5k      $
��-140q�5l      
�������$��12(�5n      �� 5q      -   5        $��	submitbtn��5r      $��Submit��5q      $��Center=�5s      $��0,-43,-44,0q�5t      $��50��5v      $	��150��5w      $��1��6%   ��5u      �� *
AddCommand+5w   %   �� 5x      -   5        $��	updatebtn��5y      $��Update��5x      $y�	Collapsed=�5z      $��Center=�5{      $��0,-43,-44,0q�5|      $��50��5~      $	��150��5      $��1��6%   ��5}      �� *UpdateFsCommand+5   %   5�      �� 5�      $��Center=�6   	 �� Orientation$	 
Horizontal=�5�      $��Bottom=�5�      $��-11,0,20,-234q�5�      $	��235��64   .+�5�      �� 
������ ��. $
��Left=�5�      $��Bottom=�5�      $	��690��66   $	��219��6B   
 J� RenderTransformOrigin$
 0.5,0.16&�6O   ��5�      �� *fsLoad+ �� View 5�      �� 5�      .P�5�   "   �� $
��Name��61    �� DisplayMemberBinding 6?   �� *	StoreName+�� 5�   "   $��Capacity (KG)��61    6H   �� *StoreCapacity+�� 5�   "   $��Location��61    6C   �� *StoreLocation+�� 5�   "   $��Action��61    �� CellTemplate 5�   &   �� 5�   *   .R�5�   .   �� $	 
Horizontal=�69   $��4q�6R   .+�5�   2   ��  ��Name$ 	BtnUpdate��69   -	   5        $��Update��5�   L   $��90��5�   #   $��25��5�   #   $��10,0,0,0q�5�   #   ��5�   #   �� *DataContext.UpdateCommand+ �� RelativeSource ��  �� AncestorType" ����6�   �� �� 5�   2   $ 	BtnDelete��69   $��Delete��6L   $��90��5�   #   $��25��5�   #   $��10,0,0,0q�5�   #   ��5�   #   �� *DataContext.DeleteCommand+ �� " ����6�   �� 5�   /   5�   +   5�   #   5�      5�      5�      5�      5�      5�      5�      