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




//***************************************************************************
// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// Пример:
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int LengthArray(int num)
{
    int result = 0;
    while (num > 0)
    {
        result += 1;
        num /= 2;
    }
    return result;
}

void FillArray(int[] array, int num)
{
    int result = 0;
    for (var i = 0; i < array.Length; i++)
    {
        if (num % 2 == 0)
        result = 0;
        else result = 1;
        array[i] = result;
        num /=2;
    }
    Array.Reverse(array);
}

void PrintArray (int[] array)
{
    foreach (var item in array)
    {
        System.Console.Write(item);
    }
}



System.Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()!);
int lengthArray = LengthArray(num);
int[] array = new int[lengthArray];
FillArray(array, num);

System.Console.Write($"Ваше десятичное число {num} преобразованно в двоичное число: ");
PrintArray(array);

