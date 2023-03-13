//33. Задать массив из 12 элементов, заполненных числами из [0,9]. 
//Найти сумму положительных/отрицательных элементов массива
int[] array = {4,2,-5,0,-4,8,-1,3,6,-2,4,-6};
int sumMinus =0;
int sumPlus = 0;
for (int i = 0; i < array.Length; i++)
{
   if(array[i] < 0)
   { sumMinus += array[i];}
   else
   {sumPlus += array[i];}
}
System.Console.WriteLine(sumPlus);
System.Console.WriteLine(sumMinus);