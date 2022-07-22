/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> такого числа в массиве нет
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3;
*/

using System;

namespace MultiArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 47
            Console.WriteLine("Задача 47");
            Console.WriteLine();

            Console.WriteLine("Введите число строк матрицы");
            string inputRow = Console.ReadLine();
            int row = Convert.ToInt16(inputRow);

            Console.WriteLine("Введите число столбцов матрицы");
            string inputColumn = Console.ReadLine();
            int column = Convert.ToInt16(inputColumn);
            double[,] array = CreateDoubleArray(row, column);
            
            //Задача 50
            Console.WriteLine("Задача 50");
            Console.WriteLine("Желаемый элемент в какой строке, начиная с нуля?");
            string inputRowElement = Console.ReadLine();
            int rowElement = Convert.ToInt16(inputRowElement);

            Console.WriteLine("Желаемый элемент в каком столбце, начиная с нуля?");
            string inputColumnElement = Console.ReadLine();
            int columnElement = Convert.ToInt16(inputColumnElement);
            ShowElement(array, rowElement, columnElement);
            
            //Задача 52
            
            Console.WriteLine("Задача 52");
            Console.WriteLine();

            Console.WriteLine("Введите число строк матрицы");
            string inputRow2 = Console.ReadLine();
            int row2 = Convert.ToInt16(inputRow2);

            Console.WriteLine("Введите число столбцов матрицы");
            string inputColumn2 = Console.ReadLine();
            int column2 = Convert.ToInt16(inputColumn2);
            CreateIntArrayWithMean(row2, column2);
            
            
        }

        static void ShowElement(double[,] array, int m, int n)
        {

            if (m > array.GetLength(1) || n > array.GetLength(0))
            {
                Console.WriteLine("Такого элемента нет");
            }
            else
            {
                double element = array[m, n];
                Console.WriteLine($"{Math.Round(element, 2)}");
            }
            
        }

        static double[,] CreateDoubleArray(int m, int n)
        {
            int rows = m;
            int columns = n;
            Random rand = new Random();

            double[,] numbers = new double[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    numbers[i,j] = rand.NextDouble() * (10.00 - (-10.00)) + (-10.00);
        
                    Console.Write($"{Math.Round(numbers[i,j],2)} ");
                    
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            return numbers;

        }

        static void CreateIntArrayWithMean(int m, int n)
        {
            int rows = m;
            int columns = n;

            Random rand = new Random();

            int[,] numbers = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    numbers[i, j] = rand.Next(0,10);

                    Console.Write($"{numbers[i, j]} ");

                }
                Console.WriteLine();
            }

            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                double sum = 0;
                for (int i = 0; i < numbers.GetLength(0); i++)
                {
                    sum += numbers[i, j];
                }
                Console.WriteLine();
                Console.Write($"{ sum / numbers.GetLength(0)} ");
            }

        }

        
    }
}