﻿string number = Console.ReadLine();
int sum = 0;

for (int i=0;i<number.Length;i++)
{
    int current = int.Parse(number[i].ToString());
    int factoriel = 1;
    for (int j=1;j<=current;j++)
    { factoriel *= j; }
    sum += factoriel;
}
if (sum==int.Parse(number))
{ Console.WriteLine("yes"); }
else { Console.WriteLine("no"); }
