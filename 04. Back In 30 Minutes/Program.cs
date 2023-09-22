// See https://aka.ms/new-console-template for more information


int hours=int.Parse(Console.ReadLine());
int minutes=int.Parse(Console.ReadLine());

minutes += 30;

if (minutes>59)
{ 
    hours++;
    minutes -= 60;
}
if (hours>23)
{ hours = 0; }

Console.WriteLine($"{hours}:{minutes:d2}");
