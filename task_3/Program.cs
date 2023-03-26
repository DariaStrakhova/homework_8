/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

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

int[,] Composition(int[,] oneArray, int[,] twoArray)
{
    int[,] newArray = new int[oneArray.GetLength(0), twoArray.GetLength(1)];

    if ((oneArray.GetLength(0) * oneArray.GetLength(1)) == (twoArray.GetLength(0) * twoArray.GetLength(1)))
    {
        for (int i = 0; i < oneArray.GetLength(0); i++)
        {
            for (int j = 0; j < twoArray.GetLength(1); j++)
            {
                for (int k = 0; k < twoArray.GetLength(0); k++)
                {
                    newArray[i, j] += oneArray[i, k] * twoArray[k, j];
                }
            }
        }
    }
    return newArray;
}

Console.WriteLine("Первая матрица");
int onerows = NewMessage("Введите количество строк: ");
int onecolumns = NewMessage("Введите количество столбцов: ");
int onemin = NewMessage("Введите диапазон чисел ОТ: ");
int onemax = NewMessage("Введите диапазон чисел ДО: ");

Console.WriteLine();

Console.WriteLine("Вторая матрица");
int tworows = NewMessage("Введите количество строк: ");
int twocolumns = NewMessage("Введите количество столбцов: ");
int twomin = NewMessage("Введите диапазон чисел ОТ: ");
int twomax = NewMessage("Введите диапазон чисел ДО: ");

int[,] oneMatrix = GenerationMatrix(onerows, onecolumns, onemin, onemax);
PrintMatrix(oneMatrix);
Console.WriteLine();
int[,] twoMatrix = GenerationMatrix(tworows, twocolumns, twomin, twomax);
PrintMatrix(twoMatrix);
Console.WriteLine();
int[,] compositionMatrix = Composition(oneMatrix, twoMatrix);
PrintMatrix(compositionMatrix);
