## Проект:
**ControlWorkMainBlok**

## Описание:
Формирование нового массива из строк, длина которых меньше, либо равна 3 символам

## Решение:
* Ввести количество элементов с консоли
  
  ```
  Console.Write("Enter amount of elements: ");
  ```
* Проверить ввод, если ввод не число, то прервать программу и выдать ошибку, иначе продолжить
  
   ```
   int elementsCount;

  if(!int.TryParse(Console.ReadLine(), out elementsCount))
  {
      Console.WriteLine("Wrong user input");
      return;
  }
   ```
* Создать массив с заданной длинною количества элементов
  ```
  string[] arr = new string[elementsCount];
  ```
  
* Создать текстовую переменную output
* Перебирая элементы из массива, добавить в output. если длина элемента больше или равна 3

  ```
  string output = String.Join(", ", arr.Where(el => el.Length <= 3));
  ```  
* Вывести на экран
  ```
  Console.WriteLine("[" + output + "]");
  ```

