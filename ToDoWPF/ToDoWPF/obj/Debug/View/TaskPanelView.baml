   M S B A M L   `   `   `  ����B  >ToDoWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ToDoWPF.ViewToDoWPF.View  5           ToDoWPF.View.TaskPanelView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:ToDoWPF.View     5      $	��500��5      $	��800��6   .��5	      �    brown-Background-Brush#��[  6     � RowDefinitions  5   
   �� 5      $	��100 �6   �� 5      $��10 �6   �� 5      .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6#   $
��Left=�6<   $��Center=�6W   .+�5      �� $
��ToDo��6   $��42(�6#   $
��Auto��61     darkBrown-Text-Brush#��[ 6>     FontFromDictionary#��[ 6q   $
��Bold"�6�   �� 5      $��	500,0,0,0q�6   $
��+Add��6(     ButtonStyle1#��[ 67   ��5      �� *
AddCommand+5      �� 5      $��-Remove��6   #��[ 6(   ��6N   �� *RemoveCommand+5      �� 5   
   $��1��6     brightBrown-Overlay-Brush#��[ 6!   5      �� 5    
   $��0��6   $��50��6   $	��400��6+   
������ #��[ 5!   +   $��2q�5"      #��[ 6&   $��24(�5#      $��Center=�6!   ��5$      �� *	NewTask+6-   �� 5&   
   $��2��6     whiteAmber-Background-Brush#��[ 6!   5(      �� 5*   
   $��2��6   ��6    �� *Tasks+ �� SelectedItem 6>   �� *
Selected+��5+      �� 5,      .R�5-      �� $ 
Horizontal=�6!   .+�5/      �� #��[ 50   $   $��24(�51   $   ��5/   $   �� *Description+��52   $   �� *StrikeDecoration+54      �� 56        warmOrange-Buttons-Brush#��[ 6#   $��Center=�57      $��Center=�58   >    d� 	IsChecked 57   6   �� *IsDone+��58      �� *SetDoneCommand+5:      5=      5>      5@      5D      5E      