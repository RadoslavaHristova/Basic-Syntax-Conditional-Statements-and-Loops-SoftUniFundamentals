// See https://aka.ms/new-console-template for more information

//On the first line you will receive the type of day.
//On the second – the age of the person.

string day=Console.ReadLine();
int age =int.Parse(Console.ReadLine());
int price = 0;
/*Day / Age; 0 <= age <= 18 ; 18 < age <= 64 ; 64 < age <= 122

Weekday           12$              18$              12$
                 
Weekend           15$              20$              15$
                 
Holiday            5$              12$              10$*/

if (0 <= age && age <= 18)
{
if (day== "Weekday") { price = 12; }
else if (day== "Weekend") { price = 15; }
else if (day== "Holiday") { price = 5; }
    Console.WriteLine($"{price}$");
}
else if (18 < age&&age <= 64)
{
    if (day == "Weekday") { price = 18; }
    else if (day == "Weekend") { price = 20; }
    else if (day == "Holiday") { price = 12; }
    Console.WriteLine($"{price}$");
}
else if (64 < age&&age <= 122)
{
    if (day == "Weekday") { price = 12; }
    else if (day == "Weekend") { price = 15; }
    else if (day == "Holiday") { price = 10; }
    Console.WriteLine($"{price}$");
}
else { Console.WriteLine("Error!"); }




//Print the price of the ticket according to the table or "Error!",
//if the age is not in the tablе.