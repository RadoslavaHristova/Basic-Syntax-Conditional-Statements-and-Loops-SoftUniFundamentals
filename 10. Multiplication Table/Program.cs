// See https://aka.ms/new-console-template for more information
  

int num=int.Parse(Console.ReadLine());

for (int i=1; i<=10;i++)
{ int n = num * i;
    Console.WriteLine($"{num} X {i} = {n}");
}
