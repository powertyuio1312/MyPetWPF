   M S B A M L   `   `   `  ����A  =MyPets, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MyPetsMyPets  5   	       MyPets.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:MyPets     5   	     � Icon$  /Resources/Img/icocat.ico��5   	    � Title$ 
MainWindow��5	   	   $	��500��6   $	��800��6)    � 
ResizeMode$ NoResize=�65    � WindowStartupLocation$ CenterScreen=�6K   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��220 �6   6-   �� 5      .+�5   
    � $��0��6   $��7��6    ���#9833FF61   �� 5   
   $��0��6   $��	0,0,0,0.4q�6&   .+�5      �� -   5         ��Name$ 
YourPetsCB��5       �� Text$        Your pets��6[   $��26(�6s      ComboBox#���   6�   $��50��6�   �� 5      -   5          
ButtonMain#���  5       
 l_Care#���  6;   6^   �� 5      -   5        #���  5       	 l_Apt#���  6:   6\   �� 5      -   5        #���  5        l_chart#���  6;   6_   �� 5      -   5        #���  5       
 l_Note#���  6;   6^   5      �� 5   
   -   5          	PetCreate#���  5      $��0��65   $��55,0,55,30.4q�6E   $	��110��6[   $	��110��6g   $��Bottom=�6t   ���#9933ff��5      �� 5        �� ImageSource$  /Resources/Img/BabyCat.PNG��6   5"      �� 5#   
     l_NewPet#���  6   $��0��65   $
��Bold"�6E   $��0,0,0,10q�6X   $��Bottom=�6j   $��Center=�6�    � 5&   
   $��1��6   $��7��6    
�������$��2��6E   $��0,0,-0.4,0.4q�6Y   �� 5'   
   $��/Resources/Img/choice.png��6   $��1��63    J� Opacity$	 0.5Q�6C   $	��300��6Q   $
��Left=�6^   $��15,0,0,0q�6y   $	��Top=�6�   �� 5)   
   -   5        $��StackAcc��5)      $��1��6%   
�������$y�Hidden=�6J   .+�5*         MyPets.PetsAcc  -   5        	  Name$		 acc��5*      5+      �� 5,   
   -	   5         
 Button#���  5,      $��1��62   $��50��6B   $��Bottom=�6N   $��Right=�6i    		 l_Del#��� 	 6�   $	��130��6�   6�   50      51      