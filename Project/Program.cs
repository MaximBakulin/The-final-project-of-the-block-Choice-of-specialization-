string[] arrayOne = new string[5] {"123", "23", "hello", "world", "res"};
string[] arrayTwo = new string[arrayOne.Length];
void GetArrayWithDesiredStrings(string[] array1, string[] array2)
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
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
GetArrayWithDesiredStrings(arrayOne, arrayTwo);
PrintArray(arrayTwo);
