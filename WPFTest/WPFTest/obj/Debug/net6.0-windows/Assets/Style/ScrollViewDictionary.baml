   M S B A M L   `   `   `  ����W  SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   MyScrollViewer  �� 
TargetType �Name � ColumnDefinitions � RowDefinitions ��Name ��Name �� CanContentScroll �� CanHorizontallyScroll �� CanVerticallyScroll	 ��Name4    .System.Windows.Automation.AutomationProperties
    AutomationId � Cursor �� ScrollableHeight � Maximum � Minimum* �� #ComputedVerticalScrollBarVisibility �� ViewportHeight �� ViewportSize  MyScrollBarStyle � Value �� Mode �� RelativeSource �� ScrollableWidth �� Orientation, �� %ComputedHorizontalScrollBarVisibility �� ViewportWidth  ScrollBarDisabledBackground �� Color  VerticalScrollBarPageButton �� 
TargetType �� Property �� Value  ScrollBarThumb �� RadiusX �� RadiusY �� Triggers  P� Property! P� Value" �� 
TargetName ! HorizontalScrollBarPageButton# J� SnapsToDevicePixels$ ]�Name% J� IsMouseOver& ]� DecreaseRepeatButton' �� PageUpCommand( ]� IncreaseRepeatButton) �� PageDownCommand* ]� Thumb+ �� Triggers, �� PageLeftCommand- �� PageRightCommand�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      :x,http://schemas.microsoft.com/winfx/2006/xaml      5      %�  &	        &	 �    &	     &	 i    &	     &	 c    7  7  7  7  7  7  7  7  �� 5      "  ��6-   .R�5   
   � $
 Grid��6   #��z��6    5      �� 5      $��* �6#   �� 5	      $
��Auto �6#    5      �� 5      $��* �6    �� 5      $
��Auto �6    .+�5      �� $ Corner��6   $��1��6(   
�������$��1��6E   �� 5      $! PART_ScrollContentPresenter��6%   # z��6J   $ False��6�   $ False��6�   #��z��6�   #��z��6�   $��0��6  #��z��6"  $��0��6E  �� 5      $	 PART_VerticalScrollBar��6   $
 VerticalScrollBar��68   $ Arrow��6n   $��1��6}   # z 6�   $ 0Q�6�   $��0��6�   #y�z 6�   # z 6u  #���  6�   6  �� *VerticalOffset+$ OneWay=� �� *TemplatedParent+6�  �� 5      $	 PART_HorizontalScrollBar��6   $
 HorizontalScrollBar��6:   $ Arrow��6r   $��0��6�   # z 6�   $ 0Q�6�   $ 
Horizontal=�6�   $��1��6�   #y�z 6�   # z 6�  #���  6�   64  �� *HorizontalOffset+$ OneWay=� �� *TemplatedParent+6�  5      5      �� 5      $ #F4F4F4��6:   �� 5      " ��60   .�5   
   ��  �@�OverridesDefaultStyle$
 true��62   �� 5   
    � ��
 ���� 6'   �� 5   
    � |�$ false��6&   �� 5   
    � ��$ false��6&   �� 5   
    � �� 5      �� 5      "  ��6"   .R�5       �� #��z��6    #��z��6D   #��z��6f   5!      5#      5$      �� 5'      " n�6#   .�5(   
   ��  �@�OverridesDefaultStyle$
 true��62   �� 5)   
    � ��$ false��6&   �� 5*   
    � �� 5+      �� 5,      "  n�6"   .R�5.      �� $��	thumbRect��6    ���#686868$ 3��6@   $ 3��6L    50      P� 51        �@J�IsMouseOver$
! True��69   . �52      �� $" 	thumbRect��6L    � ��
 ��d�53      55      57      58      �� 59      " ��62   .�5:   
   ��  �@�OverridesDefaultStyle$
 true��62   �� 5;   
    � ��
 ���� 6'   �� 5<   
    � |�$ false��6&   �� 5=   
    � ��$ false��6&   �� 5>   
    � �� 5?      �� 5@      "  ��6"   .R�5A      �� #��z��6    #��z��6D   #��z��6f   5B      5D      5E      �� 5G      " ��6%   .�5H   
   ��  � ��
 �����6'   �� 5I   
    �@��IsPressAndHoldEnabled$ false��69   �� 5J   
    �@��IsFlicksEnabled$ false��63   �� 5L   
    � ��$ 8��6"   �� 5M   
    � ��$ 6��6%   �� 5N   
    � �� 5O      �� 5P      "  ��6"   .R�5R      � $ Bg��6   ���#DDDDDD$
# true��6<   $��8��6W    5S      �� 5T      .+�5V      ]� $$ 
PART_Track��6    $
��true��64   #{�z% 6O   & 5W      �� 5X   "   #��Z' 6/   8��  6\   ( 5Z      �� 5[   "   #��Z) 6/   8�� 6^   * 5]      n� 5^   "   8�� 6(   5`      5a       5b      P� 5c        � {�$! false��67   . �5d      �� $" Bg��6;   8   � ��6K   5e      5g      5i      + 5j   
   P� 5k        �@��Orientation$! 
Horizontal=�6-   . �5l      ��  � ��$
 Auto��6*   �� 5m       � ��$ 0��6-   �� 5n       � ��$ 6��6+   �� 5o       � ��$ 6��6.   �� 5p       � ��
 �����6/   �� 5q       � �� 5r      �� 5s      "  ��6*   .R�5t      � $ Bg��6#   
���  ��$
# true��6@    5u   "   �� 5v   &   .+�5x   "   ]� $$ 
PART_Track��6(   #{�z% 6=   & 5y   &   �� 5z   *   #��Z, 67   8�� 6f   ( 5|   &   �� 5}   *   #��Z- 67   8�� 6g   * 5   &   n� 5�   *   8�� 60   5�   #   5�       5�      P� 5�   "     � {�$! false��6?   . �5�   &   �� $" Bg��6C   8   � ��6S   5�   #   5�      5�      5�      5�      5�      