/* Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

int NewMessage(string mensaje)
{
    Console.Write(mensaje);
    string answer = Console.ReadLine();
    int result = int.Parse(answer);
    return result;
}

int[,,] GenerationMatrix(int min, int max)
{
    int[,,] matrix = new int[2, 2, 2];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = new Random().Next(min, max + 1);
            }
        }
    }

    return matrix;
}

void PrintMatrix(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}{(i, j, k)}\t");
            }
        }
    }
}


int Min = NewMessage("Введите диапазон чисел ОТ: ");
int Max = NewMessage("Введите диапазон чисел ДО: ");

int[,,] Array = GenerationMatrix(Min, Max);
PrintMatrix(Array);