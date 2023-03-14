//Найти произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int[] array = {5,6,3,8,5,9,1,2};
int last = array.Length-1; 
int work = 0;

for (int i = 0; i < array.Length /2; i++)
{
  work = array[i] * array[last];
  last --;  
  System.Console.WriteLine(work);
}