   M S B A M L   `   `   `  ����B  >WPFTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WPFTest.ViewsWPFTest.Views  5   	   +clr-namespace:WPFTest.BaseWPFTest.Base  5   	       WPFTest.Views.LoginWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WPFTest.Views     5   	   +baseclr-namespace:WPFTest.Base     5   	   
������ $��Microsoft YaHei)�5   
   $��
ExtraLight"�6'     � 
ResizeMode$  NoResize=�6?    � WindowStyle$
 None=�5   	    � AllowsTransparency$
 True��6    � WindowStartupLocation$ CenterScreen=�66    � SizeToContent$ WidthAndHeight=�5       � Title$ 系统登陆��5   	    � 	Resources 5       �� 
TargetType   CloseButtonTemplate  iconfont �� Triggers	 P� Property
 P� Value �� 
TargetName �� Property �� Value �� 
TargetType  PasswordStyle ��Name J� SnapsToDevicePixels �� CornerRadius � ColumnDefinitions ��Name �� Value �� Binding �� Path��%  &	        7  &	 4    7  �� 5   
   " ��6   .R�5      � $
��back��6,   
������ .+�5      �� $	����6   8��  $��14(�6S   $��Center=�6a   $��Center=�6|   6�   5       5      P� 5      	 �@J�IsMouseOver$

 True��61   . �5      �� $
 back��6@    � �� �#ddd6T   5      5       �� 5&   
   " G�6   .�5'      ��  � ��
 �  ��69   �� 5(       � ��$ 35��6'   64   �� 5)       � �� 5*      �� 5+      " G�6&   .R�5.      �� $ border��5/      #��z��50      #��z��51      $
 True��52      $ 5��53      ._�57      �  58   "   �� 59   &   $��40 �67   6D   �� 5:   &   69   .+�5=   "   �� ���#ddd$��0,0,1,0q�6<   6X   �� 5>   "   $��markText��5C   %   $��请输入密码��5?   %   $��1��5@   %   $��Center=�5A   %   ���#bbb$y�	Collapsed=�5D   %   $��12(�5E   %   $	��2,0q�5F   %   5G   (   �� 5H   "   $	����6,   8��  $��14(�5J   ,   $��Center=�5K   ,   $��Center=�5L   ,   ���#ddd5N   /   �� 5O   "   $ PART_ContentHost��5P   %   $|�False��5Q   %   $��Hidden=�5R   %   $��Hidden=�5S   %   $��1��5T   %   $��Center=�5U   %   $��20��5V   %   5W   (   5X      5Z       5\      P� 5]      	 � {�$
 False��6;   . �5^   "   �� $ border��6<    �@J�Opacity$
 0.56Q�6P   6_   5_      P� 5`      	 �@J�IsMouseOver$

 True��6=   . �5a   "   �� $ border��6@    � �� �#ff7eed6f   5b      P� 5c      	 �@J�IsKeyboardFocused$

 True��6C   . �5d   "   �� $ border��6@    � �� �#23edc26f   5e      �� 5f      $  ��6V    6*   �� $ userModel.Password�.a�5g   "   �� $ markText��6?    � y�$ Visible=�6U   6g   5h      5m      5o      5p      5t       � Triggers 5w      :� 5x   
    :� RoutedEvent$ Window.Loaded��6   .[�5z      �� .��5{      �� .��5|      W� 	 W� To 05}       g� Duration$ 0:0:1D�6     �� 
TargetName$ 	rightView��5~       �� TargetProperty$ X�5      5�      5�      5�      5�      .��5�      � -   5        $	��740��5�      $��5q�6   .+�5�   
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