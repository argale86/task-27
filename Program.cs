// найти сумму цифр во введённом числе
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int dlina = (int)Math.Log10(number) + 1;
int buf = dlina-1;
int buf1 = 0;
int sum = 0;
for (int count = 0; count < dlina; count++)
{
    buf1 = (int)Math.Pow(10,buf);
    sum = sum+number/buf1;
    number = number - (number/buf1)*buf1;
    buf--;
}
Console.WriteLine ("Сумма цифр числа = " + sum);