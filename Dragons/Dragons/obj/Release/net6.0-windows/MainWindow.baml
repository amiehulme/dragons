   M S B A M L   `   `   `  ���� B  >Dragons, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:DragonsDragons      Dragons.MainWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:Dragons       � Title$  Dragons and Dungeons�� � WindowStartupLocation$ CenterScreen=�#��Z��#��Z��   MainPanelBackground#��[  .��]� -    ]�Name$
 Main��$
��True��.+��� #��[  $
��Left=�$��Center=�����   PercentageConverter �� 	Converter# [  �� ConverterParameter$	 0.3�� �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType" �� �� Path$ ActualWidth����� # [ $	 0.9�� �� $ FindAncestor=�" ��$ ActualHeight�.+�]� -   $ SelectionPanel��$
��Left=�	 �� Left$	 24��$��Center=����� # [ $	 0.9�� �� $ FindAncestor=�" ��$ ActualWidth����� # [ $
 0.92�� �� $ FindAncestor=�" ��$ ActualHeight�.+��� -   
 ��Name$
 CharacterList��  ListViewBackground#��[ $��Stretch=����� *
Characters+����  �� DataType$ local:Character��.R���   BorderColor#��[ $��2q� �� CornerRadius$ 2��._���  �� Orientation$ 
Horizontal=�$��70��$��10,0,0,0q�.+���   
IconBorder#��[ ._���   BodyText#��[ $��Center=����� *DefaultPortrait+�� $��10��$��70���� #��[ ���� *Name+]� -   $ 
RightPanel��$	��500��$
��True��.+��� $��Bottom=�$��10������ # [ $	 1.0�� �� $ FindAncestor=�" ]�$ ActualWidth�]� $��Bottom=�$��55��.+��� -    ��Name$ 
PlayButton��$	��200��$��55��  RoundedButton#���  $��Center=�.���� $
��PLAY�� � ToolTip$ Start the Game��#��[ $��Oblique$�]� -   $ CharacterInfoPanel��.+��� $ 4��._��� $��Center=�$��Center=�  InfoPanelBackground#��[ ���� # [ $	 0.6�� �� $ FindAncestor=�" ��$ ActualWidth����� # [ $	 0.9�� �� $ FindAncestor=�" ��$ ActualHeight�.+���   SectionHeaderText#��[ $��Race and Class:��$��5,0,0,0q��� $��3���� #��[ $��1q�$ 4��._��� $ 
Horizontal=�$	��120��.+��� $ 4��$��1q�#��[ ���� # [ $	 0.5�� �� $ FindAncestor=�" ��$ ActualWidth����� # [ $	 1.0�� �� $ FindAncestor=�" ��$ ActualHeight�._�]� ���� # [ $	 0.5�� �� $ FindAncestor=�" ��$ ActualWidth����� # [ $	 1.0�� �� $ FindAncestor=�" ��$ ActualHeight�.+��� $ Vertical=�.+��� $��10���� $��Center=�$ 
Horizontal=����� # [ $	 1.0�� �� $ FindAncestor=�" ]�$ ActualWidth�.+��� $��10���� #��[ $	 10��
 �� Top$ 3��$
��Left=�$��Center=�._��� 
�������$��64��$��64���� $��20���� #��[ $��Center=����� *SelectedCharacter.Race.Name+�� $��10���� #��[ $	��177������ *" SelectedCharacter.Race.Attribute+�� $��1q�#��[ ���� # [ $	 0.5�� �� $ FindAncestor=�" ��$ ActualWidth����� # [ $	 1.0�� �� $ FindAncestor=�" ��$ ActualHeight�._�]� ���� # [ $	 0.5�� �� $ FindAncestor=�" ��$ ActualWidth����� # [ $	 1.0�� �� $ FindAncestor=�" ��$ ActualHeight�.+��� $ Vertical=�.+��� $��10���� $��Center=�$ 
Horizontal=����� # [ $	 1.0�� �� $ FindAncestor=�" ]�$ ActualWidth�.+��� $��10���� #��[ $	 10��$ 3��$
��Left=�$��Center=�._��� 
�������$��64��$��64���� $��20���� #��[ $��Center=����� *SelectedCharacter.Class.Name+�� $��10���� #��[ $	��177������ *PrimeStatString+�� $��8���� #��[ $��Ability Scores:��$��5,0,0,0q��� $��3���� -   $
 AbilityList��#��[ ${�False��$��Stretch=����� *SelectedCharacter.Scores+���� $# local:Character::AbilityScore��.R��� #��[ $��2q�$ 2��._��� $ 
Horizontal=�$��70��.+��� #��[ ���� *DisplayString+�� $��5���� -    ��Name$ OtherValuesPanel��$ Vertical=�.+��� $��10���� #��[ $��10,0,0,0q����� *
HPString+�� $��5���� #��[ $��10,0,0,0q����� *
GoldString+