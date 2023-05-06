using System.Globalization;

List<int> numbers = new List<int>();
int sum = 0;

for(int i = 100; i > 0; i--)
{
    numbers.Add(i); //populando a lista com os numeros do laço for
}
foreach(int count in numbers) { //laço que percorre toda a lista

    sum = count % 2 == 0 ? sum + count : sum; //Verifica se o número(count) é par, se sim, soma ele à variavel sum
    Console.WriteLine(count % 5 == 0 ? "Renan" : count); //Verifica se o número(count) é multiplo de 5, se sim, imprime Renan
}

Console.WriteLine($"\nA soma dos números pares dessa sequência é: {sum}");
Console.ReadLine();
