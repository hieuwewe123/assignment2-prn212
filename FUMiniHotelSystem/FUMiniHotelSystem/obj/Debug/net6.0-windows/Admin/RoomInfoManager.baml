   M S B A M L   `   `   `  ����L  HFUMiniHotelSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:FUMiniHotelSystem.AdminFUMiniHotelSystem.Admin  5      -    'FUMiniHotelSystem.Admin.RoomInfoManager   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:FUMiniHotelSystem.Admin     5        N� Title$  RoomInfoManager��5	      .��5      � .+�5   
   �� -   5        $
��lvRi��5      $��55,123,64,86q�5       �� View 5      �� 5      .P�5      �� $��
RoomNumber��6%    �� Width$	 100��5   %    �� DisplayMemberBinding 5   %   ��  �� Path$ 
RoomNumber��� 5      $��RoomDetailDescription��6%   $	 130��5   %    5   %   �� $ RoomDetailDescription��� 5      $��RoomMaxCapacity��6%   $	 120��5   %    5   %   �� $ RoomMaxCapacity��� 5      $��RoomType��6%   $	 100��5   %    5   %   �� $ RoomTypeName��� 5      $��
RoomStatus��6%   $	 100��5   %    5   %   �� $ Status��� 5       $��RoomPricePerDay��6%   $	 100��5!   %    5"   %   �� $ RoomPricePerDay�5#      5%      �� 5&   
   -   5        $��	BtnDelete��5&      $��Delete��5'      $
��Left=�5(      $��573,383,0,0q�5)      $	��Top=�5*      $��36��5+      $	��163��5,      
�������$��Kozuka Mincho Pr6N B)�5.      
���   �
�������51      �� 52   
   -   5        $��	BtnUpdate��53      $��Update��52      $
��Left=�54      $��314,383,0,0q�55      $	��Top=�56      $��36��57      $	��163��58      
�������$��Kozuka Mincho Pr6N B)�5:      
���   �
�������5=      �� 5>   
   -   5        $��	BtnInsert��5>      $��Insert��5?      $
��Left=�5@      $��
55,387,0,0q�5A      $	��Top=�5B      $��36��5C      $	��163��5D      
�������$��Kozuka Mincho Pr6N B)�5F      
���   �
�������5I      �� 5J   
   $��Manage RoomInformation��6   $
��Left=�5K      $��55,6,0,0q�5L      $	��Top=�5M      $��43��5N      $��Normal$�5O      $	��257��5P      ���#FFFFFF$��24(�5R      �� 5S   
   -   5        $��tbRoomId��5S      $y�Hidden=�5T      $
��Left=�5U      $��
528,47,0,0q�5V       �� TextWrapping$
 Wrap=�5W      $	��Top=�5X      $	��120��5Y      ��5Z      �� $ RoomId� �� Mode$ OneWay=� � DataContext 5[      ��  �� ElementName$
 lvRi��$ SelectedItem��� 5\   
   -   5        	 ��Name$	 tbSearch��5b      $
��Left=�5\      $��	55,80,0,0q�5]      $
 Wrap=�5^      $	��Top=�5_      $	��163��5`      $��28��5a      5c      �� 5d   
   -   5        
 ��Name$
 	btnSearch��5h      $��Search��5d      $
��Left=�5e      $��
236,80,0,0q�5f      $	��Top=�5g      $��28��5i      $��49��5j      5k      5l      5m      