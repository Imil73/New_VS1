//29. Написать программу вычисления произведения чисел от 1 до N
System.Console.WriteLine("Задайте число N: ");
int number = int.Parse(Console.ReadLine());
int result = 1;

for (int i = 2; i < number +1; i++)
{
    result = result * i;
}
System.Console.WriteLine(result);
