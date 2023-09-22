// See https://aka.ms/new-console-template for more information


/*вход от конзолата 
 · A count of people 

· Type of the group (Students, Business or Regular).

· The day of the week  (Friday, Saturday or Sunday)*/
int peopleQty = int.Parse(Console.ReadLine());
string groupType=Console.ReadLine();
string day=Console.ReadLine();
double price = 0;
/*изчисляваме колко пари ще плати ЦЯЛАТА група
 като цената за един човек е:

              Friday   Saturday   Sunday

Students       8.45      9.80     10.46
              
Business      10.90      15.60    16.00
              
Regular       15.00      20.00    22.50*/
if (groupType== "Students")
{
    if(day== "Friday") { price = 8.45; }
    else if (day == "Saturday") { price = 9.80; }
    else if (day == "Sunday") { price = 10.46; }
}
else if (groupType == "Business")
{
    if (day == "Friday") { price = 10.90; }
    else if (day == "Saturday") { price = 15.60; }
    else if (day == "Sunday") { price = 16.00; }
}
else if (groupType == "Regular")
{
    if (day == "Friday") { price = 15.00; }
    else if (day == "Saturday") { price = 20.00; }
    else if (day == "Sunday") { price = 22.50; }
}

double groupPrice = peopleQty * price;

/*проверяваме броя на хората и прилагаме отстъпка ако е необходимо
 
· Students – if the group is 30 or more people
, you should reduce the total price by 15%.

· Business – if the group is 100 or more people
, 10 of the people stay for free.

· Regular – if the group is between 10 and 20 people (both inclusively)
, reduce the total price by 5%.*/
if(groupType== "Students")
{
    if (peopleQty >= 30) { groupPrice = groupPrice - groupPrice* 0.15; }
}
else if (groupType == "Business")
{
    if (peopleQty >= 100) { groupPrice = (peopleQty-10) * price; }
}
else if (groupType == "Regular")
{
    if (peopleQty >= 10&&peopleQty<=20) { groupPrice = groupPrice - groupPrice * 0.05; }
}

/*печатаме на конзолата :
                           "Total price: {price}"
The price should be formatted to the second decimal point.*/

Console.WriteLine($"Total price: {groupPrice:f2}");