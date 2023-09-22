// See https://aka.ms/new-console-template for more information


int num=int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 1;i <= num;i++)
{ int current = i * 2 - 1;
    sum += current;
    Console.WriteLine(current);
}
Console.WriteLine($"Sum: {sum}");
