// Задача: Написать программу, которая из имеющегося массива строк
//  формирует новый массив из строк, длина которых меньше, 
//  либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//  либо задать на старте выполнения алгоритма. 
//  При решении не рекомендуется пользоваться коллекциями, 
//  лучше обойтись исключительно массивами.

string[] initialArray = { "of", "orange", "cat", "to", "elephant", "fox", "beer" };
string[] FilterArrayByLength(string[] array)
    {
    
        int count = 0;
        foreach (string item in array)
        {
            if (item.Length <= 3)
            {
                count++;
            }
        }

        string[] filteredArray = new string[count];

        int index = 0;
        foreach (string item in array)
        {
            if (item.Length <= 3)
            {
                filteredArray[index] = item;
                index++;
            }
        }

        return filteredArray;
    }
 string[] filteredArray = FilterArrayByLength(initialArray);

        Console.WriteLine("Отфильтрованный массив:");
        foreach (string item in filteredArray)
        {
            Console.Write($"{item} ");
        }
