//26. Возведите число А в натуральную степень B используя цикл
System.Console.WriteLine("Задайте число А: ");
int number = int.Parse(Console.ReadLine());
System.Console.WriteLine("Задайте степень: ");
int degree = int.Parse(Console.ReadLine());
int work = number * number;

for (int i = 2; i < degree; i++)
{
     work = work * number;
}

System.Console.WriteLine(work);
