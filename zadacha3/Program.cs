// Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N.
// например: 3 -> 1,8,27. 5 -> 1,8,27,64,125.
Console.WriteLine("Введите число: ");
string? numberString = Console.ReadLine();
int number = int.Parse(numberString!);
int index = 1;
if(number<=0)
{
    Console.WriteLine("Введено некорректное число.");
}
while(number>=index)
{
    var result = Math.Pow(index,3);
    index++;
    Console.WriteLine(result);
}