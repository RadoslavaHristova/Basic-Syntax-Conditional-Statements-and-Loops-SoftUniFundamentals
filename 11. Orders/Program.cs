//вход : int N – the count of orders the shop will receive.
using System.Diagnostics;

int ordersQty=int.Parse(Console.ReadLine());
double totalOrdersPrice = 0;
//правим цикъл които се върти според броя на поръчките 
for (int i = 1; i <= ordersQty; i++)
{
    /*при всяко завъртане(за всяка поръчка)
     получаваме както следва:
    o Price per capsule – double

    o Days – int

    o Capsules count – int
     */
    double capsulePrice=double.Parse(Console.ReadLine());
    int days = int.Parse(Console.ReadLine());
    int capsulesQty=int.Parse(Console.ReadLine());
    //смятаме цената за всяка поръчка по формулата 
    // ((daysInMonth * capsulesCount) * pricePerCapsule)
    double orderPrice = ((days * capsulesQty) * capsulePrice);
    totalOrdersPrice += orderPrice;
    // ->принтираме: · "The price for the coffee is: ${price}"
    Console.WriteLine($"The price for the coffee is: ${orderPrice:F2}");

}
Console.WriteLine($"Total: ${totalOrdersPrice:f2}");
//когато цикъла приключи принтираме тотала на всички поръчки
// "Total: ${totalPrice}"   (трябва брояч!)


