# CarService
Egy autószerelő műhelyben működő kliens - szerver alkalmazás.

A projekt a következőket tartalmazza:

Munka felvevő kliens - .NET WPF

Az érkező ügyfelek adatait tudja felvenni

Látja a felvett munkákat


    Az adatok táblázatos formában megjelenítve
    Indításkor betölti a korábbi adatokat
    Adatok frissítésére alkalmas gomb
    A sorok a különböző kategóriák szerint rendezhetőek növekvő vagy csökkenő sorrend (dátum, abc)
    Keresés lehetőség az összes attribútum alapján. Validáció is szükséges az input mezőkre.
    Munkaóra esztimáció megjelenítése (API számolja)
    Egy kiválasztott munka adatait
        Meg tudja nézni
        Módosítani tudja
        
Autószerelő kliens - .NET WPF

Látja a felvett munkákat

    Az adatok táblázatos formában megjelenítve
    Indításkor betölti a korábbi adatokat
    Adatok frissítésére alkalmas gomb
    A sorok a különböző kategóriák szerint rendezhetőek növekvő vagy csökkenő sorrendben (dátum, abc)
    Keresés lehetőség az összes attribútum alapján
    Munkaóra esztimáció megjelenítése (API számolja)
    Ki tud választani egy munkát
        Aminek az állapotát változtathatja
            Felvett munka -> Elvégzés alatt -> Befejezett
            
Szerver - .NET WEB API alkalmazás (önálló konzol alkalmazás)

Tárolja és szolgáltatja a bevitt adatokat

	Az adatokat Json formátumban tárolja.
	A munkaóra esztimációt kiszámolja.
