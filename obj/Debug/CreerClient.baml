   M S B A M L   `   `   `  ����M  IBelleTablePlanning, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:BelleTablePlanningBelleTablePlanning  5   	   $    BelleTablePlanning.CreerClient   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:BelleTablePlanning     5   	     � Title$#  Création d'un nouveau client��5   	   $	��429��6.   $	��611��6;    � 
ResizeMode$ NoResize=�6G    � WindowStartupLocation$ CenterScreen=�6]   ���	#FF2A4FB0.��5	      � $	��600��6   $	��420��6   .+�5
   
   �� ���	#FFF4F4F5$��Center=�6%   $	��227��6B   $��38,124,35,0q�6O   
���   �$	��Top=�6s   $	��527��6�   �� 5   
   -   5        $��LogoImg��5      $��LogoBelleTableClean.PNG��6   $��501,5,20,308q�6@   �� 5   
   -   5         ��Name$ 
btn_Retour��5      $�� ��6%   
�������$��0q�6C   $��28,27,531,333q�6p   ��5      �� 5       �� ImageSource$" ic_arrow_back_black_48dp.png��6    j� Stretch$ UniformToFill=�6H   5      �� 5   
   -   5         ��Name$ titre��5      $#��Création d'un nouveau client��6   $��Center=�6F   $��38��6c   $��0,37,0,0q�6o   $	��Top=�6�   $	��287��6�   
�������$��20(�6�   $��SemiBold"�6�   �� 5   
   $��Nom :��6   $
��Left=�6    $��140,141,0,0q�6;   $	��Top=�6P   �� 5   
   -   5         ��Name$ nomText��5      $
��Left=�6#   $��23��6>   $��
70,172,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��182��6�   �� 5   
   $��	Prénom :��6   $
��Left=�6#   $��130,205,0,0q�6>   $	��Top=�6S   �� 5   
   -   5        $ 
prenomText��5      $
��Left=�6&   $��23��6A   $��
70,236,0,0q�6M   $
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��182��6�   �� 5   
   $��Mail :��6   $
��Left=�6!   $��138,271,0,0q�6<   $	��Top=�6Q   �� 5   
   -   5        $ mailText��5      $
��Left=�6$   $��23��6?   $��
70,302,0,0q�6K   $
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��182��6�   �� 5   
   $��	Adresse :��6   $
��Left=�6$   $��400,142,0,0q�6?   $	��Top=�6T   �� 5   
   -   5        	 ��Name$	 adresseText��5      $
��Left=�6+   $��50��6F   $��336,172,0,0q�6R   $	��Top=�6g   $	��196��6   . �5      /� .T�5      J� .*�6   .*�5      �� $� ��6   5      5      5      �� 5    
   $��Téléphone :��6   $
��Left=�6&   $��396,228,0,0q�6A   $	��Top=�6V   �� 5!   
   -   5        $ telephoneText��5!      $
��Left=�6)   $��23��6D   $��336,258,0,0q�6P   $
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��196��6�   �� 5"   
   $��Structure :��6   $
��Left=�6&   $��397,287,0,0q�6A   $	��Top=�6V   �� 5#   
   -	   5        
 ��Name$
 structureBox��5#      $
��Left=�6)   $��336,316,0,0q�6D   $	��Top=�6Y   $	��196��6q   �� 5$   
   -
   5        $��Valider��5$      $��Center=�6#   $��262,365,262,0q�6@   $	��Top=�6W   $��76��6o   6z   5%      5&      