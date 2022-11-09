// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());

// double[,] FillTheArray(int m, int n)
// {
//     double[,] array = new double[m,n];
//     for (int i=0; i<array.GetLength(0); i++)
//     {
//         for (int j=0; j<array.GetLength(1); j++)
//         {
//             array[i,j] =Convert.ToDouble( new Random().Next(-30,31)) / 10;
//             Console.Write($"{array[i,j]} \t");
//         }
//         Console.Write($"\n");
//     }

// return array;
// }

// double[,] newArray=FillTheArray(m,n);

// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве,
// и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] FillTheArray(int m, int n)
// {
//     int[,] array = new int[m,n];
//     for (int i=0; i<array.GetLength(0); i++)
//     {
//         for (int j=0; j<array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(-30,31);
//             Console.Write($"{array[i,j]} \t");
//         }
//         Console.Write($"\n");
//     }

// return array;
// }

// void FindElement(int x, int[,] array)
// {
// int coordI = -1;
// int coordJ = -1;
// int toFind = x;
// for (int i=0; i<array.GetLength(0); i++)
//     {
//         for (int j=0; j<array.GetLength(1); j++)
//         {
//             if (array[i,j] == toFind) 
//             {
//                 coordJ = j;
//                 coordI = i;
//                 break;
//             }
//         }
//     }
// if ( coordJ == -1) Console.WriteLine($"Такого элемента нет"); 
// else Console.WriteLine($"Элемент расположен на строке {coordI + 1}, столбце {coordJ + 1}");
// }

// int[,] newArray=FillTheArray(m,n);

// Console.WriteLine("Введите искомый элемент");
// int x = Convert.ToInt32(Console.ReadLine());

// FindElement(x, newArray);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в 
// каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] FillTheArray(int m, int n)
{
    int[,] array = new int[m,n];
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(-30,31);
            Console.Write($"{array[i,j]} \t");
        }
        Console.Write($"\n");
    }

return array;
}

void Avg(int[,] array)
{
double count = 0;
for (int j=0; j<array.GetLength(1); j++)
    {
        for (int i=0; i<array.GetLength(0); i++)
        { 
           count = count + array[i,j];
        }
        Console.WriteLine($"Среднее арифметическое столбца {j + 1} равно {count / array.GetLength(0) }");
        count = 0;
    }
}

int[,] newArray=FillTheArray(m,n);

Avg(newArray);