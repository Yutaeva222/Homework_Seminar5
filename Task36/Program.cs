// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArray(int[] arr) 
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 10);
    }
}
void PrintArray(int[] arr) 
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}
int SumNechetIndex (int [] arr)
{
    int summ = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1)
           summ = summ + arr[i];
    }
    return summ;
}
Console.Clear();
int[] massiv = new int[10];
FillArray(massiv);
PrintArray(massiv);
Console.WriteLine("Сумма элементов нечетных позиций в массиве = " + SumNechetIndex(massiv));