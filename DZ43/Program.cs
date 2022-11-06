// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) PointIntersectionLines

//Console.Write("Заданы значения прямых: ");

double[,] arrayPointsLine = new double[2, 2];
double[] arrayPointsLineIntersection = new double[2];



FillArray();
PointIntersectionLines(arrayPointsLine);
PrintArray(arrayPointsLine);


void FillArray()
{
    for (int i = 0; i < arrayPointsLine.GetLength(0); i++)
    {
        Console.WriteLine($"Введите значение для {i + 1}-ой прямой: ");
        for (int j = 0; j < arrayPointsLine.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"k: ");
            else Console.Write($"b: ");
            arrayPointsLine[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

double[] CompareLines(double[,] arrayPointsLine)
{
    arrayPointsLineIntersection[0] = (arrayPointsLine[1, 1] - arrayPointsLine[0, 1]) / (arrayPointsLine[0, 0] - arrayPointsLine[1, 0]);
    arrayPointsLineIntersection[1] = arrayPointsLineIntersection[0] * arrayPointsLine[0, 0] + arrayPointsLine[0, 1];
    return arrayPointsLineIntersection;
}

void PointIntersectionLines(double[,] arrayPointsLine)
{
    if (arrayPointsLine[0, 0] == arrayPointsLine[1, 0] && arrayPointsLine[0, 1] == arrayPointsLine[1, 1])
    {
        Console.Write($"Прямые совпадают");
    }
    else if (arrayPointsLine[0, 0] == arrayPointsLine[1, 0] && arrayPointsLine[0, 1] != arrayPointsLine[1, 1])
    {
        Console.Write($"Прямые параллельны");
    }
    else
    {
        CompareLines(arrayPointsLine);
        Console.Write($"Точка пересечения прямых ->({arrayPointsLineIntersection[0]}, {arrayPointsLineIntersection[1]})\n");
    }
}

void PrintArray(double[,] arrayPointsLine)
{
    for (int i = 0; i < arrayPointsLine.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < arrayPointsLine.GetLength(1); j++)
        {
            if (j < arrayPointsLine.GetLength(1) - 1) Console.Write($"{arrayPointsLine[i, j], 1}, ");
            else Console.Write($"{arrayPointsLine[i, j], 1} ");
        }
        Console.WriteLine(" ");
    }
}