// задача 15

Console.WriteLine("Ввкдите желаемый день недели, от 1 до 7: ");
string value = Console.ReadLine();
int a = int.Parse(value);
if (a == 1)
{
    Console.WriteLine ("Понедельник - рабочий день");
}
else if (a == 2)
{
    Console.WriteLine("Вторник - рабочий день");
}    
else if (a == 3)
{
    Console.WriteLine("Среда -рабочий день");
}
else if (a == 4)
{
    Console.WriteLine("Черверг - рабочий день");
}    
else if (a == 5)
{
    Console.WriteLine("Пятница - рабочий день");
}
else if (a == 6)
{
    Console.WriteLine("Суббота - выходной день");
}
else if (a == 7)
{
    Console.WriteLine("Воскресенье - выходной день");
}
