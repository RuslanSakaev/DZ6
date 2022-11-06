// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//Console.Write("Заданы значения прямых: ");

double[,] arrayPointsLine = new double[2, 2];
double[] arrayPointsLineIntersection = new double[2];

FillArray();
PointIntersectionLines(arrayPointsLine);
PrintArray(arrayPointsLine);

void PrintArray(double[,] arrayPointsLine)
{
    for (int i = 0; i < arrayPointsLine.GetLength(0); i++) //b1 = 2, k1 = 5, b2 = 4, k2 = 9
    {
        Console.Write($"k{i+1} = ");
        for (int j = 0; j < arrayPointsLine.GetLength(1); j++)
        {
            if (j < arrayPointsLine.GetLength(1) - 1) Console.Write($"{arrayPointsLine[i, j], 1}, b{i+1} = ");
            else Console.Write($"{arrayPointsLine[i, j], 1} ");
        }
        
    }
}

void FillArray()
{
    for (int i = 0; i < arrayPointsLine.GetLength(0); i++)
    {
        Console.WriteLine($"Введите значение для {i + 1}-ой прямой: ");
        for (int j = 0; j < arrayPointsLine.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"k{i+1}: ");
            else Console.Write($"b{i+1}: ");
            arrayPointsLine[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
    //Console.WriteLine(arrayPointsLine[0, 1]);
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
        Console.Write($"Точка -> ({arrayPointsLineIntersection[0]}; {arrayPointsLineIntersection[1]}) пересечение прямых со значениями ");
    }
}