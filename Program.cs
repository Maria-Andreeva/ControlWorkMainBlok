//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Write("Enter amount of elements: ");

int elementsCount;

if(!int.TryParse(Console.ReadLine(), out elementsCount))
{
    Console.WriteLine("Wrong user input");
    return;
}

string[] arr = new string[elementsCount];

for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"Enter element {i+1}: ");
    arr[i] = Console.ReadLine()!;
}

string output = String.Join(", ", arr.Where(el => el.Length <= 3));
Console.WriteLine("[" + output + "]");
