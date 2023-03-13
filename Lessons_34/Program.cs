//34. Написать программу замену элементов массива на противоположные
int[]array = {3,4,6,-1,-5,0,4,5,-5};

for (int i = 0; i < array.Length; i++)
{
   if(array[i] <= 0) 
    {
        array[i] = array[i] + (array[i] *(-2));
    }
    else
    {
        array[i] = array[i] - (array[i] + array[i]);
    }
System.Console.WriteLine(array[i] );
}