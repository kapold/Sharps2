   M S B A M L   `   `   `  ����?  ;Shop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ShopShop  5          Shop.RandomBookUC   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      $localclr-namespace:Shop     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $��7* �6   �� 5      $��3* �6   .+�5   
   �� -   5        $ ��Сгенерировать��5   &   $��18(�6>   $��DemiBold"�6L   $��42��6b   $��Center=�6n   $��1��6�   $��	92,0,92,0q�6�   �� 5   
   -   5         ��Name$ randomBookList��5      $	��210��6*   $	��Top=�67   
���������5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   $��5q�6:   .+�5      ��  ��Name$ 	BookImage��6    $	��100��6U   $	��150��6a   ��63   ��  �� Path$ 	imagePath�6p   �� 5      $ Vertical=�6%   $��10,0,0,0q�6<   .+�5      ��  ��Name$ BookName��6(   $��16(�6:   $��0,2,0,0q�6c   
���   �$��DemiBold"�6�   ��6H   �� $
 name�6�   �� 5      $��16(�6(   
���   �$��0,0,0,20q�6f   ��66   �� $ author�6f   �� 5      $ 
Horizontal=�6)   .+�5   "   �� $��16(�6,   $��Center=�6V   
���������6:   �� $ price�6s   �� 5   "   $��16(�6,   $
�� BYN��6:   $��Center=�6F   
�������6c   5      �� 5!      $ 
Horizontal=�6)   .+�5"   "   �� $��16(�6,      countLB#���   6:   $��Center=�6[   
���   �6x   �� 5#   "   $ 
countBlock��6,   $��16(�6@   $��Center=�6j   
���������6N   �� $ count�6�   5$      5%      5&       �� Triggers 5(      �� 5)       �� Value$ 0��6@    �� Binding 6&   �� *count+.a�5*      �� 	 �� 
TargetName$	 
countBlock��6%   
 �� Property
 � �� �� Value
 �  ��6S   5+      5-      5/      50      51      