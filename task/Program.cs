//Опишем метод сортировки
string[] SortMethod(string[] array)
{
    int size = 0;
    string[] sortedarray = new string [size];
    for (int i = 0; i < array.Length;i++)
    {
        if (array[i].Length <= 3)
        {
            Array.Resize(ref sortedarray, sortedarray.Length + 1);
            sortedarray[i] = array[i];
        }
    }

    return sortedarray;
}









// Зададим первоначальный массив
string[] toSortArray1 = { "hello", "2", "world", ":-)" };
// Выведем массив в консоль
Console.WriteLine(toSortArray1);
Console.WriteLine();
//Выведем отсортированный массив
Console.WriteLine(SortMethod(toSortArray1));