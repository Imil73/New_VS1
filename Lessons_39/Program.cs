//40. В Указанном массиве вещественных чисел найдите разницу 
//между максимальным и минимальным элементом

int[] array = new int[5];
Random random = new Random();



for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(0,20);
    System.Console.WriteLine(array[i]);
}

int max = array[0];
int min = array[0];
for (int i = 1; i < array.Length; i++)
{
   if(array[i] > max) max = array[i];
   if(array[i] < min)
    min = array[i];
}
System.Console.WriteLine($"Разница: {max - min}");

