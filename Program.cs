// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Clear();

int m = 5;
int numbers = 0;
Console.WriteLine($"Введите {m} чисел");

int[] massiveNum = new int[m];

void Numbers(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        massiveNum[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int Comparsion (int[] massiveNum)
{
    int count = 0;
    for (int i = 0; i < massiveNum.Length; i++)
    {
        if (massiveNum[i] > 0) count += 1;
    }
    return count;
}

Numbers(m);
Console.WriteLine($"Чисел больше 0 -> {Comparsion(massiveNum)}");