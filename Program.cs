//***********************************************************
// Задача 39: Напишите программу, которая певернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый -на последнем и т.д.)
// Пример:
// [1, 2, 3, 4, 5] -> [5, 4, 3, 2, 1]
// [6, 7, 3, 6] -> [6, 3, 7, 6]

// void FillArray(int[] array)
// {
//     for (var i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-10, 11);
//     }
// }

// void PrintArray(int[] array)
// {
//     foreach (var item in array)
//     {
//         System.Console.Write($"{item} ");
//     }
//     System.Console.WriteLine();
// }

// void ReversArray(int[] array)
// {
//     //int temp = 0;
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         // temp = array[array.Length - 1 - i];
//         // array[array.Length - 1 - i] = array[i];
//         // array[i] = temp;
//         //(x,y) = (y,x)
//         (array[array.Length - 1 - i], array[i]) = (array[i], array[array.Length - 1 - i]);
//     }
// }



// Console.Clear();
// System.Console.WriteLine("Введите размер массива: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[num];
// FillArray(array);
// PrintArray(array);
// ReversArray(array);
// PrintArray(array);





//***************************************************************************
// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с
// сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.


// void Calculation (int ab, int bc, int ca)
// {
//         if(ab < bc + ca && bc < ca + ab && ca < ab + bc)
//         System.Console.WriteLine("Такой треугольник существует");
//         else System.Console.WriteLine("Такого треугольника не существует");
// }




// System.Console.WriteLine("Введите сторону AB: ");
// int ab = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите сторону BC: ");
// int bc = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите сторону CA: ");
// int ca = Convert.ToInt32(Console.ReadLine());

// Calculation (ab, bc, ca);





//***************************************************************************
// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// Пример:
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// int LengthArray(int num)
// {
//     int result = 0;
//     while (num > 0)
//     {
//         result += 1;
//         num /= 2;
//     }
//     return result;
// }

// void FillArray(int[] array, int num)
// {
//     int result = 0;
//     for (var i = 0; i < array.Length; i++)
//     {
//         if (num % 2 == 0)
//             result = 0;
//         else result = 1;
//         array[i] = result;
//         num /= 2;
//     }
//     Array.Reverse(array);
// }

// void PrintArray(int[] array)
// {
//     foreach (var item in array)
//     {
//         System.Console.Write(item);
//     }
// }



// System.Console.WriteLine("Введите число:");
// int num = int.Parse(Console.ReadLine()!);
// int lengthArray = LengthArray(num);
// int[] array = new int[lengthArray];
// FillArray(array, num);

// System.Console.Write($"Ваше десятичное число {num} преобразованно в двоичное число: ");
// PrintArray(array);





//***************************************************************************
// Задача 44: Не используя рекурсию, выведите первый N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Пример:
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


// void FillArray(int[] array)
// {
//     array[0] = 0;
//     array[1] = 1;
//     for (var i = 2; i < array.Length; i++)
//     {
//         array[i] = array[i - 2] + array[i - 1];
//     }
// }

// void PrintArray (int[] array)
// {
//     foreach (var item in array)
//     {
//         System.Console.Write($"{item} ");
//     }
// }



// System.Console.WriteLine("Введите сколько чисел Фибоначчи вывевести: ");
// int num = int.Parse(Console.ReadLine()!);
// int[] array = new int[num];
// FillArray(array);
// PrintArray(array);










//*************************************************************************** ПРАКТИЧЕСКОЕ ЗАДАНИЕ **********************************
// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Пример:
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 3

// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.WriteLine("Введите число: ");
//         array[i] = int.Parse(Console.ReadLine()!);
//     }
// }

// void PrintArray(int[] array)
// {
//     foreach (var item in array)
//     {
//         System.Console.Write($"{item} ");
//     }
// }

// int ArrayResult(int[] array)
// {
//     int result = 0;
//     for (var i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//         result += 1;
//     }
//     return result;
// }



// Console.Clear();
// System.Console.WriteLine("Введите количество чисел: ");
// int[] array = new int[int.Parse(Console.ReadLine()!)];
// FillArray(array);
// PrintArray(array);
// System.Console.WriteLine();
// System.Console.WriteLine($"В Вашем массиве числа > 0 найдено: {ArrayResult(array)}");






//***************************************************************************
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// Пример:
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// void ResultFormul(double b1, double b2, double k1, double k2)
// {
//     double resultX = 0;
//     double resultY = 0;
//     resultX = -((b1 - b2) / (k1 - k2));
//     resultY = k2 * resultX + b2;
//     System.Console.WriteLine($"{resultX}, {resultY}");
// }


// System.Console.WriteLine("Введите b1: ");
// double b1 = int.Parse(Console.ReadLine()!);
// System.Console.WriteLine("Введите b2: ");
// double b2 = int.Parse(Console.ReadLine()!);
// System.Console.WriteLine("Введите k1: ");
// double k1 = int.Parse(Console.ReadLine()!);
// System.Console.WriteLine("Введите k2: ");
// double k2 = int.Parse(Console.ReadLine()!);

// ResultFormul(b1, b2, k1, k2);








//***************************************************************************
// Задача НЕГАФИБОНАЧЧИ необязательная. Задайте число. Составьте массив чисел НегаФибоначчи, в том числе для отрицательных индексов.
// Пример:
// для k = 9 массив будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]

void FillArray(int[] array)
{
    int averageLength = array.Length / 2 + 2;
    array[array.Length / 2] = 0;
    array[array.Length / 2 + 1] = 1;
    for (int i = averageLength; i < array.Length; i++)
    {
        array[i] = array[i - 2] + array[i - 1];
    }
    for (int i = array.Length / 2 - 1; i >= 0; i--)
    {
        array[i] = array[i + 2] - array[i + 1];
    }
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write($"{item} ");
    }
}



System.Console.WriteLine("Введите промежуток чисел Негафибоначчи: ");
int num = int.Parse(Console.ReadLine()!);
int[] array = new int[num + num - 1];
FillArray(array);
PrintArray(array);









//***************************************************************************
// Задача VERY HARD необязательная Имеется массив случайных целых чисел. Создайте массив, в который попадают числа,
// описывающие максимальную сплошную возрастающую последовательность. Порядок элементов менять нельзя.
// Одно число - это не последовательность.
// Пример:
// [1, 5, 2, 3, 4, 6, 1, 7] => [1, 7] так как здесь вразброс присутствуют все числа от 1 до 7

// [1, 5, 2, 3, 4, 1, 7, 8 , 15 , 1 ] => [1, 5] так как здесь есть числа от 1 до 5 и эта последовательность длиннее чем от 7 до 8

// [1, 5, 3, 4, 1, 7, 8 , 15 , 1 ] => [3, 5] так как здесь есть числа от 3 до 5 и эта последовательность длиннее чем от 7 до 8
