   M S B A M L   `   `   `  ����@  <notes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:notesnotes  5   	   'clr-namespace:notes.Core
notes.Core  5   	   ;"clr-namespace:notes.MVVM.ViewModelnotes.MVVM.ViewModel  64       notes.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:notes     5   	   .	extentionclr-namespace:notes.Core     5   	   8	viewmodel"clr-namespace:notes.MVVM.ViewModel     64     � Title$  
MainWindow��5	   	   $	��500��6   $	��900��6)    � WindowStyle$
 None=�5
   	   
������  � AllowsTransparency$
 True��5   	    � 
ResizeMode$ 	CanResize=�5   	    � DataContext 5      (  "notes.MVVM.ViewModel.MainViewModel  5   
   .��5      ]� ���#1e1e1e$��7q�5      .+�5   
   �� $��28��6   ���#252525$	��Top=�5       J� InputBindings 5      d� 5       d� MouseAction$ 	LeftClicke�6    �� Command 5      �� *MoveWindowCommand+._�5      �  � ColumnDefinitions 5      �� 5       �� 5!      $	��100 �6'   .+�5#      �� $��notes  1.0.0��6   
�������$��Consolas)�5%      $��Center=�5&      $��Center=�5'      $��	100,0,0,0q�5(      �� 5)      $��1��6   	 �� Orientation$	 
Horizontal=�5*      $��Right=�5+      $��0,0,4,0q�5,      .+�5-      �� $
��🗕��6   $��0,0,0,6q�5.         MinimizeButtonStyle#��[  50      ��5/      �� *MinimizeWindowCommand+50      �� 51      $
��🗖��6   $��0,0,0,2q�52        MaximizeButtonStyle#��[ 54      ��53      �� *MaximizeWindowCommand+54      �� 55      $
��🗙��6   $��0,0,0,2q�56        ShutDownButtonStyle#��[ 58      ��57      �� *ShutdownCommand+58      59      5:      5;      �� 5<   
   $��48��6   $
��Left=�5=      ���#252525��5@      �� 5A      
 �� Triggers
 5B      :� 5C       :� RoutedEvent$ Border.MouseEnter��6'   [�5D      �� 5E   "   .��5F   &   �� .��5G   *   W�  �� TargetProperty$ (Border.Width)�6:   	 W� To 1205H   :    g� Duration$ 0:0:.1D�5I   :   5J   '   5K   #   5M      :� 5O      $ Border.MouseLeave��6'   [�5P      �� 5Q   "   .��5R   &   �� .��5S   *   W� $ (Border.Width)�6:    485T   :   $ 0:0:.1D�5U   :   5V   '   5W   #   5Y      5\      ._�5_      �� .+�5`      �� $��+Add new...��6   $��Consolas)�5a        AddNoteButtonStyle#��[ 5b      ��5c      �� *AddNewNoteCommand+�� 5e      $��Delete Note��6   $��Consolas)�5f        DeleteNoteButtonStyle#��[ 5g      ��5h      �� *DeleteNoteCommand+�� 5k      $	��120��5m      $��0,20,0,0q�5n      
������ $��0q�5p      $��False��5q      ��5k      �� *Interface.Notes+ �� SelectedItem 5l      �� *Interface.SelectedItem+5r      5t      5u      �� 5v   
   .+�5w      �� $
��Auto��6   $
��Auto��5x      
������ 
������� �� TextWrapping$
 Wrap=�5{      $��5,0,5,5q�5|      $��5q�5}      ��5~      �� *Interface.Text+.��66   5�      5�      5�      5�      