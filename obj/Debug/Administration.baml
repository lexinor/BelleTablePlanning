   M S B A M L   `   `   `  ����M  IBelleTablePlanning, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:BelleTablePlanningBelleTablePlanning  5   	   '    !BelleTablePlanning.Administration   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:BelleTablePlanning     5   	     � Title$  Administration��5   	   $��490.97��6    $	��893��60    � 
ResizeMode$ NoResize=�6<    � WindowStartupLocation$ CenterScreen=�6R   ���	#FF2A4FB0.��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��685* �6   �� 5      $
��202* �6   .+�5   
   ]� $
��Left=�6   $��83��6/   ��.  $	��Top=�6Q   $	��887��6i   ���	#FF2A4FB0$��2��6�   .+�5      �� -   5         ��Name$ 
btn_Retour��5      $�� ��6)   
�������$��0q�6G   $��70��6t   ��5      �� 5       �� ImageSource$" ic_arrow_back_black_48dp.png��6!    j� Stretch$ UniformToFill=�6L   5      �� 5      -   5         ��Name$ titre��5      $��Espace Administration��6#   $
��Left=�6C   $��41��6^   $��
175,21,0,0q�6j   $	��Top=�6~   $	��227��6�   
�������$��22(�6�   5      �� 5   
   -   5         ��Name$ outils��5      $
��Left=�6%   $	��363��6@   $��	10,77,0,0q�6M   $	��Top=�6`   $	��855��6x   $��2��6�   |�.  .@�5      �� $��Liste des membres��6   $��16(�61   .��5      �  5      �� 5      $
��141* �6+   �� 5      $	��71* �6+   �� 5      $
��637* �6+   .+�5      &   System.Windows.Controls.DataGrid  -   5        	  Name$	 listeMembre��5      $
��Left=�64   $	��310��6O   $	��Top=�6\   $	��652��6t   $��	10,10,0,0q�6�   $��3��6�   |�.  
   CanUserReorderColumns
 .     CanUserSortColumns .   J� IsManipulationEnabled .    SelectionMode$ Single=�6     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn   Header$	 Nom��61      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6>   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6K   �� *nomU+6f     5!      $ Prénom��61   $
 auto 6A    6N   �� *	prenomU+6l     5"      $ Téléphone��61   $
 auto 6D    6Q   �� *telU+6l     5#      $
 Mail��61   $ * 6?    6I   �� *mailU+6e   5%      �� 5&      $
��Left=�6!   $	��261��6<   $��
471,10,0,0q�6I   $	��Top=�6]   $	��156��6u   $��2��6�   .+�5'      �� -   5        $ outiluti��5'       $��Outils��62   $��50,5,0,0q�6C   $
��Bold"�6U   $��Segoe UI Semibold)�6g   �� 5(      -   5        $ 	buttonmdp��5(   !   $��Réinitialiser MDP��64   $��0,20,0,0q�6P   $��45��6b   ���	#FF2A66BD
�������$��1��6�   ���	#00B470706�   �� 5)      -   5        $ btnport��5)   !   $��Attribuer portefeuille��62   $��0,60,0,0q�6S   $��45��6e   ���	#FF2A66BD
�������$��1��6�   ���	#00B470706�   5+      5-      5.      �� 5/      $��Historique des connexions��6   $��16(�69   .��50      � 
������� 51      �� 52      $	��45* �6+   �� 53      $
��308* �6+   .+�55        -   5        $	 affconnexion��55      $��2��65   $
��Left=�6I   $	��310��6d   $��	10,10,0,0q�6q   $	��Top=�6�   $	��702��6�    . 6�   �� 56      -	   5        $ btnerror��56      $��Erreurs��6/   $��1��6A   $
��Left=�6Q   $��
609,10,0,0q�6l   $	��Top=�6�   $	��122��6�   $��41��6�   57      58      �� 59      -
   5        $��tabIncident��59      $��	Incidents��6)   $��16(�6<   .��5:      � 
������� 5;      �� 5<      $	��45* �6+   �� 5=      $
��308* �6+   .+�5?        -   5        $	 incidentsGrid��5?      $��2��66   $
��Left=�6J   $	��310��6e   $��	10,10,0,0q�6r   $	��687��6�   $	��Top=�6�   |�.  
 .   .   . $ Single=�6   .  5@        5A      $ Statut��61    6A   �� *statut+6^     5B      $
 Type��61    6?   �� *typeIncident+6b     5C      $ Objet��61    6@   �� *objet+6\     5D      $
 Date��61    6?   �� *date+6Z     5E      $ Auteur��61    6A   �� *auteur+6^     5F      $ Message��61    6B   �� *msg+6\   5H      �� 5I      -   5        $ 	btnResolu��5I      $��Résolu��60   $��1��6A   $
��Left=�6Q   $��
609,38,0,0q�6l   $	��Top=�6�   $	��122��6�   $��45��6�   ���	#FF2A66BD
�������$��1��6�   ���	#00B470706�   5J      5K      5L      �� 5M   
   -   5        $��LogoImg��5M      $��LogoBelleTableClean.PNG��6   $��0,0,22,0q�6@   $��1��6R   $��Right=�6b   $	��101��6~   $��88��6�   $	��Top=�6�   5N      5P      