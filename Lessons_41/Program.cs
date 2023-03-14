//41. Выяснить являются ли три числа сторонами треугольника 
int a = 5;
int b = 1;
int c = 3;

if(a < (b + c) && a > (b - c))
{
System.Console.WriteLine("Стороны треугольника");
}
else
{
    System.Console.WriteLine("Не являются сторонами треугольника");
}


