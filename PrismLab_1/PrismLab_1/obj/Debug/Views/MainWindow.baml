   M S B A M L   `   `   `  ����  
PrismLab_1!    PrismLab_1.Views.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   P LPrism.Wpf, Version=6.3.0.0, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59$prismhttp://prismlibrary.com/  5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  . $	��450��5   !   $	��525��6.    � Title 6	   �� *Title+.  (System.Windows.Interactivity.Interaction   Triggers 5	      /  )System.Windows.Interactivity.EventTrigger  5
   
      	EventName$ Closing��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6%   �� *CloseCommand+5      ��5      �� 5   
    �� ImageSource$+ %pack://application:,,,/Images/sky.jpg��6    j� Stretch$ UniformToFill=�6I    j� TileMode$
 None=�6a   .��5      � 	 � ColumnDefinitions	 5   
   �� 5      $	��385 �6   �� 5      
 � RowDefinitions
 5   
   �� 5      $��60 �6   �� 5      $	��250 �6   �� 5      $	��140 �6   .+�5   
   �� $��1��6   $��You score: ��5      $��Italic$�5      $��14(�5       
�������$��5,5,5,5q�5"      $
��Left=�5#      �� 5$   
   $��1��6   $��5,5,5,5q�5&      $��Right=�5'      $��Italic$�5(      $��14(�5)      
�������$��Right=�5+      ��5%      �� *	UserScore+5+      �� 5,   
   $��0��6   $��0��5-      $;��5Вітаю вас у грі 'Вгадай слово'��5.      $��Center=�5/      $��Italic$�50      $��18(�51      
�������$��Center=�53      �� 54   
   $��1��6   $��10,20,20,10q�56      $��Italic$�57      $��16(�58      
�������$	��Top=�5:      $��80��5;      $	��365��5<      $	��365��5=      ��55      �� *
Question+5=      �� 5>   
   $��1��6   $��Center=�5?      $
��Left=�5@      $��80��5A      $��20,20,20,20q�5B      ��5C      �� *
UserAnswer+�� 5E   
   $��1��6   $��20��5F      $��50��5G      ��5H      �� *BtnAnswerCommand+�� 5J   
   $��1��6   $��20��5K      $��20��5L      $
��Left=�5M      $��Bottom=�5N      $��
20,0,20,35q�5O       �� 	MaxLength$ 1��5P      ��5Q      �� *PotentialLetter+�� 5R   
   $��1��6   $��20��5S      $��50��5T      $��Center=�5U      $��Bottom=�5V      $��
20,0,20,35q�5W      ��5X      �� *CheckLetterCommand+�� 5Y   
   $��1��6   $��40��5Z      $	��120��5[      $
��Left=�5\      $��Bottom=�5]      $��
20,0,20,60q�5^      $��Italic$�5_      $��16(�5`      
�������$	��Top=�5b      $
��Left=�5c       �� ContentStringFormat$ Answer: {0}��5e      ��5d      �� *
CodeAnswer+5e      5g      5h      