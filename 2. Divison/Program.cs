// See https://aka.ms/new-console-template for more information


int num=int.Parse(Console.ReadLine());
int currentMax = 0;

if (num % 2 == 0) { currentMax = 2; }
 if (num % 3 == 0) { currentMax = 3; }
 if (num % 6 == 0) { currentMax = 6; }
 if (num % 7 == 0) { currentMax = 7; }
 if (num % 10 == 0) { currentMax = 10; }
 

if (currentMax == 0) { Console.WriteLine("Not divisible"); }
else { Console.WriteLine($"The number is divisible by {currentMax}"); }





