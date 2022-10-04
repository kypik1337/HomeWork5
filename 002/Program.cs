//Задача 36: Задайте одномерный массив, заполненный случайными числами.
 //Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
int[] Array = new int[5];
FillArray(Array);
PrintArray(Array);
int sum = 0;
for (int k = 0; k < Array.Length; k+=2)
sum = sum + Array[k];
Console.WriteLine($"всего {Array.Length} чисел, сумма элементов на нечётных позициях = {sum}");
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

