   M S B A M L   `   `   `  ����M  IBelleTablePlanning, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:BelleTablePlanningBelleTablePlanning  5   	   $    BelleTablePlanning.PlanningRdv   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:BelleTablePlanning     5   	     � Title$  Planning des rendez-vous��5   	   $	��421��6*   $	��718��67    � 
ResizeMode$ NoResize=�6C    � WindowStartupLocation$ CenterScreen=�6Y   ���	#FF2A4FB0.��5	      � $��0,0,4,-1q�6   .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ planningGrid��5
      $��Center=�6)   $��10,145,10,0q�6F   $	��688��6[   $	��225��6g   $	��Top=�6t   |�.     CanUserSortColumns .     CanUserReorderColumns .     CanUserResizeRows .     SelectionMode$ Single=�5   K      
IsReadOnly . 	 J� IsManipulationEnabled	 . ��5      �� 
 �� Path$	
 Rdv� �� SelectedItem 64   �� $
 SelectedRdv� �� Mode$ TwoWay=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$	 Nom��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *	nomClient+6`     5      $ Prénom��6%   $
 auto 6V    65   �� *prenomClient+6f     5      $ Date du rendez-vous��6%   $
 auto 6^    6B   �� *	dateRdv+6n     5      $ 	Intitulé��6%   $ * 6V    67   �� *
libelleRdv+6c   5      �� 5   
   -   5        $��LogoImg��5      $��LogoBelleTableClean.PNG��6   $��618,0,0,298q�6@   $
��Left=�6U   $��80��6p   $��85��6{   $��Bottom=�6�   �� 5   
   -   5         ��Name$ 
btn_Retour��5      $�� ��6%   
�������$��0q�6C   $��0,0,648,338q�6p   $��Right=�6�   $��50��6�   $��45��6�   $��Bottom=�6�   ��5      �� 5       �� ImageSource$" ic_arrow_back_black_48dp.png��6    j� Stretch$ UniformToFill=�6H   5      �� 5    
   -   5         ��Name$ titre��5       $��Planning des rendez-vous��6   $��38��6B   $��0q�6N   $	��Top=�6Y   $	��253��6q   
�������$��20(�6�   $��SemiBold"�6�   �� 5!   
   -   5        $ 
filtreDate��5!      $��Filtrer par dates :��6$   $
��Left=�6B   $��Center=�6]   $��10,85,0,276q�6x   
�������$��32��6�   6�   (  "System.Windows.Controls.DatePicker  5"   
   -   5          Name$ filtreDatePick��5"      $
��Left=�6-   $��
10,116,0,0q�6H   $	��Top=�6\   $	��200��6t      SelectedDateFormat$ Short=�6�   |�.  $��0q�6�   �� 5#   
   -   5        $ btnResetFiltre��5#      $��Réinitialiser le filtre��6)   $��Center=�6K   $��225,116,368,0q�6h   $	��Top=�6   $	��115��6�   $��24��6�   
�������
�������6�   �� 5$   
   -   5        $ btnDetailsRdv��5$      $��Afficher les détails��6(   $��Center=�6G   $��355,116,245,0q�6d   $	��Top=�6{   $	��108��6�   $��24��6�   
�������
�������6�   5%      5&      