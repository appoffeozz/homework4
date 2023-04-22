/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.WriteLine("Введите количество чисел"); 
bool isParsed = int.TryParse(Console.ReadLine(), out int size); 

if (!isParsed) 
{
    Console.WriteLine("Введено не число"); 
    return; 
}

if (size == 0) 
{
    Console.WriteLine("Размер массива должен быть больше 0"); 
    return;
}


int[] array = GenerateArrayNumbers(size);

PrintArray(array);

int tmp = FindQuantitiNumbers(array);

if (tmp == 0 && tmp >= 10)
{
    Console.WriteLine($"Пользователь ввел {tmp} чисел больше нуля"); 
}
else if (tmp >= 2 & tmp <= 4)
{
    Console.WriteLine($"Пользователь ввел {tmp} числа больше нуля"); 
}
else if (tmp == 1)
{
    Console.WriteLine($"Пользователь ввел {tmp} число больше нуля");
}


int[] GenerateArrayNumbers(int size)
{
    int[] array = new int[size]; 

    for (int i = 0; i < size; ) 
    {
        Console.WriteLine($"Введите число {i+1}"); 
        bool isParsed1 = int.TryParse(Console.ReadLine(), out int number); 
        
        if (!isParsed1) 
        {
            Console.WriteLine("Введите число"); 
            continue; 
        }
        else 
        {
            array[i] = number; 
            i++; 
        }
    }

    return array; 
}



int FindQuantitiNumbers(int[] array)
{
    int tmp = 0; 

    for (int i = 0; i < array.Length; i++) 
    {
        if (array[i] > 0) 
        {
            tmp++; 
        }
    }

    return tmp; 
}


void PrintArray(int[] array)
{
    Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
}
