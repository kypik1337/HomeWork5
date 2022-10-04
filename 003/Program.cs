//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
int[] Array = new int[5];
FillArray(Array);
PrintArray(Array);
int max = Int32.MinValue;
int min = Int32.MaxValue;

for (int z = 0; z < Array.Length; z++)
{
    if (Array[z] > max)
        {
            max = Array[z];
        }
    if (Array[z] < min)
        {
            min = Array[z];
        }
}

Console.WriteLine($"Максимальное = {max}, значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным = {max - min}");

void FillArray(int[] Array)
{
    for(int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(1,10);
    }
}
void PrintArray(int[] Array)
{
    for(int i = 0; i < Array.Length; i++)
    {
        Console.Write(Array[i] + " ");
    }
    Console.WriteLine();
}
