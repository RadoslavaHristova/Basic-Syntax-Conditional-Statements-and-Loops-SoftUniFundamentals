// See https://aka.ms/new-console-template for more information
int startNum=int.Parse(Console.ReadLine());
int endNum = int.Parse(Console.ReadLine());

/*· On the first line, print all numbers 
 * from the start of the sequence to the end inclusive.

· On the second line, print the sum of 
the sequence in the format: "Sum: {sum}".*/
int counter = 0;
for(int i=startNum; i<=endNum; i++)
{
    Console.Write($"{i} ");
    
    counter += i;
}
Console.WriteLine();
Console.WriteLine($"Sum: {counter}");