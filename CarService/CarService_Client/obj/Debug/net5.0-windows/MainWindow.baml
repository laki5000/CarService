   M S B A M L   `   `   `  ????L  HCarService_Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:CarService_ClientCarService_Client  5   	   "    CarService_Client.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:CarService_Client     5   	     ? Title$  B & L Car Service??5   	   $	??450??6'   $	??800??64   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $
??Auto ?6   ?? 5      $??* ?6   ?? 5      $
??Auto ?6   .+?5   
   ?? $??0??6   $??	Work List??6   $
??Bold"?61   $??
15,15,15,0q?6C   6Y   ?? 5   
   -   5         ??Name$ ClientListBox??5      $??1??6)   $??15q?66    ?? SelectionMode$ Single=?6B   6?   ?? 5   
   $??2??6    ?? Orientation$ 
Horizontal=?6"   $??Bottom=?6;   .+?5      ?? -   5        $??2??5      $??Refresh??6"   $??70??64   $??Right=?6?   $??
15,0,15,15q?6[   6o   ?? 5      -   5        $??2??5      $??Submit new work??6"   $	??100??6<   $??Right=?6H   $??
15,0,15,15q?6d   6x   ?? 5      -   5        $??2??5      $??Order by??6"   $??60??65   $??Right=?6@   $??
15,0,15,15q?6\   6p   ?? 5      -   5        $??2??5      $??	Search by??6"   $??60??66   $??Right=?6A   $??
15,0,15,15q?6]   6q   ?? 5      -   5         ??Name$ ComboBoxOrderBy??5      $??2??60   $??
15,0,15,15q?6=   .@?5      ?? $
??Date??6   ?? 5      $
??Name??6    ?? 
IsSelected$
 True??6.   ?? 5      $??Car Make??6   ?? 5      $??License Plate??6   ?? 5      $
??Year??6   ?? 5      $??Work Category??6   ?? 5       $??Short Description??6   ?? 5!      $??Severity??6   5"      ?? 5#      -   5        $ ComboBoxAsc??5#      $??2??6,   $??
15,0,15,15q?69   .@?5$      ?? $	??Asc??6   $
 True??6-   ?? 5%      $
??Desc??6   5&      ?? 5'      -   5         ??Name$ TextBoxSearchBy??5'      $??2??6/   $??
15,0,15,15q?6<   $	??150??6P   5(      5*      5+      