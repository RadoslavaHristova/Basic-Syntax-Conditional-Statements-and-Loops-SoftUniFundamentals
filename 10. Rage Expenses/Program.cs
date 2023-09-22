/*вход:
 · On the first input line – lost games count – int

· On the second line – headset price – double

· On the third line – mouse price – double

· On the fourth line – keyboard price – double

· On the fifth line – display price – double
 */
int lostGames = int.Parse(Console.ReadLine());
double headsetPrice=double.Parse(Console.ReadLine());
double mousePrice = double.Parse(Console.ReadLine());
double keyboardPrice = double.Parse(Console.ReadLine());
double displayPrice = double.Parse(Console.ReadLine());

int headsetQty=0, mouseQty=0, keyboardQty=0, displayQty=0;
int gameCounter = 0;
/*пресмтаме колко пъти е счупил нещо 
 * 
 Every 2 lost game,  headset.

Every 3 lost game,  mouse.

When trashes both his mouse and headset in the same += keyboard.

Every 2 time, when trashes his keyboard += display.*/
for (int i = 1; i <= lostGames; i++)
{
    gameCounter++;
    if (gameCounter % 2 == 0) { headsetQty++; }
    if (gameCounter % 3 == 0) { mouseQty++; }
    if (gameCounter % 6 == 0)
    {
        keyboardQty++;
        if (keyboardQty % 2 == 0)
        { displayQty++; }
    }
}
  double total=(headsetPrice*headsetQty)+(mousePrice*mouseQty)+(keyboardPrice*keyboardQty)+(displayPrice*displayQty);

Console.WriteLine($"Rage expenses: {total:f2} lv.");


//пресмятаме цената за всичко счупено

/*изход 
  total expenses: "Rage expenses: {expenses} lv." 
*/
