// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("введите количество строк");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int columnsVol = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[linesVol, columnsVol];
FillArrayRandomNumbers(numbers);
Console.WriteLine();
Console.WriteLine("Массив до изменения");
PrintArray(numbers);

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < numbers.GetLength(1) - 1; z++)
        {
            if (numbers[i, z] < numbers[i, z + 1]) //для изменения сортировки поменять знак < на противоположный
            {
                int temp = 0;
                temp = numbers[i, z];
                numbers[i, z] = numbers[i, z + 1];
                numbers[i, z + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями");
PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("введите размер квадратного массива");
int massVol = Convert.ToInt32(Console.ReadLine());
int[,] numbers2 = new int[massVol, massVol];
FillArrayRandomNumbers2(numbers2);
PrintArray2(numbers2);
int minsum = Int32.MaxValue;
int indexLine = 0;

for (int i = 0; i < numbers2.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < numbers2.GetLength(1); j++)
    {
        sum = sum + numbers2[i, j];        
    }
    if (sum < minsum)
    {
        minsum = sum;
        indexLine++;
    }
}

Console.WriteLine("строка с наименьшей суммой елементов под номером: " + (indexLine) + ", с суммой елементов равной: " + (minsum));

void FillArrayRandomNumbers2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

void FillArrayRandomNumbers3(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5); //Для увеличения размера чисел в матрицах поменять число 5 на большее
        }
    }
}

void PrintArray3(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

int size = InputInt("размерность матриц: ");
int[,] matrixA = new int[size, size];
int[,] matrixB = new int[size, size];
FillArrayRandomNumbers3(matrixA);
FillArrayRandomNumbers3(matrixB);
int[,] matrixC = new int[size, size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
        }
    }
}
Console.WriteLine("Матрица - А");
PrintArray3(matrixA);
Console.WriteLine();
Console.WriteLine("Матрица - В");
PrintArray3(matrixB);
Console.WriteLine();
Console.WriteLine("Произведение матриц А*В");
PrintArray3(matrixC);

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int deep1 = InputInt4("Введите размерность 1: ");
int deep2 = InputInt4("Введите размерность 2: ");
int deep3 = InputInt4("Введите размерность 3: ");
int countNums = 89;

if (deep1 * deep2 * deep3 > countNums)
{
    Console.Write("Массив слишком большой");
    return;
}

int[,,] resultNums = Create3DMassive(deep1, deep2, deep3);

for (int i = 0; i < resultNums.GetLength(0); i++)
{
    for (int j = 0; j < resultNums.GetLength(1); j++)
    {
        for (int k = 0; k < resultNums.GetLength(2); k++)
        {
            Console.WriteLine($"[{i},{j},{k}] - {resultNums[i, j, k]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,,] Create3DMassive(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    int[] values = new int[countNums];
    int num
     = 10;
    for (int i = 0; i < values.Length; i++)
        values[i] = num
        ++;

    for (int i = 0; i < values.Length; i++)
    {
        int randomInd = new Random().Next(0, values.Length);
        int temp = values[i];
        values[i] = values[randomInd];
        values[randomInd] = temp;
    }

    int valueIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = values[valueIndex++];
            }
        }
    }
    return array;
}


int InputInt4(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

Console.WriteLine($"Задача 62: Заполните спирально массив 4 на 4.");

int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp6 = 1;
int q = 0;
int w = 0;

while (temp6 <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[q, w] = temp6;
  temp6++;
  if (q <= w + 1 && q + w < sqareMatrix.GetLength(1) - 1)
    w++;
  else if (q < w && q + w >= sqareMatrix.GetLength(0) - 1)
    q++;
  else if (q >= w && q + w > sqareMatrix.GetLength(1) - 1)
    w--;
  else
    q--;
}

WriteArray5(sqareMatrix);

void WriteArray5 (int[,] array)
{
  for (int q = 0; q < array.GetLength(0); q++)
  {
    for (int w = 0; w < array.GetLength(1); w++)
    {
      if (array[q,w] / 10 <= 0)
      Console.Write($" {array[q,w]} ");

      else Console.Write($"{array[q,w]} ");
    }
    Console.WriteLine();
  }
}