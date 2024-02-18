
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
