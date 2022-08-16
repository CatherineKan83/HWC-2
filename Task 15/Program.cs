Console.WriteLine("Введите число и, возможно, я Вас обрадую.");
int D = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("~>>" + D);
int i = 7;
if ((D%i ==6) | (D%i==0))
{
    Console.WriteLine("Да!!! Выходной! Йэээ, живём!");
}
else
{
    Console.WriteLine("Нет. Сожалею,но это будний день...");
}
