   M S B A M L   `   `   `  ����M  IBelleTablePlanning, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:BelleTablePlanningBelleTablePlanning  5   	   )    #BelleTablePlanning.ConsulterClients   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:BelleTablePlanning     5   	     � Title$  Consulter les clients��5   	   $	��521��6'   $	��913��64   ���	#FF2A4FB0 � 
ResizeMode$ NoResize=�6W    � WindowStartupLocation$ CenterScreen=�6m   .��5	      � $��0,0,4,-1q�6    � RowDefinitions 5
   
   �� 5      $	��19* �6   �� 5      $��2* �6   .+�5   
   �� -   5         ��Name$ 
btn_Retour��5      $�� ��6%   
�������$��0q�6C   $��28,27,813,351q�6p   ��5      �� 5       �� ImageSource$" ic_arrow_back_black_48dp.png��6    j� Stretch$ UniformToFill=�6H   5      �� 5   
   -   5        $��LogoImg��5      $��LogoBelleTableClean.PNG��6   $��805,5,10,351q�6@    J� RenderTransformOrigin$ 	0.5,0.444&�6V   �� 5   
   -   5         ��Name$ titre��5      $��Consulter les clients��6   $��Center=�6?   $��38��6\   $��299,27,295,0q�6h   $	��Top=�6~   $	��196��6�   
�������$��20(�6�   $��SemiBold"�6�   &   System.Windows.Controls.DataGrid  5   
   -   5        	  Name$	 clientsGrid��5      $��Right=�6(   $	��346��6D   $��
0,100,18,0q�6Q   $	��Top=�6e   $	��857��6}   |�.  
   CanUserSortColumns
 .     CanUserResizeColumns .     CanUserReorderColumns .     CanUserResizeRows .     SelectionMode$ Single=�5   K      
IsReadOnly .  J� IsManipulationEnabled .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$	 Nom��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6J   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *nom+6Y     5      $ Prénom��6%   $
 auto 6P    65   �� *prenom+6_     5      $
 Mail��6%   $
 auto 6L    63   �� *mail+6[     5      $ Téléphone��6%   $
 auto 6P    68   �� *tel+6_     5      $
 Type��6%   $
 auto 6R    63   �� *
typeClient+6a     5      $ Adresse��6%   $ * 6R    66   �� *	adresse+6^   5      5!      5"      