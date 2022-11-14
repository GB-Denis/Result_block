void Zadanie_block_result()
{
string[] array1 = new string[5] {"privet", "75", "87665", "kak_dela", "123"};
string[] array2 = new string[array1.Length];
MakeSecondArray(array1, array2);
PrintArray(array2);
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void MakeSecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
}
Zadanie_block_result();