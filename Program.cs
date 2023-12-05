// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую
//  и последнюю строку массива.

// Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.

// Задача 4*(не обязательная): Задайте двумерный массив из целых чисел. Напишите программу,
//  которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
//   Под удалением понимается создание нового двумерного массива без строки и столбца


// // Задача 1

// Console.Clear();

// int[,] CreateMatrix(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];

//     Random rand = new Random();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             matrix[i, j] = rand.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }


// void PrintMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]}\t"); 
//         }
//         Console.WriteLine();
//     }
// }


// void PrintDesiredElement(int[,] matr, int row, int col)
// {
//     try
//     {
//         Console.Write($"Искомый элемент массива строка [ {row} ] столбец [ {col} ] = {matr[row, col]}");
//     }
//     catch (System.IndexOutOfRangeException ex)
//     {
//         Console.WriteLine("Нет запрашиваемого элемента в массиве: " + ex.Message);
//     }
// }


// int[,] res = CreateMatrix(5, 5, 0, 10);// задаем двумерный массив и рандомный диапазон значений

// Console.Write($"Введите искомую строку от 0 до {res.GetLength(0) - 1} : ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write($"Введите искомый столбец от 0 до {res.GetLength(1) - 1}  : ");
// int columns = int.Parse(Console.ReadLine()!);

// PrintMatrix(res); // сгенерированный массив
// PrintDesiredElement(res, rows, columns); // вывод искомого элемента массива



// Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую
//  и последнюю строку массива.



// int[,] CreateMatrix(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];

//     Random rand = new Random();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             matrix[i, j] = rand.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }


// void PrintMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i,j]}\t"); 
//         }
//          Console.WriteLine();
//     }
// }


// int[,] ReversMatrix(int[,] matr)
// {
//     int rows = matr.GetLength(0);
//     int columns = matr.GetLength(1);

//     for(int i = 0; i < matr.GetLength(1); i++)
//             {
//                 int tmp = matr[rows-1, i];
//                 matr[rows-1, i] = matr[0, i];
//                 matr[0, i] = tmp;
//             }

//     return  matr;       
         
// }


// int[,] res = CreateMatrix(5, 5, 0, 10);// задаем двумерный массив и рандомный диапазон значений
// Console.WriteLine ("Начальный массив :");
// PrintMatrix(res); // сгенерированный массив
// Console.WriteLine("Перевернутый массив :");
// PrintMatrix(ReversMatrix(res));





// // Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// // находить строку с наименьшей суммой элементов.



// Console.Clear();

// int[,] CreateMatrix(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];

//     Random rand = new Random();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             matrix[i, j] = rand.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]}\t"); 
//         }
//         Console.WriteLine();
//     }
// }


// void SummMinElementsInRows(int[,] matr)
// {
    
//             int[] sumInRows = new int[matr.GetLength(0)];
//             Console.WriteLine("Суммы элементов в каждой строке: ");
//             for (int i = 0; i < matr.GetLength(0); i++)
//             {
//                 for (int j = 0; j < matr.GetLength(1); j++)
//                 {
//                     sumInRows[i] += matr[i, j];
//                 }
//                 Console.WriteLine($"{sumInRows[i]} ");
//             }
//             int minSumm  = 0;
//             for (int i = 0; i < sumInRows.Length; i++)
//             {
//                 if (sumInRows[minSumm ] > sumInRows[i]) minSumm  = i;
//             }
//             Console.WriteLine($"Наименьшая сумма элементов: {sumInRows[minSumm ]} номер строки с минимальной суммой элементов {minSumm +1}");
            
// }



// int[,] res = CreateMatrix(5, 5, 0, 10);

// PrintMatrix(res); 
// SummMinElementsInRows(res);






// Задача №4 Задайте двумерный массив из целых чисел. Напишите программу,
// которая удалит строку и столбец, на пересечении которых расположен 
// наименьший элемент массива.
// Под удалением понимается создание нового двумерного массива без строки и столбца
Console.Clear();

int[,] CreateMatrix(int rows, int columns, int minRND, int maxRND) // метод создания массива и заполнения случайными числами
{
    int[,] matrix = new int[rows, columns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j] = random.Next(minRND, maxRND +1);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matrix) //метод печати массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }
}

int [] GetIndexMinElement(int[,] matrix) //Метод определение индекса наименьшего элемента массива
{
    int[] index = new int[2];
    int min = matrix[0,0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (min > matrix[i,j]) 
            {
                min = matrix[i,j];
                index[0] = i;
                index[1] = j;
            }
        }
    }
    return index;
}


int[,] GetFinalMatrix(int[,] matrix, int[] index) // метод получающий финальный массив
{
    int [,] result = new int [matrix.GetLength(0) - 1, matrix.GetLength(0) - 1];
    int rows = 0;
    int columns = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i == index[0]) continue;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == index[1]) continue;
            result [rows, columns] = matrix[i, j];
            columns++;
        }
        columns = 0;
        rows++;
    }
    return result;
}


int[,] res = CreateMatrix(3,3,0,10);
PrintMatrix(res);
Console.WriteLine();
Console.WriteLine($"Минимальный элемент: [{string.Join("; ", GetIndexMinElement(res))}]");
PrintMatrix(GetFinalMatrix(res, GetIndexMinElement(res)));