//27. Определить количество цифр в числе;
System.Console.WriteLine("Задайте число: ");
int number = int.Parse(Console.ReadLine());
int i = 0;

while(number != 0)
{
     number = number / 10;
     i += 1;
}
System.Console.WriteLine(i);






