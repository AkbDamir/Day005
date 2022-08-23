/*Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, 
второй и предпоследний и т.д. 
Результат запишите в новом массиве.

[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/
void PairArr(int[] num)
{
    int n = num.Length;
    int k = n / 2;  
    for(int i =0; i < k; i++)
    {
        int a = num[i];
        int b = num[n-1-i];
        int c = a * b;
        Console.Write(c + " ");
    }
}

int[] array = {6, 7, 3, 6};
PairArr(array);

/*int[] arr1 = new int[k];
int[] arr2 = new int[k];

for(int i = 0; i < k; i++)
{
    arr1 = new int[array[i]];
    arr2 = new int[array[n - 1 - i]];
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
PrintArr(arr1);


void FillArray(int[] random)
{
    int length = random.Length;
    int index = 0;
    while (index < length)
    {
        random[index] = new ;
        index++;
    }
}
int[] arr3 = new int[k];
FillArray(arr3);
Console.Write(arr3);*/