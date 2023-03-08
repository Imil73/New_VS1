//Найти сумму чисел от 1 до А
Console.WriteLine("Введите число А: ");
int number = int.Parse(Console.ReadLine());
int firstElement = 1;
int sum = 0;

for (int i = 0; i < number; i++)
{
    sum = sum + firstElement;
    firstElement += 1;
}
Console.WriteLine(sum);

Console.ReadLine();

