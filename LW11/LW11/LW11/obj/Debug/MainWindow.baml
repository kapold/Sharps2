   M S B A M L   `   `   `  ����?  ;LW11, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:LW11LW11  5   	       LW11.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:LW11     5   	     � Title$  Главное окно��5   	    � WindowStartupLocation$ CenterScreen=�5	   	   $	��450��5
   	   $	��800��6   .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      $��4* �6   �� 5      $��1* �6   .+�5   
   �� $��2��6   $��43��6(   $��
44,22,10,0q�64   $
��Wrap=�6H   $��Студенты:��6\   $	��Top=�6m   $��20(�6�   $��Century Gothic)�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	dataTable��5      $��4��6&   $��32,48,32,21q�6:      AutoGenerateColumns .     CanUserAddRows .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6%   	   Header$	 Имя��6K   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 62   �� *Name+6K     5      $
 Auto 6%   $	 Фамилия��6N   
 62   �� *	Surname+6N     5      $
 Auto 6%   $	 Отчество��6Q   
 62   �� *
Patronymic+6Q     5      $
 Auto 6%   $ 	 Специальность��6Q   
 62   �� *
Speciality+6Q     5       $
 Auto 6%   $	 День рождения��6O   
 62   �� *
Birthday+6O     5!      $
 Auto 6%   $	 Курс��6M   
 62   �� *Course+6M     5"      $
 Auto 6%   $	 Группа��6R   
 62   �� *GroupNumber+6R     5#      $
 Auto 6%   $	 Пол��6M   
 62   �� *Gender+6M     5$      $
 Auto 6%   $	 Телефон��6R   
 62   �� *PhoneNumber+6R   4  .System.Windows.Controls.DataGridTemplateColumn  5%      $	 Иозображение��6)   $
 auto 6?      MaxWidth$ 80Q�6L      CellTemplate 5&      �� 5'      .R�5(      � .+�5)   "   �� ��6(   �� *
ImageSrc+6F   5*      5+      5-        5/      $
 Auto 6%   $	 
Город��6S   
 62   �� *Address.City+6S     50      $
 Auto 6%   $	 Индекс��6V   
 62   �� *Address.C_Index+6V     51      $
 Auto 6%   $	 
Улица��6U   
 62   �� *Address.Street+6U     52      $
 Auto 6%   $	 Дом��6S   
 62   �� *Address.Home+6S   55      �� 57   
   -   5        $��Добавить��57      $��32��67   $��1��6C   $��Center=�6P   $��18(�6k   $��Century Gothic)�6y   $��	32,0,32,0q�6�   �� 58   
   -   5        $��Удалить��58      $��32��69   $��1��6E   $��Center=�6R   $��18(�6m   $��Century Gothic)�6{   $��1��6�   $��	32,0,32,0q�6�   �� 59   
   -   5        $��Изменить��59      $��32��6:   $��1��6F   $��Center=�6S   $��18(�6n   $��Century Gothic)�6|   $��2��6�   $��	32,0,32,0q�6�   �� 5:   
   -   5        $��Вывести��5:      $��32��68   $��1��6D   $��Center=�6Q   $��18(�6l   $��Century Gothic)�6z   $��3��6�   $��	32,0,32,0q�6�   �� 5;   
   -   5         ��Name$ 	searchBox��5;      $��3��6A   $��26��6Q   $��	0,17,32,0q�6]    �� TextWrapping$
 Wrap=�6p   $	��Top=�6�   $��Century Gothic)�6�   $��18(�6�   $��Right=�6�   $	��163��6�   �� 5<   
   $��/searchIcon.png��6   $��2��6)   $��26��69   $��0,17,6,0q�6E   $	��Top=�6W   $��Right=�6o   $��26��6�   5>      5@      