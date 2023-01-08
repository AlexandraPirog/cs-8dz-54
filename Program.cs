/*Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.*/

Console.Clear();
int m = inputNumber("Введите значение m");
int n = inputNumber("Введите значение n");
int[,] arr = new int[m, n];
FillArrayWithRandomNumbers(arr);
System.Console.WriteLine();
FixArrayWithRightOrder(arr);
InputRightArray(arr);

int inputNumber(string str)
{
    int number;
    string text;
    while (true)
    {
        System.Console.WriteLine(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("не удалось распознать число");

    }
    return number;
}

void FillArrayWithRandomNumbers(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Convert.ToInt32(new Random().Next(-100, 100));
            System.Console.Write(arr[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

void FixArrayWithRightOrder(int[,] arr)
{
    int temp;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int l = 0; l < arr.GetLength(1); l++)
        {

            for (int j = 1; j < arr.GetLength(1); j++)
            {
                if (arr[i, j - 1] < arr[i, j])
                {
                    temp = arr[i, j - 1];
                    arr[i, j - 1] = arr[i, j];
                    arr[i, j] = temp;
                }
            }
        }
    }
}

void InputRightArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write( arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}