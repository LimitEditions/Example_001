// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Введите число строк");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число столбцов");
// int colums = Convert.ToInt32(Console.ReadLine());

// double [,]matrix = new double[rows,colums];
// for(int i = 0; i < matrix.GetLength(0); i++){
//     for(int j = 0; j < matrix.GetLength(1); j++){
//         matrix[i,j] = new Random().Next(-10, 10) + Math.Round(new Random().NextDouble(),1);
//         Console.Write(matrix[i,j] + "  ");
//     }
//     Console.WriteLine();
// }

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.WriteLine("Введите число строк");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число столбцов");
// int colums = Convert.ToInt32(Console.ReadLine());

// int [,]matrix = new int[rows,colums];
// for(int i = 0; i < matrix.GetLength(0); i++){
//     for(int j = 0; j < matrix.GetLength(1); j++){
//         matrix[i,j] = new Random().Next(10);
//         Console.Write(matrix[i,j] + "  ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Введите позицию строки");
// int positionRow = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите позицию столбца");
// int positionColumn = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine();

// if (positionRow < rows && positionColumn < colums){
//     Console.WriteLine(matrix[positionRow,positionColumn]);
// }
// else{
//     Console.WriteLine("Такого числа в массиве нет");
// }



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.WriteLine("Введите число строк");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число столбцов");
// int colums = Convert.ToInt32(Console.ReadLine());

// int [,]matrix = new int[rows,colums];
// for(int i = 0; i < matrix.GetLength(0); i++){
//     for(int j = 0; j < matrix.GetLength(1); j++){
//         matrix[i,j] = new Random().Next(10);
//         Console.Write(matrix[i,j] + "  ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine();

// double sum = 0;
// for (int j = 0; j < matrix.GetLength(1); j++){
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         sum += matrix[i,j];
//     }
//     sum /= matrix.GetLength(0);
//     Console.Write(Math.Round(sum,1) + "; ");
//     sum = 0;
// }