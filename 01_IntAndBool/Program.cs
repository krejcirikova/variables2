/* 
 * Následující příkaz vytvoří proměnnou v paměti. 
 * Každá proměnná má svůj typ a svůj název.
 * Typ - určuje jaké hodnoty může nabývat
 * Název - je unikátní označení pro danou proměnnou (v jednom programu nesmí být dvě proměnné stejného názvu)
 */
int wholeNumber;

/*
 * Pro přiřazení hodnoty se používá "="
 */
wholeNumber = 5;

/* 
 * Pro přístup k hodnotě stačí použít název proměnné
 * Spusťte program a ověřte výstup.
 */
Console.WriteLine("Value in wholeNumber is: " + wholeNumber);

/*
 * Vytvořte novou proměnnou typu int. 
 * Přiřaďte do ní Vaše oblíbené číslo.
 * Vypište s pomocí nové proměnné na obrazovku, jaké je Vaše oblíbené číslo
 * Nezapomeňte používat "Tab"
 */



// Datový typ bool (boolean) může nabývat pouze dvou hodnot: true/false. Odkomentujte a zkuste.
/*
bool isEqual;
isEqual = true;
Console.WriteLine("Value in isEqual is: " + isEqual);
*/

// Boolean používáme k uchování výsledku nějakého ověření. Např. jestli je uživatel admin, jestli je mu 18 let, atd...
// Pro porovnání ale musíme použít "==", protože rovnítko už je zabrané pro přiřazení
/*
isEqual = wholeNumber == 18;
Console.WriteLine("Is user 18 years old? " + isEqual);
*/


/*
 * Vytvořte novou proměnnou typu bool.
 * Uložte do ní, jesteli je Vaše oblíbené číslo rovno 7
 * Výsledek vypište na obrazovku
 */



// Vytvoření (deklarace) proměnné a přiřazení jsou dvě různé akce, ale často je uvidíte na jednom řádku
// Na dalším řádku deklaruji novou proměnnou a rovnou do ní přiřazuji hodnotu.
// Než si program spustíte, tipněte si výsledek
/*
int sumOfNumbers = 4 + 4;
Console.WriteLine("Value in sumOfNumbers is: " + sumOfNumbers);
*/


/* 
 *           -- DŮLEŽITÉ --
 * 
 * Při přiřazení se vždy nejprve vyřeší pravá strana od rovnítka. 
 * Teprve výsledek se přiřadí do proměnné.
 * Zkuste spustit následující blok.
 */

/*
int result = 5;
result = 2 * result;
Console.WriteLine("Value in result is: " + result);
*/

/*
 * Vidíte, že hodnota v "result" je nakonec 10.
 * Nejprve se vyřeší pravá strana (v tu chvíli je result == 5).
 * A teprve výsledek (2 * 5) se přiřadí a PŘEPÍŠE původní hodnotu 
 */

// Priorita operátorů a závorky jsou stejné jako v matematice
/*
int functionResult = 2 * ((3 + 3) / (4 - 2));
Console.WriteLine("Value in functionResult is: " + functionResult);
*/


// Pokud bych chtěl tedy zvýšit hodnotu v proměnné o 1, můžu to udělat následovně.
/*
int increment = 0;
increment = increment + 1;
Console.WriteLine("Value in increment is: " + increment);
*/


/*
 * Vytvořte novou proměnnou int s hodnotou 7.
 * Přičtěte k ní 63.
 * vynásobte ji číslem 4.
 * vydělte ji číslem 240.
 * Výsledek vypište na obrazovku. 
 * Měl by být roven 1.
 */