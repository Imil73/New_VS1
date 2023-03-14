//36. Задать массив, заполнить случайными положительными трёхзначными числами.
// Показать количество нечетных\четных чисел
int[] array = new int [10];
Random random = new Random();
int quantityHonest = 0;
int quantityOdd = 0;


for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next (100,999);
    System.Console.WriteLine(array[i]);
}

for (int i = 0; i < array.Length; i++)
{
    if((array[i] %2) == 0) 
    {
        quantityHonest = quantityHonest + 1;
    }
    else
    {
        quantityOdd = quantityOdd + 1;
    }
}
System.Console.WriteLine($"Количество чётных чисел:{quantityHonest}");
System.Console.WriteLine($"Количество нечётных чисел:{quantityOdd}");

