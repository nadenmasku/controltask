//Опишем метод сортировки
// string[] SortMethod(string[] array)
// {
    
//     string[] sortedarray = new string [0];
//     for (int i = 0; i < array.Length;i++)
//     {
//         if (array[i].Length <= 3)
//         {
//             Array.Resize(ref sortedarray, sortedarray.Length + 1);
//             sortedarray[i] = array[i];
//         }
//     }

//     return sortedarray;
// }

//Опишем вывод массива
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length;i++)
    {
        Console.Write(array[i]);
    }
}








// Зададим первоначальный массив
string [] toSortArray1 = { "hello", "2", "world", ":-)" };
// Выведем массив в консоль

Console.WriteLine();
//Выведем отсортированный массив
