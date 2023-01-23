//Опишем метод сортировки
string[] SortMethod(string[] arr)
{
    int size = arr.Length;
    string[] sortedarray = new string [size];
    for (int i = 0; i < arr.Length;i++)
    {
        if (arr[i].Length <= 3)
        {
            sortedarray[i] = arr[i];
        }
    }

    return sortedarray;
}

//Опишем вывод массива
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}








// Зададим первоначальный массив
string[] toSortArray1 = { "hello", "2", "world", ":-)" };
// Выведем массив в консоль
PrintArray(toSortArray1);
Console.WriteLine();
//Выведем отсортированный массив
PrintArray(SortMethod(toSortArray1));
Console.WriteLine();


// Зададим первоначальный массив
string[] toSortArray2 = { "1234", "1567", "-2", "computer science" };
// Выведем массив в консоль
PrintArray(toSortArray2);
Console.WriteLine();
//Выведем отсортированный массив
PrintArray(SortMethod(toSortArray2));
Console.WriteLine();


// Зададим первоначальный массив
string[] toSortArray3 = { "Russia", "Denmark", "Kazan" };
// Выведем массив в консоль
PrintArray(toSortArray3);
Console.WriteLine();
//Выведем отсортированный массив
PrintArray(SortMethod(toSortArray3));
Console.WriteLine();