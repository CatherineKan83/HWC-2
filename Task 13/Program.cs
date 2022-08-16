Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int M=N;

int i = 0;
if (M>100)
{
    do
    {
        i++;
        M/=10;
    }  while (M>99);
    int ThirdDigit = (N/Convert.ToInt32(Math.Pow(10,i-1)))-((N/Convert.ToInt32(Math.Pow(10,i))*10));
    Console.WriteLine("Третья цифра: " + ThirdDigit);
}
else
{
    Console.WriteLine("Третья цифра отсутствует.");
}