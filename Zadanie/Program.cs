void Zadanie_block_result()
{
string[] array1 = new string[5] {"privet", "75", "87665", "kak_dela", "123"};
string[] array2 = new string[array1.Length];
PrintArray(array2);
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
}
Zadanie_block_result();