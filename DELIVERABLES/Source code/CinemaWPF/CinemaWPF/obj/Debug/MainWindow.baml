   M S B A M L   `   `   `  ����  	CinemaWPF    CinemaWPF.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $��Mainform��5   	     � Title$  Phần mềm bán hàng��5   	   $	��700��6#   $
��1000��60    � 
ResizeMode$ NoResize=�6=    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   � $��0��6   .+�5      (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ PrimaryDark=�5      ���#111111$��60��5      $��Stretch=�6%   .��5      ]� .+�5      �� $��Right=�6!    �� Orientation$ 
Horizontal=�68   $	��117��6S   $��40��6_   $��Right=�6k   
������ $	��Top=�5   :   $��0,10,0,0q�6R    � 	Resources 5       �� 
TargetType	 �� Property
 �� Value��%�   'o�       �� 5      " o�6$   .�5   "   �� 	 � ��$
 2 4 2 4q�6;   6M   �� 5   "   	 � ��$
 40��6:   6G   5      5      .+�5      o� -   5        $��Thongbao��5       o� 
IsMainMenu . ���#780000$	��112��6V   .@�5      m� -   5        $��	_Thongbao��5   :   $��Thông báo��6'   
���   �
�������$	��112��6x   $��
20,0,-70,0q�6�    � UseLayoutRounding . $��32��6�   $��Center=�6�   $��16(�6�   $��0q�6�   .@�5    "   m� -   5        $��_XemThongbao��5    B   $��Xem thông báo��6+   
���   �$��13(�6i   
�������6w   m� 5!   "   -   5        $��_Danhdau��5!   N   $-��'Đánh dấu tất cả là đã đọc��6+   
���   �$��13(�6q   
�������6   m� 5"   "   -   5        $��_XoaThongbao��5"   I   $!��Xóa tất cả thông báo��6+   
���   �$��13(�6p   
�������6~   5#      5$      5%      5'      5(      5*      � 5+   
   $��1��6    � ColumnDefinitions 5,      �� 5-      ��5/      �� 50       �� ImageSource$7 1E:\qtdacntt\Dự án\CinemaWPF\Hình\frame 19.png��6    52      �� 53      6#   �� 54      6"   .+�56      � $��1��6   .+�57      �� -   5        $��btn_banhang��57      $
��Left=�6,   $��
218,71,0,0q�6G   $	��Top=�6[   $	��127��6s    � ToolTip$5 /Kích vào để thực hiên phiên bán hàng��6   $	��140��6�   ���	#DD1D1A1A��5:      �� 5;      $8 2E:\qtdacntt\Dự án\CinemaWPF\Hình\BánHàng.png��6%   5=      �� 5>      $
��Left=�6   $��
360,71,0,0q�64   $	��Top=�6H   $	��127��6`   $< 6Kích vào để thực hiện chức năng quản lý��6l   $	��140��6�   ���	#DD1D1A1A��5?      �� 5@      $9 3E:\qtdacntt\Dự án\CinemaWPF\Hình\Quản Lý.png��6%   5B      �� 5C      $
��Left=�6   $��
503,71,0,0q�64   $	��Top=�6H   $	��127��6`   $0 *Kích vào để thực hiện cấu hình��6l   $	��140��6�   ���	#DD1D1A1A��5D      �� 5E      $: 4E:\qtdacntt\Dự án\CinemaWPF\Hình\Cấu Hình.png��6%   5G      �� 5H      -   5        $
��Left=�5H      $��
647,71,0,0q�64   $	��Top=�6H   $	��127��6`   $< 6Kích vào để thoát khỏi giao diện làm việc��6l   $	��140��6�   ���	#DD1D1A1A��5I      �� 5J      $6 0E:\qtdacntt\Dự án\CinemaWPF\Hình\Thoát1.png��6%   5L      5N      5O      �� 5P   
   $
��Left=�6   $	��228��6+   $	��Top=�68   $	��284��6P   $4��.E:\qtdacntt\Dự án\CinemaWPF\Hình\Hình.png��6\   $��
357,96,0,0q�6�   $��1��6�   �� 5Q   
   $
��Left=�6   $	��100��6+   $��	61,26,0,0q�68   $��2��6K   $	��Top=�6\   $	��100��6t   5S      5T      