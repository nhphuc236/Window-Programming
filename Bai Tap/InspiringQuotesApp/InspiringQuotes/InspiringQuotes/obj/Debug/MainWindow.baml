   M S B A M L   `   `   `  ????J  FInspiringQuotes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:InspiringQuotesInspiringQuotes  5   	        InspiringQuotes.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:InspiringQuotes     5   	   -   5          ? Title$  Inspiring Quotes??5   	   $	??600??6"   $	??400??6/    ? 
ResizeMode$ CanMinimize=?6R    ? WindowStartupLocation$ CenterScreen=?6k   .??5
      ?? .+?5   
   ?? -   5         ??Name$ quotesLabel??5      $??Hello World??5       ?? Left$ 17??5      
 ?? Top$	 174??6!   $	??120??5      $	??358??6   $??20(?5      
???????$??Center=?5      $??Center=?64   ??5      ?? 5       ?? 
StartPoint$ 0.5,0&?6&    ?? EndPoint$ 0.5,1&?69    ?? Opacity$	 0.5Q?6K   .??5      ? 	 ? Color$	 MediumOrchid??6#   
 ? Offset$	
 0.2Q?68   ? 5      $
	 Cyan??6#   $
 1Q?60   5      5      ?? 5!   
   -   5         ??Name$ nextQuoteButton??5!      $	 172??5"      $	 462??6#   $??42??5$      $??56??6   $??0q?5%      ??5&      Z? .??5(      ??  ?? Orientation$ 
Horizontal=?6   $??Center=?62   $??Center=?6O   .+?5)      ?? $??/images/next.png??6   $??60??62   $??86??6>    J? RenderTransformOrigin$ 0.544,1.142&?6I    ? Cursor$
 Hand??6m   $??Center=?6{   $??Center=?6?   $??Uniform=?6?    J? Opacity$	 0.7Q?6?   5*      5+      ?? 5.   
   $ 17??50   C   $	 294??6T   ??5/      ??  ?? Path$ ActualHeight? ?? ElementName$ quotesLabel????50      ?? $ ActualWidth?$ quotesLabel????51      !? 54      $	 0.5Q?55       j? Stretch$
 None=?6    !? Visual 56      ?? $ quotesLabel?? ?? RelativeTransform 57      V? 5:      .~?5;      ??  ?? ScaleX$ 1Q?6-    ?? ScaleY$ -1Q?68   T? 5<       T? Y$ 1Q?62   5=      5?       J? OpacityMask 5B      ?? 5C      $ 0.5,0&?6&   $ 0.5,1&?69   .??5D      ? $	 	#FF000000??6#   $	
 0.0Q?65   ? 5E      $	 	#33000000??6#   $	
 0.5Q?65   ? 5F      $	 	#00000000??6#   $

 0.75Q?65   5G       J? BitmapEffect 5J      ?? 5K       ?? Radius$	 1.5Q?6#   5N      5O      5Q      