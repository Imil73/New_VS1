//30. Показать кубы чисел, заканчивающихся на четную цифру
System.Console.WriteLine("Задайте число N: ");
int number = int.Parse(Console.ReadLine());
int result =1;
 
result = number % 2;
if( result ==0 )
{
    System.Console.WriteLine($"{number * number * number}");
}
else
{
    System.Console.WriteLine("Число не подходит");
}