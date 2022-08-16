// Напишите программу, которая принимает на вход пятизначное число и проверяет является ли оно полиндромом.
//Например: 14212 - нет; 23432 - да; 12821 - да.
Console.WriteLine("Введите пятизначное число: ");
string? numberString = Console.ReadLine();
int number = int.Parse(numberString!);
if (number<=0)
{
    Console.WriteLine("Введено некорректное число");
}

if (((number/10000)==(number%10)) && (((number/1000)%10)==((number%100)/10)))
{
    Console.WriteLine("Число является полиндромом.");
}
else
{
    Console.WriteLine("Число не является полиндромом.");
}
