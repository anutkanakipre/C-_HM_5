// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива ");
int size = Convert.ToInt32(Console.ReadLine());

int num = 0;
int count = 0;
int[] array = new int [size];
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100,999);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
for (int j = 0; j < array.Length; j++)
{
   if (array[j] % 2 == 0) count++;
  // Console.Write(array[j] + " ");
}
if (count > 0) Console.WriteLine($"Четное число присутствует в массиве {count} раз");
else Console.WriteLine($"Число {num} отстуствует в массиве");
Console.WriteLine();




// Console.WriteLine("Введите размер массива ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[size];
// int N = Convert.ToInt32(Console.ReadLine());
// int count = 0;

// for (int i = 0; i < array.Length; i++)
// {
//    array[i] = new Random().Next(99,1000);
// }
// if(N % 2 == 0)
// {
//     Console.WriteLine ($"Количество четных чисел в массиве new int[10] {count} ");
//     else Console.WriteLine ($"четных чисел в массиве new {int[size]} нет ");
// }
// Console.WriteLine();



