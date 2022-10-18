// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива ");
int n = Convert.ToInt32(Console.ReadLine());

double[] array = new double[n];
double result = 0;

for (int i = 0; i < n; i++)
{
   array[i] = new Random().NextDouble();
   Console.Write(array[i] + " ");
}
double Max = array[0]; // вещественное число
double Min = array[0];
for (int i = 0; i < n; i++)
{
   if (array[i] > Max) Max = array[i];
   if (array[i] < Min) Min = array[i];
}
  Console.WriteLine();
  result = Max - Min;
  Console.WriteLine($"Разница между максимальным и минимальным элементами массива {result}");








