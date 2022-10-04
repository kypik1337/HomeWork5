//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


int[] Array = new int[5];
int count = 0 ;


void PrintArray (int[] Array)
    {
        for (int i = 0; i < Array.GetLength(0); i++)
        {
            Console.WriteLine(Array[i]);
        }
    }

void FillArray (int[] Array)
    {
        for (int i = 0, d = 0; i < Array.GetLength(0); i++)
        {
            Array[i] = new Random().Next(100, 1000) ;
            Array[i] = Array[i] / 100;
            //Console.WriteLine(Array[i]);
           if (Array[i] % 2 == 0)
            {
                Console.WriteLine($"{Array[i]} - четное");
                d++;
            }
            count = d;
         }
         
    }

    FillArray(Array);
    Console.WriteLine($"количество четных элементов:-> {count}");
   