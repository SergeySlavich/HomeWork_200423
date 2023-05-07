using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace HomeWork_200423
{
    internal class Program
    {
        static void showMatrix(int[,] matrix, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j]);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }
        static void showMatrix(double[,] matrix, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j]);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
        ///*        Можно раскомментировать строку для пропуска задачи
            Console.WriteLine("\n\t\t*** Задание 2. Задача 1. ***\n");
            Console.WriteLine("\nОбъявить одномерный(5 элементов) массив с именем A и двумерный массив(3 строки, 4 столбца) дробных чисел с именем B." +
                "Заполнить одномерный массив А числами, введенными с клавиатуры пользователем, а двумерный массив В случайными числами с помощью циклов." +
                "Вывести на экран значения массивов: массива А в одну строку, массива В — в виде матрицы." +
                "Найти в данных массивах общий максимальный элемент, минимальный элемент, общую сумму всех элементов, общее произведение всех элементов," +
                "сумму четных элементов массива А, сумму нечетных столбцов массива В.");
            int size = 5, rows = 3, cols = 4;
            double[] A = new double[size];
            double[,] B = new double[rows, cols];
            Random rnd = new Random();
            // manual filling
            for (int i = 0; i < size; i++)
            {
                Console.Write($"\nВведите {i + 1}-е значение для массива: ");
                A[i] = Convert.ToDouble(Console.ReadLine());
            }
            // show array
            for (int i = 0; i < size; i++)
            {
                Console.Write(A[i]);
                if (i < size - 1)
                {
                    Console.Write("; ");
                }
                else
                {
                    Console.WriteLine('.');
                }
            }
            //  automatic filling
            Console.WriteLine();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    B[i, j] = rnd.NextDouble();
                }
            }
            //  show array
            showMatrix(B, rows, cols);
            //      max element
            double max = A[0];
            for (int i = 0; i < size; i++)
            {
                if (A[i] - max > 0)
                {
                    max = A[i];
                }
            }
            Console.WriteLine($"Максимальное значение массива А: {max}");
            max = B[0, 0];
            for (int i = 0; i < rows;i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (B[i, j] - max > 0)
                    {
                        max = B[i, j];
                    }
                }
            }
            Console.WriteLine($"Максимальное значение массива B: {max}");
            //      min element
            double min = A[0];
            for (int i = 0; i < size; i++)
            {
                if (A[i] - min < 0)
                {
                    min = A[i];
                }
            }
            Console.WriteLine($"Минимальное значение массива А: {min}");
            min = B[0, 0];
            for (int i = 0; i < rows;i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (B[i, j] - min < 0)
                    {
                        min = B[i, j];
                    }
                }
            }
            Console.WriteLine($"Минимальное значение массива B: {min}");
            //      summ of elements
            double summ = 0;
            for (int i = 0; i < size; i++)
            {
                summ += A[i];
            }
            Console.WriteLine($"Сумма всех элементов массива А: {summ}");
            summ = 0;
            for (int i = 0; i < rows;i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    summ += B[i, j];
                }
            }
            Console.WriteLine($"Сумма всех элементов массива B: {summ}");
            //      multiplication of elements
            double mult = 1;
            for (int i = 0; i < size; i++)
            {
                mult *= A[i];
            }
            Console.WriteLine($"Сумма всех элементов массива А: {mult}");
            mult = 1;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    mult *= B[i, j];
                }
            }
            Console.WriteLine($"Сумма всех элементов массива B: {mult}");
            //      summ of seconds elements
            double summ_sec = 0;
            for (int i = 0; i < size; i++)
            {
                if (i % 2 == 0)
                {
                    summ_sec += A[i];
                }
            }
            Console.WriteLine($"Сумма четных элементов массива A: {summ_sec}");
            double summ_sec_cols = 0;
            for (int i = 0; i < rows;i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j % 2 == 1)
                    {
                        summ_sec_cols += B[i, j];
                    }
                }
            }
            Console.WriteLine($"Сумма элементов нечетных столбцов массива B: {summ_sec_cols}");
            //*/

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        ///*        Можно раскомментировать строку для пропуска задачи
            Console.WriteLine("\n\t\t*** Задание 2. Задача 2. ***\n");
            Console.WriteLine("\nДан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100." +
                "Определить сумму элементов массива, расположенных между минимальным и максимальным элементами.");
            int rows2 = 5, cols2 = 5;
            int[,] C = new int[rows2, cols2];
            // filling array
            Random rnd2 = new Random();
            int down = -100, up = 100;
            for (int i = 0; i < rows2; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    C[i, j] = rnd2.Next(down, up);
                }
            }
            //      showing array
            for (int i = 0; i < rows2; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    Console.Write(C[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            //      find min
            int rowOfMin = 0, colOfMin = 0;
            int min2 = C[rowOfMin, colOfMin]; 
            for (int i = 0; i < rows2; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    if (C[i, j] < min2)
                    {
                        min2 = C[i, j];
                        rowOfMin = i;
                        colOfMin = j;
                    }
                }
            }
            //      find max
            int rowOfMax = 0, colOfMax = 0;
            int max2 = C[rowOfMax, colOfMax];
            for (int i = 0; i < rows2; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    if (C[i, j] > max2)
                    {
                        max2 = C[i, j];
                        rowOfMax = i;
                        colOfMax = j;
                    }
                }
            }
            Console.WriteLine($"Minimal value of array = {min2}, from row {rowOfMin}, col {colOfMin}.");
            Console.WriteLine($"Maximal value of array = {max2}, from row {rowOfMax}, col {colOfMax}.");
            //      summ of elements between maximal and minimal elements
            int beginRow, beginCol, endRow, endCol;
            if (rowOfMax > rowOfMin)
            {
                beginRow = rowOfMin;
                endRow = rowOfMax;
                beginCol = colOfMin;
                endCol = colOfMax;
            }
            else
            {
                beginRow = rowOfMax;
                endRow = rowOfMin;
                beginCol = colOfMax;
                endCol = colOfMin;
            }
            Console.WriteLine($"beginRow = {beginRow}");
            Console.WriteLine($"endRow = {endRow}");
            Console.WriteLine($"beginCol = {beginCol}");
            Console.WriteLine($"endCol = {endCol}");
            int summ2 = 0;
            for (int i = beginRow; i <= endRow; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    if (i == beginRow)
                    {
                        j = beginCol;
                    }
                    if (i < endRow || (i == endRow && j <= endCol))
                    {
                        summ2 += C[i, j];
                    }
                }
            }
            Console.WriteLine($"Summ of elements between minimal and maximal elements: {summ2}");
            //*/

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        ///*        Можно раскомментировать строку для пропуска задачи
            Console.WriteLine("\n\t\t*** Задание 2. Задача 3. ***\n");
            Console.WriteLine("\nПользователь вводит строку с клавиатуры.Необходимо зашифровать данную строку используя шифр Цезаря." +
                "Из Википедии:" +
                "1 Шифр Цезаря — это вид шифра подстановки, в котором каждый символ в открытом тексте заменяется символом," +
                "находящимся на некотором постоянном числе позиций левее или правее него в алфавите." +
                "Например, в шифре со сдвигом вправо на 3, A была бы заменена на D, B станет E, и так далее." +
                "Подробнее тут: https://en.wikipedia.org/wiki/Caesar_cipher." +
                "Кроме механизма шифровки, реализуйте механизм расшифровывания.");
            Console.WriteLine("Введите строку, которую требуется зашифровать:");
            string input_str = Console.ReadLine();
            Console.WriteLine("Введите ключ (число):");
            int key = Convert.ToInt32(Console.ReadLine()) % 26;
            char[] coding_text = input_str.ToCharArray();
            // code Ceasar_light
            for (int i = 0;  i < coding_text.Length; i++)
            {
                if (((int)coding_text[i] + key < 65) || ((int)coding_text[i] + key < 97 && (int)coding_text[i] + key > 90))
                    coding_text[i] = (char)((int)coding_text[i] + key + 26);
                if (((int)coding_text[i] + key > 90 && (int)coding_text[i] + key < 97) || (int)coding_text[i] + key > 122)
                    coding_text[i] = (char)((int)coding_text[i] + key - 26);
                coding_text[i] = (char)((int)coding_text[i] + key);
                //Console.Write(coding_text[i]);
            }
            string output_str = new string(coding_text);
            Console.WriteLine(output_str);
            //      uncoding
            //Console.WriteLine("Введите ключ (число):");
            int unkey = -key;//key = Convert.ToInt32(Console.ReadLine()) % 26;
            char[] uncoding_text = output_str.ToCharArray();
            for (int i = 0; i < uncoding_text.Length; i++)
            {
                if (((int)uncoding_text[i] + unkey < 65) || ((int)uncoding_text[i] + unkey < 97 && (int)uncoding_text[i] + unkey > 90))
                    uncoding_text[i] = (char)((int)uncoding_text[i] + unkey + 26);
                if (((int)uncoding_text[i] + unkey > 90 && (int)uncoding_text[i] + unkey < 97) || (int)uncoding_text[i] + unkey > 122)
                    uncoding_text[i] = (char)((int)uncoding_text[i] + unkey - 26);
                uncoding_text[i] = (char)((int)uncoding_text[i] + unkey);
                //Console.Write(uncoding_text[i]);
            }
            string uncoding_str = new string(uncoding_text);
            Console.WriteLine("Расшифрованное сообщение:");
            Console.WriteLine(uncoding_str);
            //*/

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        ///*        Можно раскомментировать строку для пропуска задачи
            Console.WriteLine("\n\t\t*** Задание 2. Задача 4. ***\n");
            Console.WriteLine("\nСоздайте приложение, которое производит операции над матрицами:" +
                "■ Умножение матрицы на число;" +
                "■ Сложение матриц;" +
                "■ Произведение матриц.");
            
            int rows3 = 5, cols3 = 5, up3 = 100, down3 = -100;
            int[,] D = new int[rows3, cols3];
            // filling array
            Random rnd3 = new Random();
            for (int i = 0; i < rows3; i++)
            {
                for (int j = 0; j < cols3; j++)
                {
                    D[i, j] = rnd3.Next(down3, up3);
                }
            }
            //      show array
            showMatrix(D, rows3, cols3);
            
            //      multiple matrix to number
            Console.Write("Введите число, на которое нужно умножить матрицу: ");
            int k = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < rows3; i++)
            {
                for (int j = 0; j < cols3; j++)
                {
                    D[i, j] *= k;
                }
            }
            //      show array
            Console.WriteLine("Результат умножения матрицы на число:");
            showMatrix(D, rows3, cols3);
            
            //      summ of matrix
            // filling arrays
            int[,] arr1 = new int[rows3, cols3];
            int[,] arr2 = new int[rows3, cols3];
            for (int i = 0; i < rows3; i++)
            {
                for (int j = 0; j < cols3; j++)
                {
                    arr1[i, j] = rnd.Next(down3, up3);
                }
            }
            for (int i = 0; i < rows3; i++)
            {
                for (int j = 0; j < cols3; j++)
                {
                    arr2[i, j] = rnd.Next(down3, up3);
                }
            }
            //      show arrays
            Console.WriteLine("Матрица №1:");
            showMatrix(arr1, rows3, cols3);
            Console.WriteLine("Матрица №2:");
            showMatrix(arr2, rows3, cols3);
            //      summ of matrixes
            Console.WriteLine("Результирующая матрица:");
            int[,] summArr = new int[rows3, cols3];
            for (int i = 0; i < rows3; i++)
            
            {
                for (int j = 0; j < cols3; j++)
                {
                    summArr[i, j] = arr1[i, j] + arr2[i, j];
                }
            }
            //      show result array
            Console.WriteLine("Сумма матриц:");
            showMatrix(summArr, rows3, cols3);
            
            //      multiple of matrix
            int rows4 = 4, cols4 = 5, rows5 = 5, cols5 = 6, down4 = -50, up4 = 50;
            // filling arrays
            int[,] array1 = new int[rows4, cols4];
            int[,] array2 = new int[rows5, cols5];
            for (int i = 0; i < rows4; i++)
            {
                for (int j = 0; j < cols4; j++)
                {
                    array1[i, j] = rnd.Next(down4, up4);
                }
            }
            for (int i = 0; i < rows5; i++)
            {
                for (int j = 0; j < cols5; j++)
                {
                    array2[i, j] = rnd.Next(down4, up4);
                }
            }
            //      show arrays
            Console.WriteLine("Матрица N1:");
            showMatrix(array1, rows4, cols4);
            Console.WriteLine("Матрица N2:");
            showMatrix(array2, rows5, cols5);
            //      multiple of matrix
            int[,] result4 = new int[rows4, cols5];
            for (int i = 0; i < rows4; i++)
            {
                for (int j = 0; j < cols4; j++)
                {
                    result4[i, j] = 0;
                    for (int l = 0; l < rows5; l++)
                    {
                        result4[i, j] += array1[i, l] * array2[l, i];
                    }
                }
            }
            //      show result matrix
            Console.WriteLine("Произведение матриц N1 и N2:");
            showMatrix(result4, rows4, cols5);
            //*/

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        ///*        Можно раскомментировать строку для пропуска задачи
            Console.WriteLine("\n\t\t*** Задание 2. Задача 5. ***\n");
            Console.WriteLine("\nПользователь с клавиатуры вводит в строку арифметическое выражение." +
                "Приложение должно посчитать его результат." +
                "Необходимо поддерживать только две операции: + и –.");
            Console.WriteLine("Введите в следующей строке арифметическое выражение (поддерживаются только '+' и '-'):");
            string inputed_string = Console.ReadLine();       //Ввод выражения
            string input_string = inputed_string;
            if (input_string.IndexOf('-') == 0)             //Вставка начального 0
            {
                input_string = input_string.Insert(0, "0");
            }
            input_string = input_string.Trim();             //Модификация выражения
            input_string = input_string.Replace("-", " -");
            input_string = input_string.Replace("+", " ");
            //Console.WriteLine(input_string);
            string[] formula = input_string.Split(' ');     //создание строкового массива значений
            int[] ints = new int[formula.Length];                               //создание массива чисел
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    Console.WriteLine(ints[i]);
            //}
            for (int i = 0; i < formula.Length; i++)                            //заполнение массива чисел конвертированными значениями строкового массива
            {
                ints[i] = Convert.ToInt32(formula[i]);
            }
            int result5 = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                result5 += ints[i];
            }
            Console.WriteLine($"Результат выражения: {inputed_string}={result5}");
            //*/

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        ///*        Можно раскомментировать строку для пропуска задачи
            Console.WriteLine("\n\t\t*** Задание 2. Задача 6. ***\n");
            Console.WriteLine("\nПользователь с клавиатуры вводит некоторый текст." +
                "Приложение должно изменять регистр первой буквы каждого предложения на букву в верхнем регистре." +
                "Например, если пользователь ввёл: «today is a good day for walking.i will try to walk near the sea»." +
                "Результат работы приложения: «Today is a good day for walking.I will try to walk near the sea».");
            Console.WriteLine("Введите текст, который будет модифицирован по правилам:");
            string input_text = Console.ReadLine();
            char[] text = input_text.ToCharArray();
            text[0] = Char.ToUpper(text[0]);
            for (int i = 2; i <  text.Length; i++)
            {
                if (text[i - 2] == '.' && text[i - 1] == ' ')
                {
                    text[i] = Char.ToUpper(text[i]);
                }
            }
            string output = new string(text);
            Console.WriteLine(output);
            //*/

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        ///*        Можно раскомментировать строку для пропуска задачи
            Console.WriteLine("\n\t\t*** Задание 2. Задача 7. ***\n");
            Console.WriteLine("\nСоздайте приложение, проверяющее текст на недопустимые слова." +
                "Если недопустимое слово найдено, оно должно быть заменено на набор символов *." +
                "По итогам работы приложения необходимо показать статистику действий." +
                "Например, если и у нас есть такой текст:" +
                "To be, or not to be, that is the question," +
                "Or to take arms against a sea of troubles," +
                "And by opposing end them? To die: to sleep;" +
                "No more; and by a sleep to say we end" +
                "Devoutly to be wish'd. To die, to sleep" +
                "Недопустимое слово: die." +
                "Результат работы:" +
                "To be, or not to be, that is the question," +
                "3 Or to take arms against a sea of troubles," +
                "And by opposing end them? To ***: to sleep;" +
                "No more; and by a sleep to say we end" +
                "Devoutly to be wish'd. To ***, to sleep." +
                "Статистика: 2 замены слова die.");
            Console.WriteLine("Введите недопустимое слово:");
            string word = Console.ReadLine();
            Console.WriteLine("Введите текст для проверки:");
            string text7 = Console.ReadLine();
            string[] modified_text = text7.Split(' ');
            string[] unmodified_text = modified_text;
            int statistic = 0;
            for (int i = 0; i < modified_text.Length;i++)
            {
                modified_text[i] = unmodified_text[i].Replace(word, "***");
                if (modified_text[i].Contains("***"))
                {
                    statistic += 1;
                }
            }
            string output_text = "Result: ";
            for (int i = 0; i < modified_text.Length; i++)
            {
                output_text = String.Concat(output_text, ' ', modified_text[i]);
            }
            Console.WriteLine(output_text);
            Console.WriteLine($"Статистика: {statistic} замены слова \"{word}\"");
            //*/
        }
    }
}