   M S B A M L   `   `   `  ����?  ;Shop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Shop.SearchNameWndShop.SearchNameWnd  5   	   #    Shop.SearchNameWnd.SearchName   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Shop.SearchNameWnd     5   	      searchTitleByName  � Title#  �   5   	   $	��450��65   $	��400��6B    � 	Resources 5	      ��%    6   .��5      � 
������� � RowDefinitions 5   
   �� 5      $	��43* �6   �� 5      $
��174* �6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� -   5         ��Name$ searchListBox��5      ���	#FFCC9999$��2��6@   $��2��6T   $��0,82,0,0q�6e   $��Hidden=�6w   ��.  ��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   $��5q�6:   .+�5      ��  ��Name$ 	BookImage��6    $	��100��6U   $	��150��6a   ��63   ��  �� Path$ 	imagePath�6p   �� 5      $ Vertical=�6%   $��10,0,0,0q�6<   .+�5      ��  ��Name$ BookName��6(   $��16(�6:   $��0,2,0,0q�6c   
���   �$��DemiBold"�6�   ��6H   �� $
 name�6�   �� 5      $��16(�6(   
���   �$��0,0,0,20q�6f   ��66   �� $ author�6f   �� 5       $ 
Horizontal=�6)   .+�5!   "   �� $��16(�6,   $��Center=�6V   
���������6:   �� $ price�6s   �� 5"   "   $��16(�6,   $
�� BYN��6:   $��Center=�6F   
�������6c   5#      �� 5%      $ 
Horizontal=�6)   .+�5&   "   �� $��16(�6,   $��Количество: ��6:   $��Center=�6N   
���   �6k   �� 5'   "   $��16(�6,   $��Center=�6V   
���������6:   �� $ count�6s   5(      5)      5*      5+      5-      �� 50   
   -   5        	 ��Name$	 searchNameTextBox��50   -   $��29��6H   
 �� TextWrapping$

 Wrap=�6T   $	��Top=�6h   $��18(�6�   $��2��6�   $��
70,29,70,0q�6�   �� 51   
   $
��Left=�6   $��	70,10,0,0q�6/   $
��Wrap=�6B     name_AddForm#���  6V   $	��Top=�6|   $��16(�6�   $��Normal"�6�   $��Segoe UI)�6�   53      55      