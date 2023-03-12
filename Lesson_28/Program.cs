//28. Подсчитать сумму цифр в числе
System.Console.WriteLine("Задайте число: ");
int number = int.Parse(Console.ReadLine());
int i = 0;

while(number != 0)
{    
     i += number %10;
     number = number / 10;
}
System.Console.WriteLine(i);

