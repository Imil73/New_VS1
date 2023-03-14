//35. Определить, присутствует ли в заданном массиве, некоторое число 
// Например 23.
System.Console.WriteLine("Какое число нужно искать в массиве: ");
int number = int.Parse(System.Console.ReadLine());
int[]array = {34,5,47,23,-9,60,0,-35,26};

for (int i = 0; i < array.Length; i++)
{
    if(array[i] == number)
    System.Console.WriteLine("Заданное число есть.");
    if(array[i] == number)
    break;
    if(array[i] != number && i == array.Length - 1)
    System.Console.WriteLine("Заданное число отсуствует.");
}
//System.Console.WriteLine("Заданное число отсуствует.");
