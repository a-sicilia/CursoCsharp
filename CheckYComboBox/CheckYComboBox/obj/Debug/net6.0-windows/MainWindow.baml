   M S B A M L   `   `   `  ����I  ECheckYComboBox, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:CheckYComboBoxCheckYComboBox  5   	       CheckYComboBox.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:CheckYComboBox     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+   .+�5   
   �� $��0��6   .+�5      �� -   5        $��Ciudades��5      ��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6%   .+�5      �� $��16(�6G   ��6(   �� *NombreCapital+6W   5      5      5      5      �� 5   
   $��1��6   $	��100q�6%   .+�5      �� $��16(�6   $
��Bold"�6"   .��64   Pais6:   �� 5      -   5        $��checkTodasCapi��5       d� IsThreeState$
 True��6-   .��6�   Agregar todas6�   �� 5!      $��15q�6   .+�5"      �� -   5        $��Lanus��5"      .��6f   Lanus6m   �� 5#      -   5        $��Banfield��5#      .��6i   
Banfield6s   �� 5$      -   5        $��Lomas��5$      .��6f   Lomas6m   �� 5%      -   5        $��
Longchamps��5%      .��6k   
Longchamps6w   �� 5&      -   5        $��Microcentro��5&      .��6l   Microcentro6y   �� 5'      $
��test��6    �� 
IsReadOnly$
 True��6&   6:   5(      5*      5,      5-      