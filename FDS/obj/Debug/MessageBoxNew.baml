   M S B A M L   `   `   `  ����>  :FDS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:FDSFDS  5   	       FDS.MessageBoxNew   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:FDS     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  MessageBoxNew��5   	   $	��220��5	   
   $	��500��5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	   
������� � 
ResizeMode$ 	CanResize=�5   	    � Topmost .  � ShowInTaskbar .     MaterialDesignBody#���   5   	   $��Regular"�5   	   $��10(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignFont#���  5   	   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��197* �6   �� 5      $
��295* �6   	 � RowDefinitions	 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5!   
   #  MaterialDesignThemes.Wpf.Card  -   5        
  Name$
 
cardHeader��5!      $��0��5"      $��10q�5#      $��0q�5$      +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth5=�5%        PrimaryHueDarkBrush#���  5&       ! PrimaryHueDarkForegroundBrush#���  5'      $y�Visible=�5(      $��2��5)      .��5*      �� .+�5+      �� -   5         ��Name$ txtTitle��5+      $��Center=�5,      $��Stretch=�5-         MaterialDesignTitleTextBlock#���  5.      $��20(�5/      Message Title69   50      51      �� 52   
   $��Right=�6   $��0,5,5,0q�53      $	��Top=�54      $��1��55      .+�56      �� -   5         ��Name$ btnClose��56      $��35��58      $��35��59      
�������#���  5;       * &MaterialDesignFloatingActionDarkButton#��[ 5<      .��5=      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6*   5>      5?      � 5@   
   $��1��6   $��2��5A      .+�5B      � $��20q�6   	 5C      �� 5D      $
��auto �6$   �� 5E      $
��auto �6$   �� 5F      $��* �6$   .+�5I      � $��0��6   	 5J      �� 5K      $
��auto �6(   �� 5L      $��* �6(   .+�5O      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffects 5P      ;  5MaterialDesignThemes.Wpf.Transitions.TransitionEffect  5Q         Kind$ FadeIn=�6>     5R      $ SlideInFromBottom=�6>   .��5T      �� -   5         ��Name$ 
txtMessage��5T       $��Center=�5U       $��0��5V       $��5q�5W       )  #MaterialDesignThemes.Wpf.HintAssist   Hint$  ��5X       $��18(�5Y       $��Medium"�5Z       $
��auto��5[       $
��auto��5\       5]      5_      � 5`      $��1��6   $��0,20,0,5q�5a       5b      �� 5c      $��* �6+   �� 5d      $
��auto �6+   �� 5e      $
��auto �6+   �� 5f      $��* �6+   .+�5i      �� -   5        $ btnOk��5i      $��1��5k        MaterialDesignRaisedButton#��[ 5l      $��5q�5m      $	��100��5n      $��OK��5o       � ToolTip$ Ok��5p      �� 5q      -   5        $ 	btnCancel��5q      $��2��5s      #��[ 5t      $��5q�5u      $	��100��5v      $��Cancel��5w      $ Cancel��5x      �� 5y      -   5        $ btnYes��5y      $��1��5{      #��[ 5|      $��5q�5}      $	��100��5~      $	��Yes��5      $	 Yes��5�      �� 5�      -   5        $ btnNo��5�      $��2��5�      #��[ 5�      $��5q�5�      $	��100��5�      $��No��5�      $ No��5�      5�      5�      5�      5�      5�      