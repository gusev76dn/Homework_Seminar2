// задача 10
Console.WriteLine("Введите трехзначное число: ");
string N1 = Console.ReadLine();
int N = int.Parse(N1);

if (N > 99 & N < 1000)
{
    Console.Write("вторая цифра: ");
    Console.WriteLine(N % 10);
}
else
{
    Console.WriteLine("это не трехзначное число");
}