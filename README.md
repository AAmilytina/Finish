
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