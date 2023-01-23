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
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}








// Зададим первоначальный массив
string[] toSortArray1 = { "hello", "2", "world", ":-)" };
// Выведем массив в консоль
PrintArray(toSortArray1);
Console.WriteLine();
//Выведем отсортированный массив
PrintArray(SortMethod(toSortArray1));