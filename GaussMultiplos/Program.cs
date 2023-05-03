using System.Globalization;

List<int> numbers = new List<int>();

for(int i = 100; i > 0; i--)
{
    numbers.Add(i);
}
foreach(int count in numbers)
{
    Console.WriteLine(count % 5 == 0 ? "Renan" : count); 
}
Console.ReadLine();