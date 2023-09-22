/*вход:
 · The amount of money John has – double

· The count of students – int

· The price of lightsabers for a single saber – double

· The price of robes for a single robe – double

· The price of belts for a single belt – double
 */
double johnMoney=double.Parse(Console.ReadLine());
int studentsQty=int.Parse(Console.ReadLine());
double lightsaberPrice=double.Parse(Console.ReadLine());
double robePrice = double.Parse(Console.ReadLine());
double beltPrice = double.Parse(Console.ReadLine());
/*пресмятаме цената за всичко като:
 · Lightsabres - buy 10% more (taken from the students' count),
Math.Ceiling

· Every sixth belt is free.
 */
double allLightsabersPrice = Math.Ceiling(studentsQty * 1.1) * lightsaberPrice;
double allRobesPrice=studentsQty * robePrice;
int freeBelts = studentsQty / 6;
double allBeltsPrice=(studentsQty-freeBelts)*beltPrice;
/*пресмтаме дали парите му стигат
  Calculate if John has enough money 
or how much more money he needs
 */
double totalPrice = allBeltsPrice + allLightsabersPrice + allRobesPrice;
/*изход
 · If the calculated price is less or equal to the money John has:

o "The money is enough - it would cost {the cost of the equipment}lv."

· If the calculated price is more than the money John has:

o " John will need {neededMoney}lv more."

· All prices must be rounded :F2
 */
double neededMoney = totalPrice - johnMoney;
if (johnMoney>=totalPrice)
{ Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv."); }
else { Console.WriteLine($" John will need {neededMoney:f2}lv more."); }
