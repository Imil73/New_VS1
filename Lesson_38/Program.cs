//38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
int[] array = new int[5];
Random random = new Random();
int number = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(0,99);
    System.Console.WriteLine(array[i]);
}

for (int i = 0; i < array.Length; i++)
{
    if((i %2) != 0)
    {
        number += array[i];
    }
}
System.Console.WriteLine($" Их: {number}");
