   M S B A M L   `   `   `  ����?  ;Shop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Shop.DescriptionWndShop.DescriptionWnd  5   	   )    #Shop.DescriptionWnd.BookDescription   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Shop.DescriptionWnd     5   	     � Title$  BookDescription��5   	   $	��450��6!   $	��600��6.   .��5
      � -   5         �Name$ descriptionGrid��5
      
�������$��0q�6:    � RowDefinitions 5   
   �� 5      �� 5      .+�5   
   �� -   5         ��Name$ descriptionImage��5      $
��Left=�6*   $	��190��6E   $��	32,10,0,0q�6R   $	��Top=�6e   $	��160��6}   �� 5   
   -   5         ��Name$ descriptionBlock��5      $
��Left=�6.   $	��174��6I   $��	32,10,0,0q�6V   $��1��6i   $
��Wrap=�6v   $��Description��6�   $	��Top=�6�   $	��536��6�   $��14(�6�   �� 5   
   -   5        $ descriptionName��5      $
��Left=�6-   $��24��6H   $��
223,10,0,0q�6T   $
��Wrap=�6h   $
��Name��6|   $	��Top=�6�   $
��auto��6�   $��16(�6�   $
��Bold"�6�   �� 5   
   -   5        $ descriptionAuthor��5      $
��Left=�60   $��29��6K   $��
223,34,0,0q�6W   $
��Wrap=�6k   $��Author��6   $	��Top=�6�   $
��auto��6�   $��16(�6�   �� 5   
   -   5        $ descriptionGenre��5      $
��Left=�6.   $��22��6I   $��
224,63,0,0q�6U   $
��Wrap=�6i   $��Genre��6}   $	��Top=�6�   $
��auto��6�   $��14(�6�   �� 5   
   $
��Left=�6   $��
226,99,0,0q�6/   $
��Wrap=�6C   $��
Цена: ��6W   $	��Top=�6e   $��14(�6}   �� 5   
   $
��Left=�6   $��226,123,0,0q�6/   $
��Wrap=�6D   $��Количество: ��6X   $	��Top=�6l   $��14(�6�   �� 5   
   $
��Left=�6   $��226,147,0,0q�6/   $
��Wrap=�6D   $��Рейтинг: ��6X   $	��Top=�6i   $��14(�6�   �� 5   
   $
��Left=�6   $��226,171,0,0q�6/   $
��Wrap=�6D   $��Год издания: ��6X   $	��Top=�6m   $��14(�6�   �� 5   
   -   5        $ 	priceDesc��5      $
��Left=�6'   $��
333,99,0,0q�6B   $
��Wrap=�6V   $��price��6j   $	��Top=�6w   $��14(�6�   �� 5   
   -   5        $ 	countDesc��5      $
��Left=�6'   $��333,123,0,0q�6B   $
��Wrap=�6W   $��count��6k   $	��Top=�6x   $��14(�6�   �� 5   
   -	   5        $ 
ratingDesc��5      $
��Left=�6(   $��333,147,0,0q�6C   $
��Wrap=�6X   $��rating��6l   $	��Top=�6z   $��14(�6�   �� 5   
   -
   5        $ yearDesc��5      $
��Left=�6&   $��333,171,0,0q�6A   $
��Wrap=�6V   $
��year��6j   $	��Top=�6v   $��14(�6�   5      5!      