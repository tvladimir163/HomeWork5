Console.Clear();

// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// // Напишите программу, которая покажет количество чётных чисел в массиве.

// // [345, 897, 568, 234] -> 2


// int[] array = new int[new Random().Next(5, 15)];
// int count = 0;
// for (int i = 0; i<array.Length; i++)
// {
//     array[i] = new Random().Next(1, 200);
//     if (array [i] % 2 == 0)
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
// int sumNeg =0;
// for (int i = 0; i<array.Length; i++)
// {
//     array[i] = new Random().Next(1, 200);
//     if (array [i] % 2 == 1)
//     {
//         sumNeg += array[i];
//         count++;
        
//     }
// }

// Console.WriteLine($"[{string.Join(", ", array)}] сумма нечетных чисел в массиве состовляет: {sumNeg}");