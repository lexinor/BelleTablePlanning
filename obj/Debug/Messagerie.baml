   M S B A M L   `   `   `  ����M  IBelleTablePlanning, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:BelleTablePlanningBelleTablePlanning  5   	   #    BelleTablePlanning.Messagerie   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:BelleTablePlanning     5   	   -   5          �Name$  Messagerie1��5   	    � Title$ 
Messagerie��5   	   $	��411��6   $	��650��6)    � WindowStartupLocation$ CenterScreen=�65    � 
ResizeMode$ NoResize=�6Z   ���	#FF2A4FB0.��5	      � .+�5
   
   ]� $��63��6   ��.  $	��644��66   ���	#FF2A4FB0$	��Top=�6Y   .+�5      �� -   5         ��Name$ titre��5      $��
Messagerie��6#   $��41��68   $��260,11,0,11q�6D   
�������$��22(�6l   $��0q�6z    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��Bottom=�6�   $
��Left=�6�   $	��Top=�6�   $	��114��6�   5      �� 5   
   -   5         ��Name$ sendMsg��5      $��Envoyez un message��6"   $
��Left=�6?   $��	10,77,0,0q�6Z   $	��Top=�6m   $	��119��6�   $��23��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ msgGrid��5      $��10,105,10,10q�6$      AutoGenerateColumns .  	   CanUserResizeColumns	 .  
   CanUserAddRows
 .     CanUserReorderColumns .     SelectionMode$ Single=�6�      CanUserResizeRows .     
IsReadOnly . |�.   � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType��%+   '        �� 5      "  6   5      5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Envoyé par��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6V   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *
emetteur+6V     5      $ Objet��6%   $
 Auto 6R    64   �� *	objet_msg+6R     5      $ Date d'envoi��6%   $
 Auto 6X    6;   �� *
date_msg+6X     5      $ Message��6%   $ * 6N    66   �� *msg+6N   5      �� 5   
   -   5        $ lireMsg_btn��5      $��Ouvrir le message��6&   $��
515,77,0,0q�6B   $	��Top=�6V   $��23��6n   $
��Left=�6�   $	��119��6�   �� 5   
   -   5        $ 
repMsg_btn��5      $��	Répondre��6%   $
��Left=�68   $��
145,77,0,0q�6S   $	��Top=�6g   $��70��6   $��23��6�   6�   �� 5   
   -   5         ��Name$ LogoImg��5      $��LogoBelleTableClean.PNG��6!   $��554,-2,0,317q�6B   5      5      