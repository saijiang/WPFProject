   M S B A M L   `   `   `  ����B  >WPFTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WPFTest.ViewsWPFTest.Views  5   	   +clr-namespace:WPFTest.BaseWPFTest.Base  5   	       WPFTest.Views.LoginWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WPFTest.Views     5   	   +baseclr-namespace:WPFTest.Base     5   	   
������ $��Microsoft YaHei)�5   
   $��
ExtraLight"�6'     � 
ResizeMode$  NoResize=�6?    � WindowStyle$
 None=�5   	    � AllowsTransparency$
 True��6    � WindowStartupLocation$ CenterScreen=�66    � SizeToContent$ WidthAndHeight=�5       � Title$ 系统登陆��5   	    � 	Resources 5       �� 
TargetType   CloseButtonTemplate  iconfont �� Triggers	 P� Property
 P� Value �� 
TargetName �� Property �� Value �� 
TargetType  PasswordStyle ��Name J� SnapsToDevicePixels �� CornerRadius � ColumnDefinitions ��Name �� Value �� Binding �� Path��%  &	        7  &	 4    7  �� 5   
   " ��6   .R�5      � $
��back��6,   
������ .+�5      �� $	����6   8��  $��14(�6S   $��Center=�6a   $��Center=�6|   6�   5       5      P� 5      	 �@J�IsMouseOver$

 True��61   . �5      �� $
 back��6@    � �� �#ddd6T   5      5!      �� 5'   
   " G�6   .�5(      ��  � ��
 �  ��69   �� 5)       � ��$ 35��6'   64   �� 5*       � �� 5+      �� 5,      " G�6&   .R�5/      �� $ border��50      #��z��51      #��z��52      $
 True��53      $ 5��54      ._�58      �  59   "   �� 5:   &   $��40 �67   6D   �� 5;   &   69   .+�5>   "   �� ���#ddd$��0,0,1,0q�6<   6X   �� 5?   "   $��markText��5D   %   $��请输入密码��5@   %   $��1��5A   %   $��Center=�5B   %   ���#bbb$y�	Collapsed=�5E   %   $��12(�5F   %   $	��2,0q�5G   %   5H   (   �� 5I   "   $	����6,   8��  $��14(�5K   ,   $��Center=�5L   ,   $��Center=�5M   ,   ���#ddd5O   /   �� 5P   "   $ PART_ContentHost��5Q   %   $|�False��5R   %   $��Hidden=�5S   %   $��Hidden=�5T   %   $��1��5U   %   $��Center=�5V   %   $��20��5W   %   5X   (   5Y      5[       5]      P� 5^      	 � {�$
 False��6;   . �5_   "   �� $ border��6<    �@J�Opacity$
 0.56Q�6P   6_   5`      P� 5a      	 �@J�IsMouseOver$

 True��6=   . �5b   "   �� $ border��6@    � �� �#ff7eed6f   5c      P� 5d      	 �@J�IsKeyboardFocused$

 True��6C   . �5e   "   �� $ border��6@    � �� �#23edc26f   5f      �� 5g      $  ��6V    6*   �� $ userModel.Password�.a�5h   "   �� $ markText��6?    � y�$ Visible=�6U   6g   5i      5n      5p      5q      5u       � Triggers 5x      :� 5y   
    :� RoutedEvent$ Window.Loaded��6   .[�5{      �� .��5|      �� .��5}      W� 	 W� To 05~       g� Duration$ 0:0:1D�6     �� 
TargetName$ 	rightView��5       �� TargetProperty$ X�5�      5�      5�      5�      5�      .��5�      � -   5        $	��740��5�      $��5q�6   .+�5�   
   �� ���#f7f9fa$	��0,6q�6&   $��Right=�63   $	��330��6O   $��0q�6[   $ 5��6o   z�5�      T� 5�      -   5        	rightView�� T� X$
 -330Q�5�   8   6C   ._�5�      � $��	80,0,10,0q�6    � RowDefinitions 5�      �� 5�      $��30 �6$   62   �� 5�      $
��auto �6$   64   �� 5�      6&   �� 5�      6&   �� 5�      6&   �� 5�      6&   �� 5�      6&   �� 5�      $
��auto �6$   $��30��62   6C   .+�5�      �� $��Right=�5�      $��40��5�      $��30��6    #��[  5�      $$��绑定的事件传递的参数��5�      ��5�      �� *CloseCommand+5�      �� 5�      $��1��6   .+�5�      �� $��我是标题��6    $��20(�6-   $
��Bold"�6;   6P   �� 5�      $��我是副标题��6    6/   5�      �� 5�      $��3��6d     UserNameTextBoxStyle#��[ 6r   ��6   �� *userModel.UserName+ �� UpdateSourceTrigger$ PropertyChanged=�6�   G� 5�      $  WPFTest.Base.PasswordBoxHelper    Attach$
  true��5�      $y�	Collapsed=�6:   $��4��5�      #��[ 6"   !   Password! 5�      �� *userModel.Password+" �� Mode$" TwoWay=�$ PropertyChanged=�5�   K   �� 5�       
 TxtPwd#��[ 6   $��4��6:   6I   �� 5�      $��记住登陆信息��6   $
��Left=�6,   $��Center=�6G   $��10(�6b   $��5��6p   6   �� 5�      $��Right=�6   $��Center=�68   $��12(�6S   $��5��6a   �� 5�      .�6    忘记密码6&   5�      �� 5�      $��	登   录��6   ���#0076ff$��35��5�      ���#ffffff$��6��5�      ��5�      �� *LoginCommand+��5�      �� # �� RelativeSource# �� $ �� AncestorType
$ Window5�      �� 5�      $
��Wrap=�5�      % �� 
LineHeight$% 23��5�      & �� TextAlignment$& Center=�5�      $��7��5�      
���  ����5�      �� *userModel.ErrorMessage+5�   <   5�      5�      � 5�   
   ' � Points+' �    ��t� �� � �� ��$
��Left=�5�      ��5�      �� 5�      ( j� Stretch$( UniformToFill=�6   ) �� ImageSource$K) Epack://application:,,,/WPFTest;component/Assets/Images/back_Image.png��66   6�   * J� Effect* 5�      3  -System.Windows.Media.Effects.DropShadowEffect  5�      +   Color$+ Black��6#   ,   ShadowDepth$, 5Q�61   -   	Direction$- 6Q�6A   .   
BlurRadius$. 10Q�6O   /   Opacity$	/ 0.8Q�6_   6o   5�      5�      5�      