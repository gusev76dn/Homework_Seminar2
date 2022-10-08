// задача 13
Console.WriteLine("Введите число: ");
string userNumber = Console.ReadLine();
int num = int.Parse(userNumber);
int numberLength = userNumber.Length;

if (num < 0) numberLength = userNumber.Length-1;

if (numberLength >= 3 && num > 0)
{
    Console.WriteLine("третья цифра числа: " + userNumber[2]);
}
else if (numberLength >= 3 && num < 0)
{
    Console.WriteLine("третья цифра числа: " + userNumber[3]);
}
else
{
    Console.WriteLine("в числе нет третьей цифры");
}
