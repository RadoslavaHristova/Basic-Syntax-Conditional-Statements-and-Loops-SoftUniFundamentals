// See https://aka.ms/new-console-template for more information


int num = int.Parse(Console.ReadLine());
int multi=int.Parse(Console.ReadLine());
for (int i = multi; i <= 10; i++)
{
    int n = num * i;
    Console.WriteLine($"{num} X {i} = {n}");
}
if (multi > 10)
{
    int n = num * multi;
    Console.WriteLine($"{num} X {multi} = {n}");
}