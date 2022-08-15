Console.WriteLine("Введите число: ");

int n = int.Parse(Console.ReadLine());

int FirstDigit = n/100;
int SecondDigit = (n - (FirstDigit*100 + n%10))/10;
Console.WriteLine("Второе число вашего числа: " + SecondDigit);

