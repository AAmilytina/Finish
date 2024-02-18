
# Решение задачи.

* Предлагаем пользователю заполнить (начальный) массив строк:
```
Console.WriteLine("Введите размер массива: ");
int n = int.Parse(Console.ReadLine()!);
string[ ] StartArray=new string[n];
Console.WriteLine("Введите элементы массива нажимая Enter: ");
for (int i = 0; i < n; i++)
 {   
    StartArray[i] = Console.ReadLine()!;
 }
```
Вариант для ввода данных самостоятельно:
```
//string[] StartArray = new string[] {"кот", "цветы", "456", "н1н1н1", "любовь", "1", "кто"}; 
```

* Создаем метод, перебирающий каждый элемент строчного массива, сравниваем количество символов элемента с заданным значением "3":

```
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
```
А также вызов этого метода:
```
CheckArray(StartArray, FinishArray);
```
*Для удобства добавим команду очистки консоли:*
```
Console.Clear();
```

* Создаем метод формирования и вывода конечного массива, элементы которого будут состоять из элементов начального массива, но состоящие из одного/двух/трех символов:

```
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
```
* Вывод результата:
```
Console.WriteLine( "Массив из строк меньше, либо равных трем символам: ");
PrintArray(FinishArray);
