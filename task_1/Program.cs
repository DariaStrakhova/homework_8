/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

int NewMessage(string mensaje)
{
    Console.Write(mensaje);
    string answer = Console.ReadLine();
    int result = int.Parse(answer);
    return result;
}

int[,] GenerationMatrix(int row, int column, int min, int max)
{
    int[,] matrix = new int[row, column];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int count = 0;
        while (count != 3)
        {
            Console.WriteLine();
            count++;
        }

        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
    }
}

int[,] ArrangeMatrix(int[,] array, int row)
{
    for (int k = 0; k <= row; k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if (array[i, j] < array[i, j + 1])
                {
                    int max = array[i, j + 1];
                    array[i, j + 1] = array[i, j];
                    array[i, j] = max;
                }
            }
        }
    }

    return array;
}

int rows = NewMessage("Введите количество строк: ");
int columns = NewMessage("Введите количество столбцов: ");
int minNumber = NewMessage("Введите диапазон чисел ОТ: ");
int maxNumber = NewMessage("Введите диапазон чисел ДО: ");

int[,] Array = GenerationMatrix(rows, columns, minNumber, maxNumber);
PrintMatrix(Array);
Console.WriteLine();
int[,] orderArray = ArrangeMatrix(Array, rows);
PrintMatrix(orderArray);

