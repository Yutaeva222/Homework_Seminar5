// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void FillArray(double[] arr) 
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.NextDouble();
        arr[i] = (Convert.ToDouble(random.Next(0,10)) + random.NextDouble());
        arr[i] = Math.Round(arr[i], 2);
    }
}
void PrintArray(double[] arr) 
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}
double FindMax(double[] arr)
    {
        double max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max) 
                    max = arr[i];
            }
            return max;
    }

    double FindMin(double[] arr)
    {
        double min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min) 
                    min = arr[i];
            }
            return min;
    }  

    double FindDif(double[] arr)
    {
        double dif = 0;
        double max = FindMax(arr);
        double min = FindMin(arr);
        dif = max - min;
        dif = Math.Round(dif, 2);
        return dif;
    }  
Console.Clear();
double[] massiv = new double[8];
FillArray(massiv);
PrintArray(massiv);
Console.WriteLine("Максимальный элемент массива = " + FindMax(massiv));
Console.WriteLine("Минимальный элемент массива = " + FindMin(massiv));
Console.WriteLine("Разница между макс. и мин. элементами массива = " + FindDif(massiv));