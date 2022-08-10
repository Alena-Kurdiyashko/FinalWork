Console.WriteLine("Введите 4 элемента массива через Enter: ");
string[] array = new string[4];

FillArray(array);
PrintArray(array);

void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
    array[i] = Convert.ToString(Console.ReadLine());
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
    Console.Write(array[i] + " ");
    }
}

int sizeNewArray = 0;
string[] FillNewArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            sizeNewArray++;
        }
    }

    string[] newArray = new string[sizeNewArray];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

Console.WriteLine();
FillNewArray(array);
Console.Write("Новый массив: ");
PrintArray(FillNewArray(array));
