   M S B A M L   `   `   `  ����M  IBelleTablePlanning, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:BelleTablePlanningBelleTablePlanning  5   	   #    BelleTablePlanning.RdvDetails   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:BelleTablePlanning     5   	     � Title$  Détails du rendez-vous��5   	   $	��331��6(   $	��550��65    � 
ResizeMode$ NoResize=�6A    � WindowStartupLocation$ CenterScreen=�6W   ���	#FF2A4FB0.��5	      � .+�5
   
   �� -   5         ��Name$ titre��5
      $��Détails du rendez-vous��6   $��38��6@   $��180,10,185,0q�6L   $	��Top=�6b   
�������$��16(�6�   $��SemiBold"�6�   �� 5   
   -   5        $��LogoImg��5      $��LogoBelleTableClean.PNG��6   $��0,7,10,0q�6@   $��52��6R   $	��Top=�6^   $��Right=�6v   $��49��6�   �� 5   
   -   5         ��Name$ 
btn_Retour��5      $�� ��6%   
�������$��0q�6C   $��	10,12,0,0q�6p   $
��Left=�6�   $��40��6�   $��36��6�   $	��Top=�6�   ��5      �� 5       �� ImageSource$" ic_arrow_back_black_48dp.png��6    j� Stretch$ UniformToFill=�6H   5      �� 5   
   -   5        $ typeRdv��5      $��-----��6!   $
��Left=�61   $��
180,53,0,0q�6L   $	��Top=�6`   
�������6x   �� 5   
   -   5        $ lblDetailsC��5      $��Client :��6%   $
��Left=�68   $��	10,86,0,0q�6S   $	��Top=�6f   
�������6~   �� 5   
   -   5        $ infosC��5      $��-----��6    $
��Left=�60   $��	56,86,0,0q�6K   $	��Top=�6^   
������� J� RenderTransformOrigin$ 0.559,0.538&�6�   �� 5   
   -   5        $ lblMail��5      $��Mail :��6!   $
��Left=�62   $��
10,112,0,0q�6M   $	��Top=�6a   
�������$ 0.564,0.423&�6�   �� 5   
   -   5        $ mailC��5      $��-----��6   $
��Left=�6/   $��
49,112,0,0q�6J   $	��Top=�6^   
�������6v   �� 5   
   -	   5        $ lblTel��5      $��N° Téléphone :��6    $
��Left=�69   $��
10,138,0,0q�6T   $	��Top=�6h   
�������6�   �� 5   
   -
   5        $
 telC��5      $��-----��6   $
��Left=�6.   $��
97,138,0,0q�6I   $	��Top=�6]   
�������6u   �� 5   
   -   5        $ 
lblDateRdv��5      $��Date :��6$   $
��Left=�65   $��
10,163,0,0q�6P   $	��Top=�6d   
�������6|   �� 5   
   -   5        $ dateRdv��5      $��-----��6!   $
��Left=�61   $��
51,163,0,0q�6L   $	��Top=�6`   
�������6x   �� 5   
   -   5        $ lblIntituleRdv��5      $ ��Intitulé du rendez-vous :��6(   $
��Left=�6L   $��
10,207,0,0q�6g   $	��Top=�6{   
�������6�   �� 5    
   -   5        $ intituleRdv��5       $��-----��6%   $
��Left=�65   $��149,207,0,0q�6P   $	��Top=�6e   
�������6}   �� 5"   
   -   5        $ lblDescriptionRdv��5"      $"��Description du rendez-vous :��6+   $
��Left=�6R   $��
10,233,0,0q�6m   $	��Top=�6�   
�������6�   �� 5#   
   -   5        $ descriptionRdv��5#      $��-----��6(   $
��Left=�68   $��172,233,0,0q�6S   $	��Top=�6h   
�������6�   �� 5%   
   -   5        $ 
lblPlanRdv��5%      $��Plan d'accès :��6$   $
��Left=�6=   $��
371,86,0,0q�6X   $	��Top=�6l   
�������6�   �� 5&   
   -   5        $ planRdv��5&      $��-----��6!   $
��Left=�61   $��371,112,0,0q�6L   $	��Top=�6a   
�������6y   5*      5+      