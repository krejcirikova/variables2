/*
 * Datový typ string může obsahovat text.
 * Text je vždy v dvojitých uvozovkách
 */
string greeting = "Well hello there!";
Console.WriteLine(greeting);

// Vytvořte novou proměnnou typu string, uložte do ní své jméno a vypište na obrazovku.


/*
 * C# podporuje celou řadu příkazů pro práci se stringem
 * ".Length" vrátí délku daného textu
 */
/*
int characterLength = greeting.Length;
Console.WriteLine("The number of characters in greeting is " + characterLength);
*/

/*
 * Předsavte si klubovou kartičku, která má místo ve jméně jen na 5 písmen.
 * Vytvořte proměnnou typu int, kam uložíte délku Vašeho jména.
 * Vytvořte proměnnou typu bool, kam uložíte, jestli se Vaše jméno vejde na kartičku (x < 6).
 * Vypište výsledek na obrazovku.
 */



/*
 * Pomocí "+" můžeme texty spojovat 
 */
/*
string name = "Mr. Grievous";
string space = " ";
string sentence = greeting + space + name;
Console.WriteLine(sentence);
*/



/*
 * Pozor při kombinování datových typů.
 * "+" dělá jiné věci pro text a pro číslo
 * Pořádně prostudujte následující příkazy
 * Pamatujte, že při stejné prioritě operátorů se postupuje zleva doprava
 */

/*
Console.WriteLine("Text" + 1 + 1);
Console.WriteLine(1 + 1 + "Text");
*/

/*
 * Program dokáže číslo v pohodě převést na text.
 * Proto nám dovolí "sčítat" i zdánlivě nesouvisející věci.
 * Jen výsledek je potom následující:
 * 
 *    int + int = int
 * string + int = string
 * 
 * Někdy to pomůže. Někdy to dokáže zavařit.
 * Vždy si ale můžeme pomoci závorkami. Fungují jak v matice.
 */

/*
Console.WriteLine(1 + (1 + "Text"));
*/

// Upravte jen s pomocí kulatých závorek poslední řádek tak, aby vypisoval stejnou adresu
/*
string zipCode = "76001 ";
string street = "Kotěrova ";
int postalNumber = 1488;

Console.WriteLine(zipCode + street + postalNumber);
Console.WriteLine(7 + 6 + 0 + 0 + 1 + " " + street + postalNumber);
*/