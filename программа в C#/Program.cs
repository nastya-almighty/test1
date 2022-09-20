Console.WriteLine("Создаем ваш массив строк");

Console.WriteLine("Сколько строк будет в вашем массиве? ");
int N = int.Parse(Console.ReadLine());

string [] GetArray(int N)
{
    string [] array = new string [N];
    for (int i = 0; i < N; i++)
    {
        Console.WriteLine($"Введите строку номер {i + 1}: ");
        string x = Console.ReadLine();
        array [i] = x;
    }
    return array;
}

string [] myarray = GetArray(N);

int GetCount (string [] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4) count++;
    }
    return count;
}

string [] NewArray (string [] a, int size)
{
    int w = 0;
    string [] newarray = new string [size];
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i].Length < 4) 
        {
            newarray[w] = a[i];
            w++;
        }
    }
        Console.WriteLine();
        if (w == 0) Console.WriteLine("В вашем массиве нет строк, состоящих из 3 и менее символов.");
        else
        {
            Console.Write("Строки, состоящие из 3 и менее символов: ");
            Console.WriteLine(String.Join (", ", newarray));
        }
    return newarray;
}

NewArray(myarray, GetCount(myarray));