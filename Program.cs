// Console.Clear();



// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// // Напишите программу, которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2


// int[] array = new int[new Random().Next(5, 15)];
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(100, 1000);
//     if (array[i] % 2 == 0)
//     {
//         count++;
//     }
// }

// Console.WriteLine($"[{string.Join(", ", array)}] в массиве {count} четных числа/чисел.");



// // Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// // Найдите сумму элементов, стоящих на нечётных позициях.
// // [3, 7, 23, 12] -> 19
// // [-4, -6, 89, 6] -> 0


// int[] array = new int[new Random().Next(5, 15)];
// int count = 0;
// int sumNeg = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(1, 200);
//     if (array[i] % 2 == 1)
//     {
//         sumNeg += array[i];
//         count++;
//     }
// }

// Console.WriteLine($"[{string.Join(", ", array)}] сумма нечетных чисел в массиве состовляет: {sumNeg}");



// // Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// // Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// // Результат запишите в новом массиве.
// // [1 2 3 4 5] -> 5 8 3
// // [6 7 3 6] -> 36 21


// int[] arrayA = new int[new Random().Next(5, 15)];

// for (int i = 0; i < arrayA.Length; i++)
// {
//     arrayA[i] = new Random().Next(1, 20);
// }

// int sizeB;

// if (arrayA.Length % 2 == 0)
// {
//     sizeB = arrayA.Length / 2;
// }
// else
// {
//     sizeB = arrayA.Length / 2 + 1;
// }

// int[] arrayB = new int[sizeB];

// for (int i = 0; i < sizeB; i++)
// {
//     arrayB[i] = arrayA[i] * arrayA[arrayA.Length - 1 - i];
//     if (i == sizeB - 1)

//     {

//         arrayB[i] = arrayA[i];

//     }
// }

// Console.WriteLine($"первый массив: {String.Join(", ", arrayA)}");
// Console.WriteLine($"второй массив: {String.Join(", ", arrayB)}");



// // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// // [3 7 22 2 78] -> 76

double[] array = new double[10];
double result = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToDouble(new Random().Next(1, 20));
}
double max = array[0];
double min = array[0];
for (int j = 0; j < array.Length; j++)
{
    if (array[j] > max)
    {
        max = array[j];
    }
    else if (array[j] < min)
    {
        min = array[j];
    }
}
result = max - min;
Console.WriteLine($"[{string.Join(", ", array)}] ");
Console.WriteLine($"максимальное число:{max}");
Console.WriteLine($"минимальное число: {min}");
Console.WriteLine($"разница между максимальным и минимальным элементами массива: {result}");