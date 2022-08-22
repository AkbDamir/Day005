/*Задача 35: Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, 
значения которых лежат в отрезке [10,99].

Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123

[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/
void FillArray(int[] random)
{
    int length = random.Length;
    int index = 0;
    while (index < length)
    {
        random[index] = new Random().Next(1, 999);
        index++;
    }
}
void PrintArr(int[] number)
{
    int count = number.Length;
    int pos = 0;
    while (pos < count)
    {
        Console.Write(number[pos] + ", ");
        pos++;
    }
}

int[] array = new int[123];

FillArray(array);
PrintArr(array);

int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 10 & array[i] < 99)
    {
        sum ++;
    }
}
Console.WriteLine("->" + sum);