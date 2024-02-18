// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
//либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void CheckArray (string[] StartArray, string[] FinishArray)
    {
        int count = 0;
        for(int i = 0; i <StartArray.Length; i++)
        {
            if(StartArray[i].Length <= 3)
            {
                FinishArray[count] = StartArray[i];
                count++;
            }
        }
    }

Console.Clear();
Console.WriteLine("Введите размер массива: ");
            int n = int.Parse(Console.ReadLine()!);
            string[] StartArray=new string[n];
            Console.WriteLine("Введите элементы массива нажимая Enter: ");
            for (int i = 0; i < n; i++)
            {
                StartArray[i] = Console.ReadLine()!; // заполнение массива
            }

            //string[] StartArray = new string[] {"кот", "цветы", "456", "н1н1н1", "любовь", "1", "кто"}; - вариант с самостоятельным заполнением массива.

string [] FinishArray = new string[StartArray.Length];
Console.WriteLine( "Первоначальный массив:");

CheckArray(StartArray, FinishArray);