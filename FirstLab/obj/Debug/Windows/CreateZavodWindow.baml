   M S B A M L   `   `   `  ����C  ?FirstLab, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:SecondLab.WindowsSecondLab.Windows  5   	   )    #SecondLab.Windows.CreateZavodWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:SecondLab.Windows     5   	   -   5          � Title$  CreateZavodWindow��5   	   $	��450��6#   $	��450��60   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��55* �6   �� 5      $	��69* �6   �� 5      $	��54* �6   �� 5      $	��67* �6   �� 5      $	��55* �6   �� 5      $	��62* �6   �� 5      $	��72* �6   .+�5   
   �� $%��Название завода
��6   $
��Bold"�64   $��18(�6F   $��Center=�6T   $��10,10,10,10q�6x   �� 5   
   -   5         ��Name$ NameTextBox��5      $��Center=�6'   $��0,10,0,0q�6D   $��1��6V    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��430��6�   $��40��6�   �� 5   
   $!��Прибыль завода��6   $
��Bold"�6)   $��18(�6;   $��Center=�6I   $��10,69,10,10q�6m   $��1��6�   $��2��6�   �� 5   
   -   5        $ IncomeTextBox��5      $��Center=�6)   $��0,10,0,0q�6F   $��3��6X   $
 Wrap=�6e   $	��Top=�6y   $	��430��6�   $��40��6�   �� 5   
   $��Тип завода��6   $
��Bold"�6%   $��18(�67   $��Center=�6E   $��10,10,10,10q�6i   $��4��6~   �� 5   
   -   5         ��Name$ TypeOfZavodBox��5      $��Center=�6+   $��5��6H   $��Center=�6U   $	��120��6p   $��22��6|   6�   �� 5   
   -   5        $#��Добавить запись��5      $��6��6+   $��10,10,10,10q�68   6M   5      5      